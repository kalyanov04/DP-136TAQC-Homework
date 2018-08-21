using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Parking
{
    class Trailer : Vehicle
    {
        public Trailer()
        {
            Input();
        }
        void Input()
        {
            Console.WriteLine("Enter speed of trailer");
            Speed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter turning radius of trailer");
            TurningRadius = Convert.ToInt32(Console.ReadLine());
        }
    }
}
