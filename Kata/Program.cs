using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            string RiMnumber = "XXIV";
            List<int> EURnumber = new List<int>();

            for (int i = 0; i < RiMnumber.Count(); i++)
            {
                switch (RiMnumber[i])
                {
                    case ('I'):
                        EURnumber.Add(1);
                        break;
                    case ('V'):
                        EURnumber.Add(5);
                        break;
                    case ('X'):
                        EURnumber.Add(10);
                        break;
                    case ('L'):
                        EURnumber.Add(50);
                        break;
                    case ('C'):
                        EURnumber.Add(100);
                        break;
                    case ('D'):
                        EURnumber.Add(500);
                        break;
                    case ('M'):
                        EURnumber.Add(1000);
                        break;
                }
            }

            for (int i = 0; i < EURnumber.Count() - 1; i++)
            {
                if (EURnumber[i] < EURnumber[i + 1])
                {
                    EURnumber[i + 1] = EURnumber[i + 1] - EURnumber[i];
                    EURnumber[i] = 0;

                }
            }

            int total = EURnumber.Sum();
            Console.WriteLine(total);


        }
    }
}
