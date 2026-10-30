using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FileManager.Classes
{
    // Вывод информации на экран
    class ShowWindow : DirectCreate
    {
        public ShowWindow(string s = @"C:\") : base(s) { } // Принимает путь директории от class Directory

        // Вывод директории на экран
        public void Print(bool showAllWindow = true, bool showFilesWindow = false, bool showFoldersWindow = false)
        {
            Console.Out.Flush();
            Console.Write("\x1b[3J"); // Решение проблемы остаточного старого вывода
            Console.Clear();
            Console.WriteLine("My Own File Manager");
            Console.WriteLine("VIEW MODE");
            Console.WriteLine("------------------------------------------------------------");
            if (showAllWindow || showFoldersWindow)
            {
                Console.WriteLine("-------------------------FOLDERS----------------------------");
                for (int i = 0; i < dirsDir.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". " + dirsDir[i].FullName);
                }
                Console.WriteLine("------------------------------------------------------------");
            }
            if (showAllWindow || showFilesWindow)
            {
                Console.WriteLine("--------------------------FILES-----------------------------");
                for (int i = 0; i < filesDir.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". " + filesDir[i].FullName);
                }
                Console.WriteLine("------------------------------------------------------------");
                
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.Out.Flush();
        }
    }
    class CommandInput
    {
        private string userInp;
        public CommandInput(string s)
        {
            userInp = s;
        }
        // Выполнить команду пользователя
        public void DoCommand()
        {
            Commander com = new Commander(); // Объект класса для взаимодействия с командами
            switch (userInp)
            {
                case "cd":
                    com.ChangeDirectory();
                    break;
                case "help":
                    com.HelpMessage();
                    break;
                case "clear":
                    com.Clear();
                    break;
                case "showlast":
                    com.ShowLast();
                    break;
                case "showfiles":
                    com.ShowFiles();
                    break;
                case "showfolders":
                    com.ShowFolders();
                    break;
                case "showall":
                    com.ShowAll();
                    break;
                default:
                    com.Clear();
                    com.ShowLast();
                    break;
            }
        }
    }
}