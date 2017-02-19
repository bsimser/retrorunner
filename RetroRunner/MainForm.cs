using System;
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
            using (var dialog = new WelcomeDialog())
            {
                dialog.ShowDialog();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // save settings, size, etc.
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DosProgram.AddProgram();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DosProgram.EditProgram();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DosProgram.DeleteProgram();
        }

        private void CreateConfigForSelection_Click(object sender, EventArgs e)
        {
            DosProgram.CreateCustomConfigFile();
        }

        private void EditConfigForSelection_Click(object sender, EventArgs e)
        {
            DosProgram.EditCustomConfigFile();
        }

        private void DeleteConfigForSelection_Click(object sender, EventArgs e)
        {
            DosProgram.DeleteCustomConfigFile();
        }

        private void DosBoxConsoleButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new ConsoleOptionsDialog())
            {
                dialog.ShowDialog();
            }
        }

        private void ViewSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set the mainpanel controls based on details, screenshots, or box art selection
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new OptionsDialog())
            {
                dialog.ShowDialog();
            }
        }

        private void resetAllGamePlayInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                    "Are you sure that you want to reset the times played and last date played for all programs?",
                    "Reset all play info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
        }
    }
}
