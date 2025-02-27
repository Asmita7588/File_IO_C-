using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Newtonsoft.Json;

namespace BasicFileOperations
{
    internal class JSONFileOperation
    {
        public static void CreateJSONFile()
        {
            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\BasicFileOperations\BasicFileOperations\Studentjson.json";

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

            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\BasicFileOperations\BasicFileOperations\StudentJSON.json";

            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File Deleted");
            }
        }

        public static void WriteToJsonFile()
        {
            Console.WriteLine("Writting to the flie");

            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\BasicFileOperations\BasicFileOperations\StudentJSON.json";

            var studentData = new List<Student>
            {
             new Student{ Id = 101, Name = "Asmita", City = "khat" },
             new Student{ Id = 102, Name = "puja", City = "shirpur" },
             new Student{ Id = 103, Name = "Rishikesh", City = "bhusaval"}
            };

            string jsonData = JsonConvert.SerializeObject(studentData, Formatting.Indented);
            File.WriteAllText(path, jsonData);


            Console.WriteLine("File written successfully.");
        }

        public static void ReadAllLinesFromJsonFile()
        {
            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\BasicFileOperations\BasicFileOperations\StudentJSON.json";

            string jsonRead = File.ReadAllText(path);
            var deserializedData = JsonConvert.DeserializeObject<List<Student>>(jsonRead);
                foreach (var student in deserializedData)
                {
                    Console.WriteLine($"StudentID ={student.Id}, StudentNamr = {student.Name}, StudentCity = {student.City}");
                }
        }
    }
}
