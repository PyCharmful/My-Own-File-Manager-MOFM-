using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.ExceptionServices;

namespace GraphicOFM.Classes
{
    // Данные о директории.
    class DirectCreate
    {
        // Объект для взаимодействия с директорией
        DirectoryInfo direct;
        // Массив из файлов
        public FileInfo[] FilesDir { get; private set; }
        // Массив из папок
        public DirectoryInfo[] DirsDir { get; private set; }
        public StringBuilder DirPath { get; private set; }
        public DirectCreate(StringBuilder s = null) // Конструктор класса
        {
            DirPath = s;
            string pathString = DirPath?.ToString() ?? @"C:\";
            direct = new DirectoryInfo(pathString);
            FilesDir = direct.GetFiles();
            DirsDir = direct.GetDirectories();
        }
        // GUI code
        public string[] DirectoryToStringFormat()
        {
            string[] listDirect = new string[DirsDir.Length];
            for (int i = 0; i < DirsDir.Length; i++)
            {
                listDirect[i] = Convert.ToString(DirsDir[i].Name);
            }
            return listDirect;
        }
        public string[] FileToStringFormat()
        {
            string[] listFile = new string[FilesDir.Length];
            for (int i = 0; i < FilesDir.Length; i++)
            {
                listFile[i] = Convert.ToString(FilesDir[i].Name);
            }
            return listFile;
        }
    }
}