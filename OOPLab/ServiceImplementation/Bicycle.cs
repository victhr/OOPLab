using OOPLab.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab.ServiceImplementation
{
    internal class Bicycle : IVehicle
    {
        int gear;
        int speed;
        public void applyBrakes(int newGear)
        {
            gear = newGear;
        }

        public void changeGear(int increment)
        {
            speed = speed + increment * 2;
        }

        public void speedUp(int increment)
        {
            speed = speed - increment - 1;
        }

        public void printStates()
        {
            Console.WriteLine("speed: " + speed + " gear: " + gear);
        }
    }
}
