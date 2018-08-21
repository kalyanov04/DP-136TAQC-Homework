using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Parking
{
    abstract class Vehicle
    {
        int speed;
        int turningRadius;
        public int TurningRadius { get => turningRadius; set => turningRadius = value; }
        public int Speed { get => speed; set => speed = value; }

        public Vehicle()
        {
            
        }
        public int GetSpeed()
        {
            return Speed;
        }

        public int GetTurningRadius()
        {
            return TurningRadius;
        }

    }
}
