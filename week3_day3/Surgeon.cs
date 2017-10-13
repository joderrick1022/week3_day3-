using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day3
{
    class Surgeon:Doctor
    {
        private bool isOperating;
        
        public Surgeon()
        {

        }

        public Surgeon(string employeeName, int employeeNumber, string department,bool isOperating)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.isOperating = isOperating;


        }
    }
}
