namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student user = new Student()
            {
                Id = 1,
                Fullname = "Test",
                Point = 100



            };


            int input;

            bool exit = true;

            do
            {
                Console.WriteLine("1. Show info\n2. Create new group");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        user.Studentinfo();


                        break;
                    case 2:
                        Group group = Creategroup();
                        group.AddStudent(user);

                        int input2;
                        do
                        {

                            Console.WriteLine("1. Show all students\n2. Get student by id\n3. Add student\n0. Quit");
                            input2 = Convert.ToInt32(Console.ReadLine());

                            switch (input2)
                            {
                                case 1:
                                    group.GetAllStudents();
                                    break;
                                case 2:

                                    Console.WriteLine("Enter student id:");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    var student = group.GetStudent(id);
                                    student.Studentinfo();

                                    break;
                                case 3:

                                    Student student2 = Createstudent();
                                    group.AddStudent(student2);
                                    Console.WriteLine("telebe elave olundu");
                                    break;
                                case 0:
                                    exit = false;
                                    break;
                            }

                        } while (exit != false);
                        break;
                }
            } while (input != 0);
            static Student Createstudent()
            {
                Student student1 = new Student();
                Console.WriteLine("telebenin adini yazin");
                student1.Fullname = Console.ReadLine();
                Console.WriteLine("telebenin pointini yazin");
                student1.Point = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("id daxil et");
                student1.Id = Convert.ToInt32(Console.ReadLine());
                return student1;
            }

            static Group Creategroup()
            {
                Group group = new Group();
                Console.WriteLine("qrup nomresi daxil et");
                group.Groupno = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("studentlimit daxil et");
                group.Studentlimit = Convert.ToInt32(Console.ReadLine());
                return group;
            }


        }
   }
}
