using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    abstract class Employee
    {
        protected String id;
        protected string name;
        protected string address;
        public string Id
        {
            set { this.id = value; }
            get { return this.id; }
        }
        public String Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public String Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
         public virtual void PrintInfo()
        {
            Console.WriteLine("Id : {0} \nName : {1} \nAddress : {2}");
        }
        abstract public bool EmployeeStatus();
    
    }
}