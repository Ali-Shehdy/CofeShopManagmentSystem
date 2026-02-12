using System;
using System.IO;
using System.Windows.Forms;

namespace CofeShopManagmentSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Point |DataDirectory| to the folder where the EXE runs (bin\Debug\...)
            AppDomain.CurrentDomain.SetData("DataDirectory", Application.StartupPath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // or your startup form
        }
    }
}
