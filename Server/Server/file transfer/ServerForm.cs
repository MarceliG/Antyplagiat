using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Server;

public partial class Main : Form
{
    //This will hold our listener. We will only need to create one instance of this.
    private readonly Listener listener;
    //This will hold our transfer client.
    private TransferClient transferClient;
    //This will hold our output folder.
    private string outputFolder;
    //This will hold our overall progress timer.
    private readonly Timer tmrOverallProg;
    //This is our variable to determine of the server is running or not to accept another connection if our client
    //Disconnects
    private bool serverRunning;

    public Main()
    {
        InitializeComponent();
        //Create the listener and register the event.
        listener = new Listener();
        listener.Accepted += Listener_Accepted;

        //Create the timer and register the event.
        tmrOverallProg = new Timer
        {
            Interval = 1000
        };
        tmrOverallProg.Tick += TmrOverallProg_Tick;

        //Set our default output folder.
        outputFolder = "Transfers";

        //If it does not exist, create it.
        if (!Directory.Exists(outputFolder))
        {
            Directory.CreateDirectory(outputFolder);
        }

        BtnStart.Click += new EventHandler(BtnStartServer_Click);
        BtnStop.Click += new EventHandler(BtnStopServer_Click);
        btnSendFile.Click += new EventHandler(BtnSendFile_Click);
        btnPauseTransfer.Click += new EventHandler(BtnPauseTransfer_Click);
        btnStopTransfer.Click += new EventHandler(BtnStopTransfer_Click);
        btnOpenDir.Click += new EventHandler(BtnOpenDir_Click);
        btnClearComplete.Click += new EventHandler(BtnClearComplete_Click);

        BtnStop.Enabled = false;
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        //Deregister all the events from the client if it is connected.
        DeregisterEvents();
        base.OnFormClosing(e);
    }

    void TmrOverallProg_Tick(object sender, EventArgs e)
    {
        if (transferClient == null)
            return;
        //Get and display the overall progress.
        progressOverall.Value = transferClient.GetOverallProgress();
    }

