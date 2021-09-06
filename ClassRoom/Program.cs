using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            DateTime date1 = new DateTime(2021, 8, 30);
            ClassRoom classRoom = new ClassRoom("Q3", students, date1);
            Student David = new Student("David", 11, 21);
            Student Gabor = new Student("Gabor", 11, 03);
            Student Edem = new Student("Edem", 3, 30);
            Student Paulina = new Student("Paulina", 8, 28);
            Student Nico = new Student("Nico", 12, 21);
            students.Add(David);
            students.Add(Gabor);
            students.Add(Edem);
            students.Add(Paulina);
            students.Add(Nico);

            Console.WriteLine($"Class name :{classRoom.Classname}, Semester start : {classRoom.Semesterstart}");
            Console.WriteLine("List of students + birthmonth + birthday");
            foreach (Student s in students)
            {
                Console.WriteLine(s.Name+" "+s.Birthmonth+" "+s.Birthday);
            }

            Console.ReadKey();
        }
    }
}

