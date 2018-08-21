using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Parking
{
    class Parking
    {
        public List<Vehicle> vehicles;
        
        public Parking()
        {
            vehicles = new List<Vehicle>();
        }

        public Vehicle GetMaximumSpeed()
        {
            int maxSpeed = 0;
            foreach (var item in vehicles)
            {
                if (item.Speed > maxSpeed)
                    maxSpeed = item.Speed;
            }
            foreach (var item in vehicles)
            {
                if (maxSpeed == item.Speed)
                    return item;
            }
            return null;
        }

        public Vehicle GetMaximumRadius()
        {
            int maxRadius = 0;
            foreach (var item in vehicles)
            {
                if (item.TurningRadius > maxRadius)
                    maxRadius = item.TurningRadius;
            }
            foreach (var item in vehicles)
            {
                if (maxRadius == item.TurningRadius)
                    return item;
            }
            return null;
        }

        public void WriteToFile()
        {

        }

    }
}
