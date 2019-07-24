using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    class Soal13
    {
        public Soal13(int input)
        {
            Hasil(input);
        }
        static void Hasil(int input)
        {
            int number1 = 1, number2 = 1, number3 = 1 ;
            int jumlah = 0;
            
            int[] deret = new int[input];
            for (int i = 0; i < deret.Length; i++)
            {
                
                jumlah = number1 + number2 + number3;
                deret[i] = number1;
                number1 = number2;
                number2 = number3;
                number3 = jumlah;
                Console.Write(deret[i] + "\t");
            }

            Console.WriteLine("\n");
        }
    }
}
