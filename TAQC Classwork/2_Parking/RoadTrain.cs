using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Parking
{
    class RoadTrain:Vehicle
    {
        Car car;
        Trailer trailer;

        public RoadTrain(Car car, Trailer trailer) 
        {
            if (car.Speed < trailer.Speed)
                Speed = car.Speed;

            else
                Speed = trailer.Speed;

            if (car.TurningRadius < trailer.TurningRadius)
                TurningRadius = trailer.TurningRadius;
            else
                TurningRadius = car.TurningRadius;

        }


    }
}
