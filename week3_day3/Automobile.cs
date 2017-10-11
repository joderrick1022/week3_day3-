using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day3
{
    class Automobile : Vehicle
    {
        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;


        public int NumberOfWheels
        {
            get { return this.numberOfDoors; }
        }
        //constructor

        public Automobile(int numberOfWheels, float wheelSize, int numberOfDoors, double movementSpeed, string color) { 
            this.numberOfWheels = numberOfWheels;
            this.wheelSize = wheelSize;
            this.numberOfDoors = numberOfDoors;
            this.movementSpeed = movementSpeed;
            this.color = color;


        }
        public Automobile()
        {

        }
       

        
    }
}
