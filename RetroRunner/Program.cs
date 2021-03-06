﻿using System;
using System.Threading.Tasks;
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
            Task.Run(async () =>
            {
                using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/bsimser/retrorunner"))
                {
                    await mgr.Result.UpdateApp();
                }
            });
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}