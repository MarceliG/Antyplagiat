using System;
using System.Windows.Forms;

namespace Server
{
    static class Program
    {
        //What we are using for ID generation
        public static Random Rand;
        [STAThread]
        static void Main()
        {
            Rand = new Random();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MachineLearning.Learn(); // Learning
            Application.Run(new Main());
        }
    }
}
