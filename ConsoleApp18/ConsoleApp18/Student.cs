using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Student
    {

        public int Id { get; set; }
        public string Fullname { get; set; }
        public byte Point { get; set; }
        public void Studentinfo()
        {
            Console.WriteLine($"ID:{Id},Fullname:{Fullname},Point:{Point}");


        }
    }
}
