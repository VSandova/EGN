using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowTo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2485109736

            // EGN 8406194582 - 1984
            // EGN 7552011038 - 2075
            // EGN 7524169268 - 1875

            string myEgn = "9709046051";

            int years = int.Parse(myEgn.Substring(0, 2));
            int months = int.Parse(myEgn.Substring(2, 2));
            int days = int.Parse(myEgn.Substring(4, 2));

            string genderDigit = myEgn.Substring(8, 1);

            bool isFemale = IsFemale(genderDigit);

            Console.WriteLine("Is Viktoriq female? ==> " + isFemale);

            if (months > 0 && months <13)
            {
                Console.WriteLine("19" + years);
            }
            else if (months > 20 && months < 33)
            {
                months -= 20;


                Console.Write("18" + years);
                Console.WriteLine(".{0}.{1}", months, days);
                
                
            }

            else if (months > 40 && months < 53)
            {
                Console.WriteLine("20" + years);
                Console.WriteLine(".{0}.{1}", months, days);
                months -= 40;
            }
            else
            {
                Console.WriteLine("Wrong Date! INVALID EGN");

            }

            CheckDigitWeight(myEgn);









        }

        private static void CheckDigitWeight(string myEgn)
        {
            int[] digits = new int[myEgn.Length];
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = myEgn[i]; 
            }


            int currentSum = (digits[0] *2 + digits[1] *4 + digits[2] *8 + digits[3] *5 + digits[4] *10 + digits[5] *9 + digits[6] *7 + digits[7] *3 + digits[8]* 6);
            Console.WriteLine(currentSum);
            currentSum = currentSum % 11;
            if (currentSum == 10)
            {
                currentSum = 0;
            }
            Console.WriteLine(11 - currentSum);
        }


        

        public static bool IsFemale(string genderDigit)
        {
            bool isFemale = false;
            int digit = int.Parse(genderDigit);
            if (digit % 2 != 0)
            {
                isFemale = true;
            }

            return isFemale;
        }






    }
}
