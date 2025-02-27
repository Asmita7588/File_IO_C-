using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace BasicFileOperations
{
    internal class CSVFileOperations
    {
        public static void CreateCSVFile()
        {
            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\BasicFileOperations\BasicFileOperations\StudentCSV.csv";

            if (File.Exists(path))
            {
                Console.WriteLine("File exists");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("File created ");
            }
        }

        public static void DeleteFile()
        {

            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\BasicFileOperations\BasicFileOperations\StudentCSV.csv";

            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File Deleted");
            }
        }

        public static void WriteToCsvFile()
        {
            Console.WriteLine("Writting to the flie");

            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\BasicFileOperations\BasicFileOperations\StudentCSV.csv";

            var studentData = new List<Student>
            {
             new Student{ Id = 101, Name = "Asmita", City = "khat" },
             new Student{ Id = 102, Name = "puja", City = "shirpur" },
             new Student{ Id = 103, Name = "Rishikesh", City = "bhusaval"}
            };

            using (var writer = new StreamWriter(path)) 
            using(var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
             csvWriter.WriteRecords(studentData);
            }
            

            Console.WriteLine("File written successfully.");
        }

        public static void ReadAllLinesFromCsvFile()
        {
            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\BasicFileOperations\BasicFileOperations\StudentCSV.csv";

            using (var reader = new StreamReader(path)) 
            using(var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
             var records = csvReader.GetRecords<Student>();

                foreach (var record in records)
                {
                    Console.WriteLine($"StudentID ={record.Id}, StudentNamr = {record.Name}, StudentCity = {record.City}");
                }
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
