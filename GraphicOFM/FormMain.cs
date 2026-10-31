using FileManager.Classes;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace GraphicOFM
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        // Вывод на экран директории
        public void ShowContent(string dir = @"C:\")
        {
            listViewDirectory.Items.Clear();
            listViewFile.Items.Clear();
            DirectCreate fileShow = new DirectCreate(dir);
            string[] listDirect = fileShow.DirectoryToStringFormat();
            string[] listFile = fileShow.FileToStringFormat();
            foreach (var i in listDirect)
            {
                listViewDirectory.Items.Add(i);
            }
            foreach (var i in listFile)
            {
                listViewFile.Items.Add(i);
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            ShowContent();
        }
        // Смена директории
        private void textBoxInsertDirectory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!Path.Exists(Convert.ToString(textBoxInsertDirectory.Text)))
                {
                    MessageBox.Show("Директория отсутствует");
                }
                else
                {
                    ShowContent(Convert.ToString(textBoxInsertDirectory.Text));
                }
            }
        }

        private void listViewDirectory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInsertDirectory_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInsertDirectory_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Owner = this;
            formAbout.ShowDialog();
        }
    }
}
