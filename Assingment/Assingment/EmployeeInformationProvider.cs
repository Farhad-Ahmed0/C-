using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class EmployeeInformationProvider
    {
        Employee[] emply = new Employee[10];
        public void ProvideDetails()
        {
            foreach (Employee p in emply)
            {
                if (p != null)
                {
                    p.PrintInfo();
                }
                else continue;
            }
        }
        public void GetSkilledPlayers()
        {
            foreach (Employee p in emply)
            {
                if (p != null && p.GetType().ToString() == "Assignment.Player")
                {
                    if (((Player)p).Rating > 80)
                    {
                        p.PrintInfo();
                    }
                    else continue;
                }
            }
        }
        public Employee[] Emply
        {
            set { this.emply= value; }
            get { return this.emply; }
        }
    }
}
