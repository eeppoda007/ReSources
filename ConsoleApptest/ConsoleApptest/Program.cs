using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptest
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] colors = { "red", "blue", "green", "yellow", "blue", "green", "blue", "blue", "red", "green" };

            string userSelection= "red";
            int numberOfFish = 0;
            string selectedColor = string.Empty;
            //In this section we will loop through the array 
            for (int i = 0; i < colors.Length; i++)
            {
                if (userSelection.Equals("1"))//user selection possition in array here
                {
                    if (colors[i] == "red")// color name out of the array 
                    {
                        selectedColor = colors[i]; // print the selected color to Console
                        numberOfFish++;// increment of change 
                    }
                }

            }
            Console.WriteLine("In the fish tank there are {0} fish of the color {1}", numberOfFish, selectedColor);
        }
    }

}
