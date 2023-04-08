using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeInformationProvider eip = new EmployeeInformationProvider();

            Player p1 = new Player();
            p1.Name = "Farhad";
            p1.Id = "PL - 100";
            p1.Address = "Basundhora";
            p1.Rating = 81;
            p1.NoOfMatches = 10;
            p1.PrintInfo();
            Console.WriteLine();
            Console.WriteLine();

            Player p2 = new Player();
            p2.Name = "Faysal";
            p2.Id = "PL - 101";
            p2.Address = "Rampura";
            p2.Rating = 40;
            p2.NoOfMatches = 9;
            p2.PrintInfo();
            Console.WriteLine();
            Console.WriteLine();

            Player p3 = new Player();
            p3.Name = "Rahim";
            p3.Id = "PL - 102";
            p3.Address = "Khilgoan";
            p3.Rating = 80;
            p3.NoOfMatches = 10;
            p3.PrintInfo();
            Console.WriteLine();
            Console.WriteLine();

            Player p4 = new Player();
            p4.Name = "fahim";
            p4.Id = "PL - 103";
            p4.Address = "Khilgoan";
            p4.Rating = 85;
            p4.NoOfMatches = 11;
            p4.PrintInfo();
            Console.WriteLine();
            Console.WriteLine();

            Manager m1 = new Manager();
            m1.Name = "Karim";
            m1.Id = "M- 100";
            m1.Address = "Kuril";
            m1.YearsOfExperience = 5;
            m1.PrintInfo();
            Console.WriteLine();
            Console.WriteLine();

            Manager m2 = new Manager();
            m2.Name = "Rahat";
            m2.Id = "M- 101";
            m2.Address = "Dhanmondi";
            m2.YearsOfExperience = 6;
            m2.PrintInfo();
            Console.WriteLine();
            Console.WriteLine();

            Employee[] emply = new Employee[10];
            emply[0] = p1;
            emply[1] = m1;
            emply[2] = p2;
            emply[3] = m2;
            emply[4] = p3;
            emply[5] = p4;

            eip.Emply = emply;
            Console.WriteLine("*********************************");
            eip.ProvideDetails();
            Console.WriteLine("*********************************");
            eip.GetSkilledPlayers();

        }
    }
}
