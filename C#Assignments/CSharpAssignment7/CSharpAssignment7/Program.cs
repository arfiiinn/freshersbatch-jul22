using System;
using System.IO;

namespace FileIODemo
{
    public class Program
    {
        public static void Main()
        {
            try
            {

                string path = @"C:\Users\arfin\Desktop\FileIO\";
                string[] files = Directory.GetFiles(path);
                string[] directories = Directory.GetDirectories(path);

                Console.WriteLine($"Files in {path}\n");
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    Console.WriteLine(fileName);
                    string filepath = Path.Combine(path, fileName);
                    FileInfo myfile = new FileInfo(filepath);
                    // Opening file to read  
                    StreamReader sr = myfile.OpenText();
                    string data = "";
                    while ((data = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(data);
                    }
                    Console.WriteLine("\n");
                }


                Console.WriteLine($"Subdirectories inside {path}\n");
                foreach (string directory in directories)
                {
                    DirectoryInfo directoryinfo = new DirectoryInfo(directory);
                    directoryinfo.GetDirectories();
                    string directoryName = directoryinfo.Name;
                    Console.WriteLine(directoryName);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}