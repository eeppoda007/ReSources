using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Logic Operators

            // And Operator &&

            //Can we buy an iPhone

            decimal budget = 600.00m;
            decimal iphoneCost = 500.00m;

            decimal paycheck = 500.00m;

            // We can buy the phone if the phone is less than budget and our paycheck is greater than 700 to cover bills
            if (iphoneCost<budget && paycheck > 700) {
                Console.WriteLine(" You can buy the iphone");
            }else  {
                Console.WriteLine(" Sorry you cannot buy the phone");
            }

            //|| or operator

            if (iphoneCost < budget || paycheck > 700)
            {
                Console.WriteLine(" You can buy the iphone as an OR case");
            }
            else
            {
                Console.WriteLine(" Sorry you cannot buy the phone in the OR case");

            }
            // Not operator  !

            if( !(iphoneCost>budget) ){
                Console.WriteLine("from the NOT opperator you can buy the phone!");
            }else {
                Console.WriteLine("From the not operator you can NOT buy the phone!");
                //
            }
        }
    }
}
