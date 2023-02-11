using OOPLab.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab.ServiceImplementation
{
    internal class Bike : IVehicle
    {
        int speed;
        int gear;
        public void applyBrakes(int newGear)
        {
            gear = newGear;
        }

        public void changeGear(int increment)
        {
            speed = speed + increment;
        }

        public void speedUp(int increment)
        {
            speed = speed - increment;
        }

        public void printStates()
        {
            Console.WriteLine("speed: " + speed + " gear: " + gear);
        }

    }
}
