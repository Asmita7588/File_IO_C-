using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFileOperations
{
    internal class BasicOperationsDemo
    {
        public static void CreateFile()
        {
            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\BasicFileOperations\BasicFileOperations\DestinationFile.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("File exists");
            }
            else { 
                File.Create(path);
                Console.WriteLine("File created ");
            }
        }

        public static void DeleteFile() {
            
            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\BasicFileOperations\BasicFileOperations\DestinationFile.txt";
            
            if (File.Exists(path)) {
                File.Delete(path);
                Console.WriteLine("File Deleted");
            }
        }

        public static void WriteToFile()
        {
            Console.WriteLine("Writting to the flie");

            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\BasicFileOperations\BasicFileOperations\BasicFileOperations.txt";

            StreamWriter streamWriter = null;

            try
            {
                streamWriter = new StreamWriter(path);
                streamWriter.WriteLine("this file is writing without using ");
                streamWriter.WriteLine(" this is very usful concept when you want save data during excution");


            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();  // Manually closing the StreamWriter
                }
            }

            Console.WriteLine("File written successfully.");
        }

        public static void ReadAllLinesFromFile()
        {
            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\BasicFileOperations\BasicFileOperations\BasicFileOperations.txt";

            string[] lines;
             lines = File.ReadAllLines(path);
            foreach (string line in lines) { 
                Console.WriteLine(line);
            }
        }

        public static void ReadAllTextFromFile()
        {
            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\BasicFileOperations\BasicFileOperations\BasicFileOperations.txt";

            string lines;
            lines = File.ReadAllText(path);
            
                Console.WriteLine(lines);
            
        }

        public static void CopyFile()
        {

            string sourcePath = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\BasicFileOperations\BasicFileOperations\BasicFileOperations.txt";

            string destPath = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\BasicFileOperations\BasicFileOperations\DestinationFile.txt";

            if (File.Exists(sourcePath))
            {
                File.Copy(sourcePath, destPath, true);
                Console.WriteLine("File copied successfully.");
            }
            else
            {
                Console.WriteLine("Source file does not exist.");
            }


        }

    }
}
