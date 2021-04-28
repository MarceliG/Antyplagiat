using System;
using System.Net.Sockets;
using System.Net;
    internal delegate void SocketAcceptedHandler(object sender, SocketAcceptedEventArgs e);

    internal class SocketAcceptedEventArgs : EventArgs
    {
        public Socket Accepted
        {
            get;
            private set;
        }

        public IPAddress Address
        {
            get;
            private set;
        }

        public IPEndPoint EndPoint
        {
            get;
            private set;
        }

        public SocketAcceptedEventArgs(Socket sck)
        {
            Accepted = sck;
            Address = ((IPEndPoint)sck.RemoteEndPoint).Address;
            EndPoint = (IPEndPoint)sck.RemoteEndPoint;
        }
    }

    internal class Listener
    {
        #region Variables
        private Socket socket = null;
        private bool running = false;
        private int port = -1;
        #endregion

        #region Properties
        public Socket BaseSocket
        {
            get { return socket; }
        }

        public bool Running
        {
            get { return running; }
        }

        public int Port
        {
            get { return port; }
        }
        #endregion

        public event SocketAcceptedHandler Accepted;

        public Listener()
        {

        }

        public void Start(int port)
        {
            if (running)
                return;

            this.port = port;
            running = true;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(IPAddress.Any, port));
            socket.Listen(100);                         // server can hold 100 clients
            socket.BeginAccept(AcceptCallback, null);
        }

        public void Stop()
        {
            if (!running)
                return;

            running = false;
            socket.Close();
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                Socket sck = socket.EndAccept(ar);

            Accepted?.Invoke(this, new SocketAcceptedEventArgs(sck));
        }
            catch
            {
            }

            if (running)
                socket.BeginAccept(AcceptCallback, null);
        }
    }
