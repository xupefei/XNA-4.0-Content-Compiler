namespace XNAContentCompiler
{
    partial class ContentCompilerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentCompilerForm));
			this.propertyGrid = new System.Windows.Forms.PropertyGrid();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.statusTextLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.mainInterfacePanel = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.logWindow = new System.Windows.Forms.TextBox();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuNewProject = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOpenProject = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.menuSaveProject = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSaveProjectAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuContent = new System.Windows.Forms.ToolStripMenuItem();
			this.menuAddContentFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuAddContentFolder = new System.Windows.Forms.ToolStripMenuItem();
			this.menuRemoveContentFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuCompileProject = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.menuProjectSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.mainToolStrip = new System.Windows.Forms.ToolStrip();
			this.toolAddContentFile = new System.Windows.Forms.ToolStripButton();
			this.toolAddContentFolder = new System.Windows.Forms.ToolStripButton();
			this.toolRemoveContentFile = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolBuildContentProject = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolProjectSettings = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.statusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainInterfacePanel)).BeginInit();
			this.mainInterfacePanel.Panel1.SuspendLayout();
			this.mainInterfacePanel.Panel2.SuspendLayout();
			this.mainInterfacePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.mainMenuStrip.SuspendLayout();
			this.mainToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// propertyGrid
			// 
			this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid.Location = new System.Drawing.Point(0, 0);
			this.propertyGrid.Name = "propertyGrid";
			this.propertyGrid.Size = new System.Drawing.Size(171, 548);
			this.propertyGrid.TabIndex = 17;
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "Image Files(*.bmp;*.jpg;*.png;*.tga;*.dds)|*.bmp;*.jpg;*.png;*.tga;*.dds|Audio Fi" +
    "les(*.wav;*.mp3;*.wma)|*.wav;*.mp3;*.wma|SpriteFont Files(*.spritefont)|*.sprite" +
    "font";
			this.openFileDialog.Multiselect = true;
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.AutoScroll = true;
			this.toolStripContainer1.ContentPanel.Controls.Add(this.mainInterfacePanel);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(941, 548);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(941, 643);
			this.toolStripContainer1.TabIndex = 19;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.mainMenuStrip);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.mainToolStrip);
			// 
			// statusStrip
			// 
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusTextLabel,
            this.statusProgressBar});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(941, 30);
			this.statusStrip.TabIndex = 1;
			// 
			// statusTextLabel
			// 
			this.statusTextLabel.Name = "statusTextLabel";
			this.statusTextLabel.Size = new System.Drawing.Size(926, 25);
			this.statusTextLabel.Spring = true;
			this.statusTextLabel.Text = "XNA Content Compiler";
			this.statusTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// statusProgressBar
			// 
			this.statusProgressBar.Name = "statusProgressBar";
			this.statusProgressBar.Size = new System.Drawing.Size(100, 24);
			this.statusProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.statusProgressBar.Visible = false;
			// 
			// mainInterfacePanel
			// 
			this.mainInterfacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainInterfacePanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.mainInterfacePanel.Location = new System.Drawing.Point(0, 0);
			this.mainInterfacePanel.Name = "mainInterfacePanel";
			// 
			// mainInterfacePanel.Panel1
			// 
			this.mainInterfacePanel.Panel1.Controls.Add(this.splitContainer2);
			// 
			// mainInterfacePanel.Panel2
			// 
			this.mainInterfacePanel.Panel2.Controls.Add(this.propertyGrid);
			this.mainInterfacePanel.Size = new System.Drawing.Size(941, 548);
			this.mainInterfacePanel.SplitterDistance = 766;
			this.mainInterfacePanel.TabIndex = 19;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.dataGridView);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.logWindow);
			this.splitContainer2.Size = new System.Drawing.Size(766, 548);
			this.splitContainer2.SplitterDistance = 378;
			this.splitContainer2.TabIndex = 21;
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToOrderColumns = true;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(0, 0);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.Height = 28;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(766, 378);
			this.dataGridView.TabIndex = 17;
			this.dataGridView.SelectionChanged += new System.EventHandler(this.GridSelectionChanged);
			// 
			// logWindow
			// 
			this.logWindow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logWindow.Location = new System.Drawing.Point(0, 0);
			this.logWindow.Multiline = true;
			this.logWindow.Name = "logWindow";
			this.logWindow.Size = new System.Drawing.Size(766, 166);
			this.logWindow.TabIndex = 19;
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuContent,
            this.menuHelp});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(941, 33);
			this.mainMenuStrip.TabIndex = 0;
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewProject,
            this.menuOpenProject,
            this.toolStripSeparator,
            this.menuSaveProject,
            this.menuSaveProjectAs,
            this.toolStripSeparator2,
            this.menuExit});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(50, 29);
			this.menuFile.Text = "&File";
			// 
			// menuNewProject
			// 
			this.menuNewProject.Image = ((System.Drawing.Image)(resources.GetObject("menuNewProject.Image")));
			this.menuNewProject.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuNewProject.Name = "menuNewProject";
			this.menuNewProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.menuNewProject.Size = new System.Drawing.Size(264, 30);
			this.menuNewProject.Text = "&New Project";
			this.menuNewProject.Visible = false;
			// 
			// menuOpenProject
			// 
			this.menuOpenProject.Image = ((System.Drawing.Image)(resources.GetObject("menuOpenProject.Image")));
			this.menuOpenProject.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuOpenProject.Name = "menuOpenProject";
			this.menuOpenProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.menuOpenProject.Size = new System.Drawing.Size(264, 30);
			this.menuOpenProject.Text = "&Open Project...";
			this.menuOpenProject.Visible = false;
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(261, 6);
			this.toolStripSeparator.Visible = false;
			// 
			// menuSaveProject
			// 
			this.menuSaveProject.Image = ((System.Drawing.Image)(resources.GetObject("menuSaveProject.Image")));
			this.menuSaveProject.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuSaveProject.Name = "menuSaveProject";
			this.menuSaveProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.menuSaveProject.Size = new System.Drawing.Size(264, 30);
			this.menuSaveProject.Text = "&Save Project";
			this.menuSaveProject.Visible = false;
			// 
			// menuSaveProjectAs
			// 
			this.menuSaveProjectAs.Name = "menuSaveProjectAs";
			this.menuSaveProjectAs.Size = new System.Drawing.Size(264, 30);
			this.menuSaveProjectAs.Text = "Save Project &As...";
			this.menuSaveProjectAs.Visible = false;
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(261, 6);
			this.toolStripSeparator2.Visible = false;
			// 
			// menuExit
			// 
			this.menuExit.Name = "menuExit";
			this.menuExit.Size = new System.Drawing.Size(264, 30);
			this.menuExit.Text = "E&xit";
			this.menuExit.Click += new System.EventHandler(this.Exit);
			// 
			// menuContent
			// 
			this.menuContent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddContentFile,
            this.menuAddContentFolder,
            this.menuRemoveContentFile,
            this.toolStripSeparator1,
            this.menuCompileProject,
            this.toolStripSeparator4,
            this.menuProjectSettings});
			this.menuContent.Name = "menuContent";
			this.menuContent.Size = new System.Drawing.Size(87, 29);
			this.menuContent.Text = "&Content";
			// 
			// menuAddContentFile
			// 
			this.menuAddContentFile.Name = "menuAddContentFile";
			this.menuAddContentFile.Size = new System.Drawing.Size(253, 30);
			this.menuAddContentFile.Text = "&Add Content...";
			this.menuAddContentFile.Click += new System.EventHandler(this.AddContentItem);
			// 
			// menuAddContentFolder
			// 
			this.menuAddContentFolder.Name = "menuAddContentFolder";
			this.menuAddContentFolder.Size = new System.Drawing.Size(253, 30);
			this.menuAddContentFolder.Text = "&Add Content Folder...";
			this.menuAddContentFolder.Click += new System.EventHandler(this.AddContentFolder);
			// 
			// menuRemoveContentFile
			// 
			this.menuRemoveContentFile.Name = "menuRemoveContentFile";
			this.menuRemoveContentFile.Size = new System.Drawing.Size(253, 30);
			this.menuRemoveContentFile.Text = "&Remove Content File";
			this.menuRemoveContentFile.Click += new System.EventHandler(this.RemoveContentItem);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(250, 6);
			// 
			// menuCompileProject
			// 
			this.menuCompileProject.Name = "menuCompileProject";
			this.menuCompileProject.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.menuCompileProject.Size = new System.Drawing.Size(253, 30);
			this.menuCompileProject.Text = "&Compile Project";
			this.menuCompileProject.Click += new System.EventHandler(this.CompileProject);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(250, 6);
			// 
			// menuProjectSettings
			// 
			this.menuProjectSettings.Name = "menuProjectSettings";
			this.menuProjectSettings.Size = new System.Drawing.Size(253, 30);
			this.menuProjectSettings.Text = "&Project Settings";
			this.menuProjectSettings.Click += new System.EventHandler(this.EditProjectSettings);
			// 
			// menuHelp
			// 
			this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
			this.menuHelp.Name = "menuHelp";
			this.menuHelp.Size = new System.Drawing.Size(61, 29);
			this.menuHelp.Text = "&Help";
			// 
			// menuHelpAbout
			// 
			this.menuHelpAbout.Name = "menuHelpAbout";
			this.menuHelpAbout.Size = new System.Drawing.Size(198, 30);
			this.menuHelpAbout.Text = "&About...";
			this.menuHelpAbout.Click += new System.EventHandler(this.HelpAbout);
			// 
			// mainToolStrip
			// 
			this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddContentFile,
            this.toolAddContentFolder,
            this.toolRemoveContentFile,
            this.toolStripSeparator3,
            this.toolBuildContentProject,
            this.toolStripSeparator6,
            this.toolProjectSettings});
			this.mainToolStrip.Location = new System.Drawing.Point(3, 33);
			this.mainToolStrip.Name = "mainToolStrip";
			this.mainToolStrip.Size = new System.Drawing.Size(569, 32);
			this.mainToolStrip.TabIndex = 1;
			// 
			// toolAddContentFile
			// 
			this.toolAddContentFile.Image = global::XNAContentCompiler.Properties.Resources.AddFile;
			this.toolAddContentFile.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolAddContentFile.Name = "toolAddContentFile";
			this.toolAddContentFile.Size = new System.Drawing.Size(146, 29);
			this.toolAddContentFile.Text = "&Add Content...";
			this.toolAddContentFile.Click += new System.EventHandler(this.AddContentItem);
			// 
			// toolAddContentFolder
			// 
			this.toolAddContentFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolAddContentFolder.Image = global::XNAContentCompiler.Properties.Resources.AddFolder;
			this.toolAddContentFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolAddContentFolder.Name = "toolAddContentFolder";
			this.toolAddContentFolder.Size = new System.Drawing.Size(23, 29);
			this.toolAddContentFolder.Text = "Add Content &Folder...";
			this.toolAddContentFolder.Click += new System.EventHandler(this.AddContentFolder);
			// 
			// toolRemoveContentFile
			// 
			this.toolRemoveContentFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolRemoveContentFile.Image = global::XNAContentCompiler.Properties.Resources.RemoveFile;
			this.toolRemoveContentFile.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolRemoveContentFile.Name = "toolRemoveContentFile";
			this.toolRemoveContentFile.Size = new System.Drawing.Size(23, 29);
			this.toolRemoveContentFile.Text = "&Remove Content File";
			this.toolRemoveContentFile.Click += new System.EventHandler(this.RemoveContentItem);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
			// 
			// toolBuildContentProject
			// 
			this.toolBuildContentProject.Image = global::XNAContentCompiler.Properties.Resources.BuildProject;
			this.toolBuildContentProject.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolBuildContentProject.Name = "toolBuildContentProject";
			this.toolBuildContentProject.Size = new System.Drawing.Size(198, 29);
			this.toolBuildContentProject.Text = "Build Content Project";
			this.toolBuildContentProject.Click += new System.EventHandler(this.CompileProject);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 32);
			// 
			// toolProjectSettings
			// 
			this.toolProjectSettings.Image = global::XNAContentCompiler.Properties.Resources.ProjectSettings;
			this.toolProjectSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolProjectSettings.Name = "toolProjectSettings";
			this.toolProjectSettings.Size = new System.Drawing.Size(155, 29);
			this.toolProjectSettings.Text = "Project Settings";
			this.toolProjectSettings.Click += new System.EventHandler(this.EditProjectSettings);
			// 
			// ContentCompilerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(941, 643);
			this.Controls.Add(this.toolStripContainer1);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.mainMenuStrip;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ContentCompilerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "XNA Content Compiler";
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.mainInterfacePanel.Panel1.ResumeLayout(false);
			this.mainInterfacePanel.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mainInterfacePanel)).EndInit();
			this.mainInterfacePanel.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.mainToolStrip.ResumeLayout(false);
			this.mainToolStrip.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.PropertyGrid propertyGrid;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.SplitContainer mainInterfacePanel;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.TextBox logWindow;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuNewProject;
		private System.Windows.Forms.ToolStripMenuItem menuOpenProject;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem menuSaveProject;
		private System.Windows.Forms.ToolStripMenuItem menuSaveProjectAs;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem menuExit;
		private System.Windows.Forms.ToolStripMenuItem menuContent;
		private System.Windows.Forms.ToolStripMenuItem menuAddContentFile;
		private System.Windows.Forms.ToolStripMenuItem menuRemoveContentFile;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem menuCompileProject;
		private System.Windows.Forms.ToolStripMenuItem menuHelp;
		private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
		private System.Windows.Forms.ToolStrip mainToolStrip;
		private System.Windows.Forms.ToolStripButton toolAddContentFile;
		private System.Windows.Forms.ToolStripButton toolRemoveContentFile;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton toolBuildContentProject;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem menuProjectSettings;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel statusTextLabel;
		private System.Windows.Forms.ToolStripProgressBar statusProgressBar;
		private System.Windows.Forms.ToolStripButton toolAddContentFolder;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton toolProjectSettings;
		private System.Windows.Forms.ToolStripMenuItem menuAddContentFolder;
    }
}

