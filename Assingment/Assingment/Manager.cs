using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Manager : Employee
    {
        private int yearsOfExperience;
        public int YearsOfExperience
        {
            set { this.yearsOfExperience = value; }
            get { return this.yearsOfExperience; }
        }
         public override bool EmployeeStatus()
         {
            if (yearsOfExperience > 4)
            {
                return true;
            }
            else
                return false;
         }
         public override void PrintInfo()
         {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Year Of Experience: " + yearsOfExperience);
            this.EmployeeStatus();
         }
    }
}