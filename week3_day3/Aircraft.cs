using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day3
{
    class Aircraft:Vehicle

    {
        private double altitude;

        public Aircraft(int seats, int carringCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carringCapacity = carringCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            
        }

        public override void Move()
        {
            altitude += 10000.0d;
            base.Move();
        }

        public override string GetDistanceTraveled()
        {
            return "altide:" + altitude + "-" + base.GetDistanceTraveled();
        }
        





    }
}
