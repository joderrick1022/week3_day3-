using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day3
{
    class Doctor:High_st_hospital
    {

        private string specialArea;

        public string SpecialArea
        {
            get { return this.specialArea; }
        }


        public Doctor()
        {

        }

        public Doctor(string employeeName,int employeeNumber,string department,int numberOfPatience)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.numberOfPatience = numberOfPatience;
        }






    }
}
