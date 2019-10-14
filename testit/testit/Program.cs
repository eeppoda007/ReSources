using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an amount to find out if it's ");
            string userMoney = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userMoney))
            {
                Console.WriteLine("please do not leave this blank\r\nPlease enter an amount to find out if it's a current currency in amaerica");
                userMoney = Console.ReadLine();
            }
            //string result = confirmedMoney(userMoney);
            Console.WriteLine(userMoney);

        }


        public static string confirmedMoney(string userMoney)
        {
            userMoney = Console.ReadLine();
            double validMoney;
            while (!(double.TryParse(userMoney, out validMoney) || (userMoney.IndexOf("$") != 0) || (userMoney.IndexOf(".") != 4) || (userMoney.IndexOf(".") != 3)))
            {
                Console.WriteLine("Please enter a numeric value only.\r\nPlease enter an amount to find out if it's a current currency in amaerica");               
                userMoney = Console.ReadLine();
            }

            if ((userMoney.IndexOf("$") == 0) && (userMoney.IndexOf(".") == 2) || (userMoney.IndexOf(".") == 4))
            {
                Console.WriteLine("the amount you entered {0} is valid for American currency.", validMoney.ToString("c"));
            }
            if ((userMoney.IndexOf("$") != 0) || (userMoney.IndexOf(".") != 4) || (userMoney.IndexOf(".") != 3))
            { Console.WriteLine("The amount you enter {0} is not valid for American currency", userMoney); }
            string results = Convert.ToString(validMoney);
            return results;



        }

        public int[] Subtraction(int[] oneArray, int[] twoArray)
        {
            int[] thirdArray = new int[] { };
            for (int i = 0; i < oneArray[i]; i--)
            {

                int[] final = { oneArray[i] - twoArray[i] };
                thirdArray[i] = final[i];
            }
            return thirdArray;
        }

    }
    
}
