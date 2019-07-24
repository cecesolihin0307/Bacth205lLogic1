using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    class Soal7
    {
        public Soal7(int input)
        {
            Hasil(input);
        }
        static void Hasil(int input)
        {
            int number = 2;
            //array variabel yg banyak isi nya
            int[] arrayInt = new int[input];
            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = number;
                number *= 2;
                Console.Write(arrayInt[i] + "\t");
            }

            Console.WriteLine("\n");
        }
    }
}
