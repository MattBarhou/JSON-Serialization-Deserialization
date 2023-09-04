using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ImportExportApp
{
    internal class Student
    {
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"StudentID: {StudentID}, Full Name: {FullName}, Email: {Email}";
        }

        public static void WriteFile(List<Student> students, string filename)
        {
            StreamWriter writer = new StreamWriter(filename);

            foreach (Student student in students)
            {
                string convertedString = JsonSerializer.Serialize(student);
                writer.Write(convertedString);
            }         
            writer.Close();
            
        }

        public static List<Student> ReadFile(string filename)
        {
            List<Student> mystudents = new List<Student>();

            StreamReader reader = new StreamReader(filename);

            string deserializedString = reader.ReadLine();

            if (deserializedString != null)
            {
                Student student = JsonSerializer.Deserialize<Student>(deserializedString);
                mystudents.Add(student);
                deserializedString = reader.ReadLine();
                Console.WriteLine(student.ToString());
            }
            reader.Close();
            return mystudents;
        }


    }
}
