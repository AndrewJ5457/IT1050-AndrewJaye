﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

/* One-dimensional array p contains four elements. The array access expressions for each of the elements are ___p[0]_____,__p[1]____,____p[2]___and__p[3]____. */

        string[] months =  {"1st January", "2nd February", "3rd March", "4th April", "5th May",
                            "6th June", "7th July", "8th August", "9th September",
                            "10th October", "11th November", "12th December"};

            for (int i = 0; i < 12; i++)

            {
                Console.WriteLine(months[i]);
            }

           string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

           foreach (string season in seasons)

            {
               Console.WriteLine(season);
            }
          
          int[] randomNumber = new int[1000];
                Random random = new Random();

           for (int i = 0; i < randomNumber.Length; i++)
           {
           randomNumber[i] = random.Next(0, 100);
           }

           foreach (int i in randomNumber)
           {
           Console.WriteLine(i.ToString());
           }

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine(names[i]);
                i++;
            }

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine("{0,2}. {1}", i, names[i]);
                i++;
            }

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            foreach (string name in names)
            {
                Console.WriteLine("{0,2}. {1}", i, names[i]);
                i++;
            }