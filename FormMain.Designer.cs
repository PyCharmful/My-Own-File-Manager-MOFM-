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
            SuspendLayout();
            // 
            // listViewDirectory
            // 
            listViewDirectory.Alignment = ListViewAlignment.Left;
            listViewDirectory.Location = new Point(12, 12);
            listViewDirectory.Name = "listViewDirectory";
            listViewDirectory.Size = new Size(477, 337);
            listViewDirectory.TabIndex = 0;
            listViewDirectory.UseCompatibleStateImageBehavior = false;
            listViewDirectory.View = View.List;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 364);
            Controls.Add(listViewDirectory);
            Name = "FormMain";
            Text = "GUI-MOFM testmode";
            Load += FormMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewDirectory;
    }
}
