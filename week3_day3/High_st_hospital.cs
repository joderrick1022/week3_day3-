using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day3
{
    class High_st_hospital
    {

      protected  int employeeNumber;
        protected string employeeName;
        protected string department;
        protected int numberOfPatience;
        private bool isOnPhone = true;




        public int EmployeeNumber
        {
            get { return this.employeeNumber; }
        }

        public string EmployeeName
        {
           get { return this.employeeName; }
        }
        public string Department
        {
            get { return this.department; }
        }
        public int NumberOfPatience
        {
            get { return this.numberOfPatience; }
            set { this.numberOfPatience = value; }
        }

        public bool IsOnPhone
        {
            get { return this.isOnPhone; }
        }

        public High_st_hospital()
        {

        }
        public High_st_hospital(string employeeName,int employeeNumber)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;

        }


        public void  clockIn()
        {
            Console.WriteLine("welcome to your Job");
            int time = int.Parse(Console.ReadLine()); 
        }








    }
}
