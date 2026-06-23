using System;
namespace StudentRecords
{
    struct Student
    {
        public int ID;
        public int SemestersComplete;
        public int CreditsCompleted;
        public double CGPA;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            students[0] = new Student { ID = 1, SemestersComplete = 3, CreditsCompleted = 60, CGPA = 3.8 };
            students[1] = new Student { ID = 2, SemestersComplete = 2, CreditsCompleted = 40, CGPA = 3.9 };
            students[2] = new Student { ID = 3, SemestersComplete = 4, CreditsCompleted = 70, CGPA = 3.5 };
            students[3] = new Student { ID = 4, SemestersComplete = 2, CreditsCompleted = 30, CGPA = 3.7 };
            students[4] = new Student { ID = 5, SemestersComplete = 3, CreditsCompleted = 55, CGPA = 3.95 };

            Console.WriteLine("Scholarship students (CGPA 3.75 or above):");
            foreach (var student in students)
            {
                if (student.CGPA >= 3.75)
                {
                    Console.WriteLine("ID: " + student.ID);
                }
            }

            Console.WriteLine("\nStudents with more than 50 credits:");
            foreach (var student in students)
            {
                if (student.CreditsCompleted > 50)
                {
                    Console.WriteLine("ID: " + student.ID);
                }
            }

            Console.WriteLine("\nStudents with at least 2 semesters and 28 credits:");
            foreach (var student in students)
            {
                if (student.SemestersComplete >= 2 && student.CreditsCompleted >= 28)
                {
                    Console.WriteLine("ID: " + student.ID);
                }
            }
        }
    }
}
