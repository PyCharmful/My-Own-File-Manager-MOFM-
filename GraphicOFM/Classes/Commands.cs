using System;
using System.Collections.Generic;
using System.Text;

namespace FileManager.Classes
{
    // Интерфейс все команд файлового менеджера
    interface Commands
    {
        void ChangeDirectory();
        void HelpMessage();
        void Clear();
        void ShowLast();
        void ShowFiles();
        void ShowFolders();
        void ShowAll();
    }
    class Commander : Commands
    {
        static string LastDirect = @"C:\";
        ShowWindow dirCh1 = new ShowWindow();
        // Для передачи параметров в Print()
        private void ShowParams(bool a, bool b, bool c)
        {
            dirCh1 = new ShowWindow(LastDirect);
            dirCh1.Print(a, b, c);
        }
        // Поменять директорию
        public void ChangeDirectory()
        {
            Console.Write("Смена директории: ");
            string changedDirectory = Console.ReadLine();
            if (!Path.Exists(changedDirectory)) // Проверка на существование директории
            {
                Console.WriteLine("Директория отсутствует");
            }
            else
            {
                LastDirect = changedDirectory;
                dirCh1 = new ShowWindow(changedDirectory);
                ShowParams(true, false, false);
            }
        }
        // Вывести сообщение с командами
        public void HelpMessage()
        {
            MessageBox.Show("help - окно с командами" + "\n" +
                        "cd - смена директории" + "\n" +
                        "clear - очистить экран" + "\n" +
                        "showlast - показать последний каталог" + "\n" +
                        "showfiles - показать только файлы" + "\n" +
                        "showfolders - показать только папки" + "\n" +
                        "showall - показать и файлы, и папки");
        }
        // Очистить весь экран
        public void Clear()
        {
            Console.Clear();
        }
        //  Вывести последнюю директорию
        public void ShowLast()
        {
            ShowParams(true, true, true);
        }
        // Показать ТОЛЬКО ФАЙЛЫ
        public void ShowFiles()
        {
            ShowParams(false, true, false);
        }
        // Показать ТОЛЬКО ПАПКИ
        public void ShowFolders()
        {
            ShowParams(false, false, true);
        }
        // Показать И ФАЙЛЫ, И ПАПКИ
        public void ShowAll()
        {
            Console.Clear();
            ShowParams(true, true, true);
        }
    }
}
