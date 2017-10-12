using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day3
{
    class Surgeon:Doctor
    {

        public Surgeon()
        {

        }

        public Surgeon(string employeeName,int employeeNumber,string department, int numberOfPatience)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.numberOfPatience = numberOfPatience;
        }
    }
}
