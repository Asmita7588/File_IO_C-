using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFileOperations
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public  static void AddStudent()
        {
            var student = new List<Student>
            {
             new Student{ Id = 101, Name = "Asmita", City = "khat" },
             new Student{ Id = 102, Name = "puja", City = "shirpur" },
             new Student{ Id = 103, Name = "Rishikesh", City = "bhusaval"}
            };
        }
    }
}
