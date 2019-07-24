using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    class Soal15
    {
        public Soal15(int input)
        {
            hasil1(input);

            hasil2(input);
        }
        static void hasil1(int input)
        {
            char hurufAwal = 'A';
            char[] huruf = new char[input];
            for (int i = 0; i < huruf.Length; i++)
            {
                Console.Write(hurufAwal + " ");
                hurufAwal++;
            }
            Console.WriteLine();

        }
        static void hasil2(int input)
        {
            char hurufAwal = 'A';
            char[] huruf = new char[input];
            int angkaPertama = 2;
            int[] angka = new int[input];
            for (int i = 0; i < huruf.Length; i++)
            {
                if ((i+1)%2==0)
                {
                    for (int j = 0; j < angka.Length; j++)
                    {
                        angka[j] = angkaPertama;
                        angkaPertama += 2;
                    }
                }
               
                Console.Write(hurufAwal + " ");
               hurufAwal++;
            }
            Console.WriteLine();
        }

    }
}
