using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Student2
{
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public List<int> Scores;


        public static List<Student> students = new List<Student>
        {
            new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores = new List<int> {97, 92, 81, 60}},
            new Student {First="Claire", Last = "O'Donnell", ID=112, Scores = new List<int> {75, 84, 91, 39}},
            new Student {First="Sofia", Last = "Black", ID=113, Scores = new List<int> {82, 94, 67, 45}},
            new Student {First="Robert", Last = "Osmond", ID=114, Scores = new List<int> {95, 94, 71, 85}},
            new Student {First="Tom", Last = "Grant", ID=115, Scores = new List<int> {98, 94, 85, 77}},
            new Student {First="Katrin", Last = "Davis", ID=112, Scores = new List<int> {95, 97, 82, 79}},
            new Student {First="Albert", Last = "Martin", ID=112, Scores = new List<int> {90, 74, 88, 65}},
            new Student {First="David", Last = "Milns", ID=112, Scores = new List<int> {92, 53, 79, 60}},
            new Student {First="Jenny", Last = "Brown", ID=112, Scores = new List<int> {97, 98, 56, 45}},
            new Student {First="Anna", Last = "Garcia", ID=112, Scores = new List<int> {95, 89, 48, 70}},
            new Student {First="Mario", Last = "Garcia", ID=112, Scores = new List<int> {91, 83, 73, 59}}
        };
    }
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Student> studentQuery =
                from student in Student.students
                where student.Scores[0] > 90 && student.Scores[3] < 80
                orderby student.Scores[0] descending
                select student;
            foreach (Student student in studentQuery)
            {
                Console.WriteLine("{0}, {1}, {2}", student.Last, student.First, student.Scores[0]);
            }
            Console.WriteLine("-----------------------------------------------------");

            var studentQuery2 =
                from student in Student.students
                group student by student.Last[0];
            foreach (var studentsGroup in studentQuery2)
            {
                Console.WriteLine(studentsGroup.Key);
                foreach (Student student in studentsGroup)
                {
                    Console.WriteLine($"{student.Last}, {student.First}");
                }
            }
            Console.WriteLine("-----------------------------------------------------");

            var studentQuery3 =
                from student in Student.students
                group student by student.Last[0];
            foreach (var studentsGroup in studentQuery3)
            {
                Console.WriteLine(studentsGroup.Key);
                foreach (var student in studentsGroup)
                {
                    Console.WriteLine($"{student.Last}, {student.First}");
                }
            }
            Console.WriteLine("-----------------------------------------------------");

            var studentQuery4 =
                from student in Student.students
                group student by student.Last[0] into studentGroup
                orderby studentGroup.Key
                select studentGroup;
            foreach (var groupOfStudents in studentQuery4)
            {
                Console.WriteLine(groupOfStudents.Key);
                foreach (var student in groupOfStudents)
                {
                    Console.WriteLine($"{student.Last}, {student.First}");
                }
            }
            Console.WriteLine("-----------------------------------------------------");

            var studentQuery5 =
                from student in Student.students
                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                where totalScore / 4 < student.Scores[0]
                select student.Last + " " + student.First;
            foreach (string s in studentQuery5)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-----------------------------------------------------");

            var studentQuery6 =
                from student in Student.students
                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                select totalScore;
            double averageScore = studentQuery6.Average();
            Console.WriteLine($"Class average score = {averageScore}");
            Console.WriteLine("-----------------------------------------------------");

            IEnumerable<string> studentQuery7 =
                from student in Student.students
                where student.Last == "Garcia"
                select student.First;
            Console.WriteLine("The Garcias in the class are: ");
            foreach (string s in studentQuery7)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-----------------------------------------------------");

            var studentQuery8 =
                from student in Student.students
                let x = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                where x > averageScore
                select new { id = student.ID, score = x };
            foreach (var item in studentQuery8)
            {
                Console.WriteLine($"Student ID: {item.id}, Score: {item.score}");
            }
        }
    }
}
