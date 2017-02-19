using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroRunner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // set current directory to where app is
            // check to see if SettingsPath exists
            // if it does call ApplicationSettings.Load
            // set text of form to assembly name + version
            // if we saved screensize then restore it
            // if dosboxpath is null or empty
            // open optionsdialog
            // let user set values
            // if user cancels then show message box that we need these and close
            // load paths
            // otherwise if the paths in the settings don't exist
            // open dialog, etc and quit app if user cancels
            // set global variable Programs from ProgramList.Load().Progress call
            // if there are no programs then disable appropriate toolstrip/menu controls
            // otherwise enable view selector control and set initial view mdoe
            // get command line args
            // show dialog and quit if invalid command line args
            // if command line args == 2 then validate and launch game
            // create screenshot directory if it doesn't exist
            // create temp directory if it doesn't exist
            // create customconfig directory if it doesn't exist
            // if wikisite is empty load in the background
            // otherwise load xml file

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // if program count != 0 return
            using (var welcomeDialog = new WelcomeDialog())
            {
                welcomeDialog.ShowDialog();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // save settings, size, etc.
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateConfigForSelection_Click(object sender, EventArgs e)
        {

        }

        private void EditConfigForSelection_Click(object sender, EventArgs e)
        {

        }

        private void DeleteConfigForSelection_Click(object sender, EventArgs e)
        {

        }

        private void DosBoxConsoleButton_Click(object sender, EventArgs e)
        {

        }

        private void ViewSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
