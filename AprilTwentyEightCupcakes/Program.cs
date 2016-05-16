using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprilTwentyEightCupcakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many cupcakes do you have?");
            int cupcakes = int.Parse(Console.ReadLine());
            Console.WriteLine("How many people are sharing?");
            int people = int.Parse(Console.ReadLine());

            try
            {

                int cupcakesPerPerson = cupcakes / people;

                int remainingCupCakes = cupcakes % people;

                Console.WriteLine("Each person get {0} cupcakes, and there are {1} left over.",
                    cupcakesPerPerson, remainingCupCakes);
            }
            catch (DivideByZeroException)
            { 
            }
            Console.WriteLine("You can't split cupcakes with zero people!");

        }

          }
    }

