using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           // to this Program we shall add a Protain calculator an exception handler and other tools of use.
            Console.WriteLine("in this program you will input the amount of Calories you ate to day and compare the result to the avarage");
            Console.ReadKey();
            CalCounter();
            Console.Read();




        }

        public static void CalCounter()
        {
            List<int> calore = new List<int> { };
            string calInput = "", mealend = "continue";
            // solve this problem of while..we want this to be created as a switch with a simple trigger to END the program.
            while(mealend == "continue")
            {
                Console.WriteLine("Please input the number of calories of the current Meal");
                calInput = Console.ReadLine();
                calore.Add(Convert.ToInt32(calInput));
                Console.WriteLine("The Current Calore input is {0}", calore.Sum());
                Console.WriteLine("The amount of meals you currently had are {0}", calore.LongCount());
                Console.WriteLine("Did you eat enough Meals?? type continue to add another meal anything else to end it.");
                mealend = Console.ReadLine();
                Console.ReadKey();
            } 

            if (calore.Sum() <= 2000)
            {
                Console.WriteLine("You have {0} calories which is less than 2000 you are in a Caloric Deficet", calore.Sum());
            }
            else 
            {
                Console.WriteLine("you have {0} Calories which is More than 2000 you are in a Caloric Surplus", calore.Sum());

            }
            

                

        }
    }
}
