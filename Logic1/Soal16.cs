﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    class Soal16
    {
        public Soal16(int input)
        {
            Hasil(input);
        }
        static void Hasil(int input)
        {
            int number = 1;
            int[] deret = new int[input];
            for (int i = 0; i < deret.Length; i++)
            {
                number =  i * i * i;
                deret[i] = number;

                
            }
            for (int i = 0; i < deret.Length; i++)
            {
                Console.Write(deret[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
