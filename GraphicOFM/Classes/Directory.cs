using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.ExceptionServices;

namespace FileManager.Classes
{
    // Данные о директории.
    class DirectCreate
    {
        // Объект для взаимодействия с директорией
        DirectoryInfo direct;
        // Массив из файлов
        protected FileInfo[] filesDir;
        // Массив из папок
        protected DirectoryInfo[] dirsDir; 
        public DirectCreate(string s = @"C:\") // Конструктор класса
        {
            direct = new DirectoryInfo(s);
            filesDir = direct.GetFiles();
            dirsDir = direct.GetDirectories();
        }
        // GUI code
        public string[] DirectoryToStringFormat()
        {
            string[] listDirect = new string[dirsDir.Length];
            for (int i = 0; i < dirsDir.Length; i++)
            {
                listDirect[i] = Convert.ToString(dirsDir[i].Name);
            }
            return listDirect;
        }
        public string[] FileToStringFormat()
        {
            string[] listFile = new string[filesDir.Length];
            for (int i = 0; i < filesDir.Length; i++)
            {
                listFile[i] = Convert.ToString(filesDir[i].Name);
            }
            return listFile;
        }
    }
}