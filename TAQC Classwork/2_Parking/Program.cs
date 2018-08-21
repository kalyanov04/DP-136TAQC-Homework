using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Parking parking = new Parking();
            for (int i = 0; i < 3; i++)
            {


                Console.WriteLine("Add Vehicle");
                Console.WriteLine("1.Car");
                Console.WriteLine("2.Trailer");
                Console.WriteLine("3.RoadTrain");

                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        parking.vehicles.Add(new Car());
                        break;
                    case ConsoleKey.D2:
                        parking.vehicles.Add(new Trailer());
                        break;
                    case ConsoleKey.D3:
                        parking.vehicles.Add(new RoadTrain(new Car(), new Trailer()));
                        break;
                }
            }

            for (int i = 0; i < parking.vehicles.Count; i++)
            {
                Console.WriteLine("Vehicle # {0}: Speed - {1}, Turning radius - {2}", 
                    i+1,parking.vehicles[i].Speed, parking.vehicles[i].TurningRadius);
            }

            Console.WriteLine("\nMaximum speed: " + parking.GetMaximumSpeed().Speed);
            Console.WriteLine("Maximum radius: " + parking.GetMaximumRadius().TurningRadius);

         
        }
    }
}
