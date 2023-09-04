namespace ImportExportApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string filename = "student.json";
            List<Student> students = new List<Student>();

            students.Add(new Student { StudentID = "301193037", FullName = "Matthew Barhou", Email = "mbarhou@my.centennialcollege.ca" });

            //Write the student to the file
            Student.WriteFile(students, filename);

            //Load the data from file
            List<Student> newStudent = new List<Student>();
            newStudent = Student.ReadFile(filename);

            foreach (Student student in newStudent)
            {
                Console.WriteLine(student);
            }
        }
    }
}