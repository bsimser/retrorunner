namespace RetroRunner
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllGamePlayInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dOSBoxDefaultConfigFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dOSBoxDefaultkeyboardMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutRetroRunnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CreateConfigForSelection = new System.Windows.Forms.ToolStripButton();
            this.EditConfigForSelection = new System.Windows.Forms.ToolStripButton();
            this.DeleteConfigForSelection = new System.Windows.Forms.ToolStripButton();
            this.ViewSelector = new System.Windows.Forms.ToolStripComboBox();
            this.ViewLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DosBoxConsoleButton = new System.Windows.Forms.ToolStripButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddButton,
            this.EditButton,
            this.DeleteButton,
            this.toolStripSeparator1,
            this.CreateConfigForSelection,
            this.EditConfigForSelection,
            this.DeleteConfigForSelection,
            this.ViewSelector,
            this.ViewLabel,
            this.toolStripSeparator2,
            this.DosBoxConsoleButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(679, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.resetAllGamePlayInfoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.settingsToolStripMenuItem.Text = "&Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // resetAllGamePlayInfoToolStripMenuItem
            // 
            this.resetAllGamePlayInfoToolStripMenuItem.Name = "resetAllGamePlayInfoToolStripMenuItem";
            this.resetAllGamePlayInfoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.resetAllGamePlayInfoToolStripMenuItem.Text = "&Reset all game play info...";
            this.resetAllGamePlayInfoToolStripMenuItem.Click += new System.EventHandler(this.resetAllGamePlayInfoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOSBoxDefaultConfigFileToolStripMenuItem,
            this.dOSBoxDefaultkeyboardMappingToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // dOSBoxDefaultConfigFileToolStripMenuItem
            // 
            this.dOSBoxDefaultConfigFileToolStripMenuItem.Name = "dOSBoxDefaultConfigFileToolStripMenuItem";
            this.dOSBoxDefaultConfigFileToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.dOSBoxDefaultConfigFileToolStripMenuItem.Text = "&DOSBox default config file...";
            this.dOSBoxDefaultConfigFileToolStripMenuItem.Click += new System.EventHandler(this.dOSBoxDefaultConfigFileToolStripMenuItem_Click);
            // 
            // dOSBoxDefaultkeyboardMappingToolStripMenuItem
            // 
            this.dOSBoxDefaultkeyboardMappingToolStripMenuItem.Name = "dOSBoxDefaultkeyboardMappingToolStripMenuItem";
            this.dOSBoxDefaultkeyboardMappingToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.dOSBoxDefaultkeyboardMappingToolStripMenuItem.Text = "DOSBox default &keyboard mapping...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutRetroRunnerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutRetroRunnerToolStripMenuItem
            // 
            this.aboutRetroRunnerToolStripMenuItem.Name = "aboutRetroRunnerToolStripMenuItem";
            this.aboutRetroRunnerToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.aboutRetroRunnerToolStripMenuItem.Text = "&About RetroRunner...";
            this.aboutRetroRunnerToolStripMenuItem.Click += new System.EventHandler(this.aboutRetroRunnerToolStripMenuItem_Click);
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(23, 22);
            this.AddButton.Text = "Add a new program";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(23, 22);
            this.EditButton.Text = "Edit the selected program";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteButton.Text = "Delete the selected program";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // CreateConfigForSelection
            // 
            this.CreateConfigForSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateConfigForSelection.Image = ((System.Drawing.Image)(resources.GetObject("CreateConfigForSelection.Image")));
            this.CreateConfigForSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateConfigForSelection.Name = "CreateConfigForSelection";
            this.CreateConfigForSelection.Size = new System.Drawing.Size(23, 22);
            this.CreateConfigForSelection.Text = "Create a custom config file \\r\\nfor the selected program";
            this.CreateConfigForSelection.Click += new System.EventHandler(this.CreateConfigForSelection_Click);
            // 
            // EditConfigForSelection
            // 
            this.EditConfigForSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditConfigForSelection.Image = ((System.Drawing.Image)(resources.GetObject("EditConfigForSelection.Image")));
            this.EditConfigForSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditConfigForSelection.Name = "EditConfigForSelection";
            this.EditConfigForSelection.Size = new System.Drawing.Size(23, 22);
            this.EditConfigForSelection.Text = "Edit the selected program\'s\\r\\ncustom config file";
            this.EditConfigForSelection.Click += new System.EventHandler(this.EditConfigForSelection_Click);
            // 
            // DeleteConfigForSelection
            // 
            this.DeleteConfigForSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteConfigForSelection.Image = ((System.Drawing.Image)(resources.GetObject("DeleteConfigForSelection.Image")));
            this.DeleteConfigForSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteConfigForSelection.Name = "DeleteConfigForSelection";
            this.DeleteConfigForSelection.Size = new System.Drawing.Size(23, 22);
            this.DeleteConfigForSelection.Text = "Delete the selected program\'s \\r\\ncustom config file";
            this.DeleteConfigForSelection.Click += new System.EventHandler(this.DeleteConfigForSelection_Click);
            // 
            // ViewSelector
            // 
            this.ViewSelector.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ViewSelector.Items.AddRange(new object[] {
            "Details",
            "Screenshots",
            "Box Art"});
            this.ViewSelector.Name = "ViewSelector";
            this.ViewSelector.Size = new System.Drawing.Size(121, 25);
            this.ViewSelector.SelectedIndexChanged += new System.EventHandler(this.ViewSelector_SelectedIndexChanged);
            // 
            // ViewLabel
            // 
            this.ViewLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ViewLabel.Name = "ViewLabel";
            this.ViewLabel.Size = new System.Drawing.Size(32, 22);
            this.ViewLabel.Text = "View";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // DosBoxConsoleButton
            // 
            this.DosBoxConsoleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DosBoxConsoleButton.Image = ((System.Drawing.Image)(resources.GetObject("DosBoxConsoleButton.Image")));
            this.DosBoxConsoleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DosBoxConsoleButton.Name = "DosBoxConsoleButton";
            this.DosBoxConsoleButton.Size = new System.Drawing.Size(23, 22);
            this.DosBoxConsoleButton.Text = "Launch the DOSBox console";
            this.DosBoxConsoleButton.Click += new System.EventHandler(this.DosBoxConsoleButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 49);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(679, 353);
            this.MainPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 402);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllGamePlayInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dOSBoxDefaultConfigFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dOSBoxDefaultkeyboardMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutRetroRunnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton AddButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton CreateConfigForSelection;
        private System.Windows.Forms.ToolStripButton EditConfigForSelection;
        private System.Windows.Forms.ToolStripButton DeleteConfigForSelection;
        private System.Windows.Forms.ToolStripComboBox ViewSelector;
        private System.Windows.Forms.ToolStripLabel ViewLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DosBoxConsoleButton;
        private System.Windows.Forms.Panel MainPanel;
    }
}

