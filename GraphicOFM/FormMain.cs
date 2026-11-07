using FileManager.Classes;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text;
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
            // Если последний символ пути не равен /, то дописываем его
            if (dir[^1] != Path.DirectorySeparatorChar)
            {
                dir = string.Concat(dir, Path.DirectorySeparatorChar);
            }
            // Меняется текст на текущую директорию
            textBoxInsertDirectory.Text = dir;
            // Очистка окон
            listViewDirectory.Items.Clear();
            listViewFile.Items.Clear();
            // Создание объекта класса DirectCreate для вызова его свойств (Список папок, файлов и т. д)
            DirectCreate fileShow = new DirectCreate(dir);
            string[] listDirect = fileShow.DirectoryToStringFormat();
            string[] listFile = fileShow.FileToStringFormat();
            // Заполнение окон
            foreach (var i in listDirect)
            {
                listViewDirectory.Items.Add(i);
            }
            foreach (var i in listFile)
            {
                listViewFile.Items.Add(i);
            }
        }
        // По умолчанию при запуске
        private void FormMain_Load(object sender, EventArgs e)
        {
            ShowContent();
        }
        // Смена директории
        private void textBoxInsertDirectory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Если отсутствует, то сообщение с ошибкой
                if (!Path.Exists(Convert.ToString(textBoxInsertDirectory.Text)))
                {
                    MessageBox.Show("Директория отсутствует");
                }
                else
                {
                    // Передаем в метод показа содержимое введенного TextBox
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
        // Вернуться в предыдущую папку
        private void buttonMovePrev_Click(object sender, EventArgs e)
        {

            try
            {
                // Берем введенную строку
                string moveDirect = Convert.ToString(textBoxInsertDirectory.Text);
                // Создаем переменную, которая является обрезанной частью moveDirect
                // Убирает дополнительно /
                string dirBack = moveDirect.Remove(moveDirect.LastIndexOf(Path.DirectorySeparatorChar));
                // Убирает от исходной все, что идет после последнего /
                dirBack = dirBack.Remove(dirBack.LastIndexOf(Path.DirectorySeparatorChar) + 1);
                ShowContent(Convert.ToString(dirBack));
                // Меняется текст на текущую директорию
                textBoxInsertDirectory.Text = dirBack;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы достигли начала",
                    $"Error: {ex.GetType().Name}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        // Перейти в выбранную директорию
        private void listViewDirectory_DoubleClick(object sender, EventArgs e)
        {
            // Извлекается текст из выбранного элемента
            string moveDirect = Convert.ToString(textBoxInsertDirectory.Text);
            // Выбираем выбранный элемент
            var DirSelect = listViewDirectory.SelectedItems[0];
            // Создаем путь к выбранной директории из текущей + выбранный элемент + \
            moveDirect = string.Concat(moveDirect, DirSelect.Text + Path.DirectorySeparatorChar);
            // Передаем в метод для показа
            ShowContent(Convert.ToString(moveDirect));
            // Меняется текст на текущую директорию
            textBoxInsertDirectory.Text = moveDirect;
        }
    }
}
