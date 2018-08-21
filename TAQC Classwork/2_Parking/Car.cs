using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Parking
{
    class Car : Vehicle
    {
        public Car()
        {
            Input();
        }
        void Input()
        {
            Console.WriteLine("Enter speed of car");
            Speed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter turning radius of car");
            TurningRadius = Convert.ToInt32(Console.ReadLine());
        }
    }
}
