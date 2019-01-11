using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttandanceSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.InitData();
            p.ProgramStart();
            Console.Read();
        }
        public void ProgramStart()
        {
            var guid = Guid.NewGuid().ToString();
            Program p = new Program();


        home:

            switch (p.Student())
            {
                case "a":
                case "A":
                    p.StudentList();
                    Console.Read();
                    p.ProgramStart();
                    break;
                case "b":
                case "B":
                    p.GetAttendance();
                    break;
                case "c":
                case "C":
                    p.Greetings();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("========================================================================");
                    Console.WriteLine("\t\t\t\tInvalid Choice");
                    Console.WriteLine("========================================================================");

                    goto home;

            };

        }
        public string Student()
        {
            string option;
            Console.WriteLine("\n************************************************************************");
            Console.WriteLine("--------------               WELCOME                         -----------");
            Console.WriteLine("--------------        Attendance Management System           -----------");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("====                          OPTION                               =====");
            Console.WriteLine("**********    A. View Student List             *************************");
            Console.WriteLine("**********    B. Get Attendance                *************************");
            Console.WriteLine("**********    C. EXIT                  *************************");
            Console.WriteLine("========================================================================");
            Console.Write("\t\t\tSelect Option:   ");
            option = Console.ReadLine();
            Console.Clear();

            return option;
        }
        public void InitData()
        {
            string id1 = Guid.NewGuid().ToString();
            string id2 = Guid.NewGuid().ToString();
            DataSet.StudentList.Add(new Student(id1, "Belyn", "Jariol"));
            DataSet.StudentList.Add(new Student(id1, "Bel", "riol"));
            DataSet.StudentList.Add(new Student(Guid.NewGuid().ToString(), "Kulot", "Sildo", "17-20063"));
            DataSet.StudentList.Add(new Student(Guid.NewGuid().ToString(), "Belyn", "Jariol", "15-10144"));
        }


        public void StudentList()
        {
            Program p = new Program();
            {
                Console.WriteLine("==============================================================");
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxx  Student List xxxxxxxxxxxxxxxxxxxxxxx");
                Console.WriteLine("==============================================================");
                int count = 1;
                foreach (Student s in DataSet.StudentList)
                {
                    try
                    {

                        Console.WriteLine(count++ + " " + s.toString());

                        Console.Read();
                    }
                    catch
                    {

                    }
                }
                Console.WriteLine("Press any key to Continue");
            }
            Console.Clear();
            p.Student();
        }
        public void GetAttendance()
        {
            Console.WriteLine("*********      LOG IN           ******");
            Console.WriteLine("**   Please Input The Following     **");
            Console.WriteLine("**    for you to be not absent      **");
            Program p = new Program();
            string firstname, lastname, middlename, id;
            Console.Write("Student First Name: ");
            firstname = Console.ReadLine();
            Console.Write("Student Last Name: ");
            lastname = Console.ReadLine();
            Console.Write("Student Middle Name: ");
            middlename = Console.ReadLine();
            Console.Write("ID Number: ");
            id = Console.ReadLine();

            Student u = new Student(Guid.NewGuid().ToString(), id, firstname, lastname);
            DataSet.StudentList.Add(u);

            Console.Clear();
            p.ProgramStart();
        }
        public void Greetings()
        {
            Console.WriteLine("THANK YOU FOR COOPERATING!!");
            Console.Read();
        }
    }
}