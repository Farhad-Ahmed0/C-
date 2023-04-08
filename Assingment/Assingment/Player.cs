using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Player : Employee
    {
        private int rating;
        private int wagePerMatch=1000;
        private int noOfMatches;

        public int Rating
        {
            set { this.rating = value; }
            get { return this.rating; }
        }
        public int WagePerMatch
        {
            get { return this.wagePerMatch; }
        }
        public int NoOfMatches
        {
            set { this.noOfMatches = value; }
            get { return this.noOfMatches; }
        }
        public override bool EmployeeStatus()
        {
            if (rating > 70 && noOfMatches >= 10)
            {
                return true;
            }
            else
                return false;
        }

        public int TotalEarn()
        {
            int earn = noOfMatches * 1000;
            return earn;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Player ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Rating: " + rating);
            Console.WriteLine("Wage: " + wagePerMatch);
            Console.WriteLine("No Of Matches: " + NoOfMatches);
            Console.WriteLine("Total Earn: " + TotalEarn());
            Console.WriteLine(EmployeeStatus());
        }
    }
}