    void Listener_Accepted(object sender, SocketAcceptedEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new SocketAcceptedHandler(Listener_Accepted), sender, e);
            return;
        }

        //Stop the listener
        listener.Stop();

        //Create the transfer client based on our newly connected socket.
        transferClient = new TransferClient(e.Accepted)
        {
            //Set our output folder.
            OutputFolder = outputFolder
        };
        //Register the events.
        RegisterEvents();
        //Run the client
        transferClient.Run();
        //Start the progress timer
        tmrOverallProg.Start();
        //And set the new connection state.
        SetConnectionStatus(transferClient.EndPoint.Address.ToString());
    }

    private void BtnConnect_Click(object sender, EventArgs e)
    {
        if (transferClient == null)
        {
            //Create our new transfer client.
            //And attempt to connect
            transferClient = new TransferClient();
            transferClient.Connect(txtCntHost.Text.Trim(), int.Parse(txtPort.Text.Trim()), ConnectCallback);
            Enabled = false;
        }
        else
        {
            //This means we're trying to disconnect.
            transferClient.Close();
            transferClient = null;
        }
    }

    private void ConnectCallback(object sender, string error)
    {
        if (InvokeRequired)
        {
            Invoke(new ConnectCallback(ConnectCallback), sender, error);
            return;
        }
        //Set the form to enabled.
        Enabled = true;
        //If the error is not equal to null, something went wrong.
        if (error != null)
        {
            transferClient.Close();
            transferClient = null;
            MessageBox.Show(error, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        //Register the events
        RegisterEvents();
        //Set the output folder
        transferClient.OutputFolder = outputFolder;
        //Run the client
        transferClient.Run();
        //Set the connection status
        SetConnectionStatus(transferClient.EndPoint.Address.ToString());
        //Start the progress timer.
        tmrOverallProg.Start();
    }

    private void RegisterEvents()
    {
        transferClient.Complete += TransferClient_Complete;
        //transferClient.Disconnected += transferClient_Disconnected;
        transferClient.ProgressChanged += TransferClient_ProgressChanged;
        transferClient.Queued += TransferClient_Queued;
        transferClient.Stopped += TransferClient_Stopped;
    }

    void TransferClient_Stopped(object sender, TransferQueue queue)
    {
        if (InvokeRequired)
        {
            Invoke(new TransferEventHandler(TransferClient_Stopped), sender, queue);
            return;
        }
        //Remove the stopped transfer from view.
        lstTransfers.Items[queue.ID.ToString()].Remove();
    }

    void TransferClient_Queued(object sender, TransferQueue queue)
    {
        if (InvokeRequired)
        {
            Invoke(new TransferEventHandler(TransferClient_Queued), sender, queue);
            return;
        }

        //Create the LVI for the new transfer.
        ListViewItem i = new ListViewItem
        {
            Text = queue.ID.ToString()
        };
        i.SubItems.Add(queue.Filename);
        //If the type equals download, it will use the string of "Download", if not, it'll use "Upload"
        i.SubItems.Add(queue.Type == QueueType.Download ? "Download" : "Upload");
        i.SubItems.Add("0%");
        i.Tag = queue; //Set the tag to queue so we can grab is easily.
        i.Name = queue.ID.ToString(); //Set the name of the item to the ID of our transfer for easy access.
        lstTransfers.Items.Add(i); //Add the item
        i.EnsureVisible();
        
        //If the type is download, let the uploader know we're ready.
        if (queue.Type == QueueType.Download)
        {
            transferClient.StartTransfer(queue);
        }
    }

    void TransferClient_ProgressChanged(object sender, TransferQueue queue)
    {
        if (InvokeRequired)
        {
            Invoke(new TransferEventHandler(TransferClient_ProgressChanged), sender, queue);
            return;
        }

        //Set the progress cell to our current progress.
        lstTransfers.Items[queue.ID.ToString()].SubItems[3].Text = queue.Progress + "%";
    }
    /*
    void transferClient_Disconnected(object sender, EventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new EventHandler(transferClient_Disconnected), sender, e);
            return;
        }

        //Deregister the transfer client events
        deregisterEvents();

        //Close every transfer
        foreach (ListViewItem item in lstTransfers.Items)
        {
            TransferQueue queue = (TransferQueue)item.Tag;
            queue.Close();
        }
        //Clear the listview
        lstTransfers.Items.Clear();
        progressOverall.Value = 0;

        //Set the client to null
        transferClient = null;

        //Set the connection status to nothing
        setConnectionStatus("-");

        //If the server is still running, wait for another connection
        if (serverRunning)
        {
            listener.Start(int.Parse(txtServerPort.Text.Trim()));
            setConnectionStatus("Waiting...");
        }
        else //If we connected then disconnected, set the text back to connect.
        {
            btnConnect.Text = "Connect";
        }
    }
    */

    void TransferClient_Complete(object sender, TransferQueue queue)
    {
        //This just plays a little sound to let us know a transfer completed.
        System.Media.SystemSounds.Asterisk.Play();
    }

    private void DeregisterEvents()
    {
        if (transferClient == null)
            return;
        transferClient.Complete -= TransferClient_Complete;
        //transferClient.Disconnected -= transferClient_Disconnected;
        transferClient.ProgressChanged -= TransferClient_ProgressChanged;
        transferClient.Queued -= TransferClient_Queued;
        transferClient.Stopped -= TransferClient_Stopped;
    }

    private void SetConnectionStatus(string connectedTo)
    {
        lblConnected.Text = "Connection: " + connectedTo;
    }

    private void BtnStartServer_Click(object sender, EventArgs e)
    {
        //We disabled the button, but lets just do a quick check
        if (serverRunning)
            return;
        serverRunning = true;
        try
        {
            //Try to listen on the desired port
            listener.Start(int.Parse(txtPort.Text.Trim()));
            //Set the connection status to waiting
            SetConnectionStatus("Waiting...");
            //Enable/Disable the server buttons.
            BtnStart.Enabled = false;
            BtnStop.Enabled = true;
        }
        catch
        {
            MessageBox.Show("Unable to listen on port " + txtPort.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

    private void BtnStopServer_Click(object sender, EventArgs e)
    {
        if (!serverRunning)
            return;
        //Close the client if its active.
        if (transferClient != null)
        {
            transferClient.Close();
            //INSERT
            transferClient = null;
            //
        }
        //Stop the listener
        listener.Stop();
        //Stop the timer
        tmrOverallProg.Stop();
        //Reset the connection statis
        SetConnectionStatus("-");
        //Set our variables and enable/disable the buttons.
        serverRunning = false;
        BtnStart.Enabled = true;
        BtnStop.Enabled = false;
    }

    private void BtnClearComplete_Click(object sender, EventArgs e)
    {
        //Loop and clear all complete or inactive transfers
        foreach (ListViewItem i in lstTransfers.Items)
        {
            TransferQueue queue = (TransferQueue)i.Tag;

            if (queue.Progress == 100 || !queue.Running)
            {
                i.Remove();
            }
        }
    }

    private void BtnOpenDir_Click(object sender, EventArgs e)
    {
        //Get a user defined save directory
        using (FolderBrowserDialog fb = new FolderBrowserDialog())
        {
            if (fb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                outputFolder = fb.SelectedPath;

                if (transferClient != null)
                {
                    transferClient.OutputFolder = outputFolder;
                }

                txtSaveDir.Text = outputFolder;
            }
        }
    }

    private void BtnSendFile_Click(object sender, EventArgs e)
    {
        if (transferClient == null)
            return;
        //Get the user desired files to send
        using (OpenFileDialog o = new OpenFileDialog())
        {
            o.Filter = "All Files (*.*)|*.*";
            o.Multiselect = true;

            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in o.FileNames)
                {
                    transferClient.QueueTransfer(file);
                }
            }
        }
    }

    private void BtnPauseTransfer_Click(object sender, EventArgs e)
    {
        if (transferClient == null)
            return;
        //Loop and pause/resume all selected downloads.
        foreach (ListViewItem i in lstTransfers.SelectedItems)
        {
            TransferQueue queue = (TransferQueue)i.Tag;
            queue.Client.PauseTransfer(queue);
        }
    }

    private void BtnStopTransfer_Click(object sender, EventArgs e)
    {
        if (transferClient == null)
            return;

        //Loop and stop all selected downloads.
        foreach (ListViewItem i in lstTransfers.SelectedItems)
        {
            TransferQueue queue = (TransferQueue)i.Tag;
            queue.Client.StopTransfer(queue);
            i.Remove();
        }

        progressOverall.Value = 0;
    }

    private void BtnStart_Click(object sender, EventArgs e)
    {

    }

    private void BtnStop_Click(object sender, EventArgs e)
    {

    }
}