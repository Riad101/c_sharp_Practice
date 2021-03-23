using System.Collections.Generic;

namespace LINQ_Excercise
{
    public class StudentMarks
    {
        public int StudentID { get; set; }
        public string SName { get; set; }
        public int TotalMarks { get; set; }

        public static List<StudentMarks> GetAllStudetnMarks()
        {
            List<StudentMarks> listStudents = new List<StudentMarks>
        {
            new StudentMarks
            {
                StudentID= 101,
                SName = "Tom",
                TotalMarks = 800
            },
            new StudentMarks
            {
                StudentID= 102,
                SName = "Mary",
                TotalMarks = 900
            },
            new StudentMarks
            {
                StudentID= 103,
                SName = "Pam",
                TotalMarks = 800
            },
            new StudentMarks
            {
                StudentID= 104,
                SName = "John",
                TotalMarks = 800
            },
            new StudentMarks
            {
                StudentID= 105,
                SName = "John",
                TotalMarks = 800
            },
        };

            return listStudents;
        }
    }
}
