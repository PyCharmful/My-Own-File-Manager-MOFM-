using FileManager.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace GraphicOFM
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            defDirect fileShow = new defDirect();
            string[] listik = fileShow.DirectoryToStringFormat();
            foreach (var i in listik)
            {
                listViewDirectory.Items.Add(i);
            }
        }
    }
    class defDirect : DirectCreate
    {
        public string[] DirectoryToStringFormat()
        {
            string[] listDirect = new string[dirsDir.Length];
            for (int i = 0; i < dirsDir.Length; i++)
            {
                listDirect[i] = Convert.ToString(dirsDir[i]);
            }
            return listDirect;
        }
    }
}
