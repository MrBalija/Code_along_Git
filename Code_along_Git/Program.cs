using System;
using System.Linq;

namespace Code_along_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Ett sätt
            int[] arrayOfNumbers = new int[5];

            arrayOfNumbers[0] = 13;
            arrayOfNumbers[1] = 22;
            arrayOfNumbers[2] = 3;
            arrayOfNumbers[3] = 93;
            arrayOfNumbers[4] = 1;

            
            Console.WriteLine("Check if you picked a lickely number");
            string nr = Console.ReadLine();
            int myNr = Convert.ToInt32(nr);


            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (myNr == arrayOfNumbers[i])
                {
                    Console.WriteLine("Winner, winner chicken dinner");
                }
                else
                {
                    Console.WriteLine("Not this time");
                }
            }

            Console.WriteLine(arrayOfNumbers.Contains(2));
            */


            //ÖVNING 2
            //Ett sätt
            int[] firstOne = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] secondOne = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            //Console.WriteLine(string.Join(',', firstOne));
            //Console.WriteLine(string.Join(',', secondOne));


            //Ett annat sätt
            Console.WriteLine(string.Join(',', firstOne));
            Console.WriteLine(string.Join(',', firstOne.Reverse()));

        }
    }
}
