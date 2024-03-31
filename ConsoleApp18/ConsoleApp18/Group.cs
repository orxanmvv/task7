using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Group
    {
        public int Groupno { get; set; }
        public int Studentlimit
        {
            get { return _studentlimit; }
            set
            {
                if (value > 3 && value < 18)
                {
                    _studentlimit = value;
                }
                else { Console.WriteLine("limit dolub"); }




            }
        }
        private Student[] Students;
        private int _studentlimit;
        public Group()
        {
            Students = new Student[0];
        }




        public void AddStudent(Student student)
        {


            if (Students.Length < Studentlimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }



        }

        public bool CheckGroupNo(string groupNo)
        {
            int letterCount = 0;
            int digitCount = 0;

            foreach (char c in groupNo)
            {
                if (Char.IsUpper(c) && letterCount < 2)
                {
                    letterCount++;
                }
                else if (Char.IsDigit(c) && digitCount < 3)
                {
                    digitCount++;
                }
            }

            return letterCount == 2 && digitCount == 3;
        }
        public Student GetStudent(int id)
        {
            if (id <= 0)
            {
                Console.WriteLine("id yanlis daxil edilib");
                return null;
            }

            foreach (var student in Students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }

            return null;
        }

        public void GetAllStudents()
        {
            foreach (var item in Students)
            {
                Console.WriteLine($"Id {item.Id}  Fullname{item.Fullname}   Point{item.Point}");
            }
        }
    }
}
