using FileManager.Classes;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
        static string currentDir = "";
        public void ShowContent(string dir = @"C:\")
        {
            // Если последний символ пути не равен /, то дописываем его
            if (dir[^1] != Path.DirectorySeparatorChar)
            {
                dir = string.Concat(dir, Path.DirectorySeparatorChar);
            }
            // Меняется текст на текущую директорию
            textBoxInsertDirectory.Text = dir;
            currentDir = dir;
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
                    textBoxInsertDirectory.Text = currentDir;
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
            buttonMoveNext.Enabled = true;
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
                currentDir = dirBack;
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
            //// Извлекается текст из выбранного элемента
            //string moveDirect = Convert.ToString(textBoxInsertDirectory.Text);
            //// Выбираем выбранный элемент
            //var DirSelect = listViewDirectory.SelectedItems[0];
            //// Создаем путь к выбранной директории из текущей + выбранный элемент + \
            //moveDirect = string.Concat(moveDirect, DirSelect.Text + Path.DirectorySeparatorChar);
            //// Передаем в метод для показа
            //ShowContent(Convert.ToString(moveDirect));
            //// Меняется текст на текущую директорию
            //textBoxInsertDirectory.Text = moveDirect;
            //buttonMoveNext.Enabled = false;
        }

        private void buttonMoveNext_Click(object sender, EventArgs e)
        {
            string moveDirect = Convert.ToString(textBoxInsertDirectory.Text);
            var DirSelect = listViewDirectory.SelectedItems[0];
            moveDirect = string.Concat(moveDirect, DirSelect.Text + Path.DirectorySeparatorChar);
            ShowContent(Convert.ToString(moveDirect));
            textBoxInsertDirectory.Text = moveDirect;
            currentDir = moveDirect;
            buttonMoveNext.Enabled = false;
        }

        private void listViewFile_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listViewDirectory_ItemActivate(object sender, EventArgs e)
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
            buttonMoveNext.Enabled = false;
        }
        // Открытие файла
        private void listViewFile_ItemActivate(object sender, EventArgs e)
        {
            var selectedItem = listViewFile.SelectedItems[0];
            string openDirect = Path.Combine(Convert.ToString(textBoxInsertDirectory.Text), selectedItem.Text);
            if (File.Exists(openDirect))
            {
                try
                {
                    // Открываем файл программой по умолчанию
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = openDirect,
                        UseShellExecute = true // ОЧЕНЬ ВАЖНО для открытия файлов программой по умолчанию
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось открыть файл");
                }
            }
        }
    }
}
