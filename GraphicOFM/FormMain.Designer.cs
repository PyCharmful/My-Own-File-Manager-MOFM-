namespace GraphicOFM
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewDirectory = new ListView();
            listViewFile = new ListView();
            textBoxInsertDirectory = new TextBox();
            labelCurrentDirectory = new Label();
            menuStripMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            labelFiles = new Label();
            labelFolders = new Label();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // listViewDirectory
            // 
            listViewDirectory.Alignment = ListViewAlignment.Left;
            listViewDirectory.Location = new Point(12, 129);
            listViewDirectory.Name = "listViewDirectory";
            listViewDirectory.Size = new Size(357, 521);
            listViewDirectory.TabIndex = 0;
            listViewDirectory.UseCompatibleStateImageBehavior = false;
            listViewDirectory.View = View.List;
            listViewDirectory.SelectedIndexChanged += listViewDirectory_SelectedIndexChanged;
            // 
            // listViewFile
            // 
            listViewFile.Alignment = ListViewAlignment.Left;
            listViewFile.Location = new Point(375, 129);
            listViewFile.Name = "listViewFile";
            listViewFile.Size = new Size(357, 521);
            listViewFile.TabIndex = 1;
            listViewFile.UseCompatibleStateImageBehavior = false;
            listViewFile.View = View.List;
            // 
            // textBoxInsertDirectory
            // 
            textBoxInsertDirectory.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInsertDirectory.Location = new Point(12, 57);
            textBoxInsertDirectory.Name = "textBoxInsertDirectory";
            textBoxInsertDirectory.Size = new Size(249, 33);
            textBoxInsertDirectory.TabIndex = 2;
            textBoxInsertDirectory.Text = "C:\\";
            textBoxInsertDirectory.EnabledChanged += textBoxInsertDirectory_EnabledChanged;
            textBoxInsertDirectory.TextChanged += textBoxInsertDirectory_TextChanged;
            textBoxInsertDirectory.KeyDown += textBoxInsertDirectory_KeyDown;
            // 
            // labelCurrentDirectory
            // 
            labelCurrentDirectory.AutoSize = true;
            labelCurrentDirectory.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCurrentDirectory.Location = new Point(12, 27);
            labelCurrentDirectory.Name = "labelCurrentDirectory";
            labelCurrentDirectory.Size = new Size(193, 30);
            labelCurrentDirectory.TabIndex = 3;
            labelCurrentDirectory.Text = "Current directory";
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem, aboutToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(745, 24);
            menuStripMain.TabIndex = 4;
            menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Enabled = false;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Enabled = false;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // labelFiles
            // 
            labelFiles.AutoSize = true;
            labelFiles.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFiles.Location = new Point(375, 93);
            labelFiles.Name = "labelFiles";
            labelFiles.Size = new Size(69, 33);
            labelFiles.TabIndex = 5;
            labelFiles.Text = "Files";
            // 
            // labelFolders
            // 
            labelFolders.AutoSize = true;
            labelFolders.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFolders.Location = new Point(12, 93);
            labelFolders.Name = "labelFolders";
            labelFolders.Size = new Size(100, 33);
            labelFolders.TabIndex = 6;
            labelFolders.Text = "Folders";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 664);
            Controls.Add(labelFolders);
            Controls.Add(labelFiles);
            Controls.Add(labelCurrentDirectory);
            Controls.Add(textBoxInsertDirectory);
            Controls.Add(listViewFile);
            Controls.Add(listViewDirectory);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            MinimumSize = new Size(761, 703);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUI-OFM testmode";
            Load += FormMain_Load;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewDirectory;
        private ListView listViewFile;
        private TextBox textBoxInsertDirectory;
        private Label labelCurrentDirectory;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label labelFiles;
        private Label labelFolders;
    }
}
