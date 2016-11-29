﻿using System;
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
                Console.WriteLine("18" + years);
            }

            else if (months > 40 && months < 53)
            {
                Console.WriteLine("18" + years);
            }
            else
            {
                Console.WriteLine("Wrong Date! INVALID EGN");
            }


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
