using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day3
{
    class Vehicle
    {                                                //this is my base class.
        private int seats;
        private int carringCapacity;
        private string color;
        private double movementSpeed;
        private float gearRatio;
        private float engineSize;
        private double distanceTraveled;

        public double DistanceTraveled
        {
            get { return this.distanceTraveled; }
        }

        public int Seats
        {
            get { return this.seats; }

        }

        public int CarringCapacity
        {
            get { return this.carringCapacity; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Vehicle(int seats, int carringCapacity, string color, double movementSpeed ) { 


            this.seats = seats;
            this.carringCapacity = carringCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.distanceTraveled = 0.0d;
        }
        public Vehicle()
        {

        }

        public void Move()
        {
            distanceTraveled += movementSpeed;
        }

    }
}
