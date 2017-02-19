using System;
using System.Windows.Forms;
using Squirrel;

namespace RetroRunner
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
//            using (var mgr = new UpdateManager())
//            {
//                await mgr.UpdateApp();
//            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}