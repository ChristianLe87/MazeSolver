using System;
using System.Collections.Generic;
using System.IO;

namespace Main_Maze_Solver
{
    public class FileManager
    {
        string fileName;

        public FileManager(string fileName)
        {
            this.fileName = fileName;
        }


        public bool FileExist()
        {
            if (File.Exists(fileName))
                return true;

            return false;
        }


        public void DeleteFile()
        {
            File.Delete(fileName);
        }

        public void CreateFile(List<List<string>> fileContent)
        {
            using (StreamWriter sw = File.CreateText(fileName))
            {
                foreach(var line in fileContent)
                {
                    string s = "";
                    foreach (var element in line)
                    {
                        s = s + "," + element;
                    }
                    sw.WriteLine(s);
                }
            }
        }

        public List<string> ReadFile()
        {
            List<string> fileContent = new List<string>();

            StreamReader sr = File.OpenText(fileName);

            string s = "";

            while ((s = sr.ReadLine()) != null)
            {
                fileContent.Add(s);
            }
            return fileContent;
        }


        public void printfile()
        {
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
