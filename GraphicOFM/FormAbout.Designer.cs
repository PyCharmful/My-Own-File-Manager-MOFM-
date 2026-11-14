namespace GraphicOFM
{
    partial class FormAbout
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
            labelAbout = new Label();
            SuspendLayout();
            // 
            // labelAbout
            // 
            labelAbout.AutoSize = true;
            labelAbout.Font = new Font("Comic Sans MS", 17F);
            labelAbout.Location = new Point(12, 9);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new Size(640, 155);
            labelAbout.TabIndex = 0;
            labelAbout.Text = "GUI-OFM (My Own FIle Manager GUI) v.0.1dev\r\n\r\nA GUI version of console (main) version of my pet-project.\r\nIt can only shows files and folders of entered directory.\r\nUpdates will coming soon.\r\n";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 184);
            Controls.Add(labelAbout);
            MaximumSize = new Size(680, 223);
            MinimumSize = new Size(680, 223);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About program";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAbout;
    }
}