using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    class Soal14
    {
        public Soal14(int input)
        {
            Hasil(input);
        }
        static void Hasil(int input)
        {
            String bilPrima = " ";
            for (int i = 0; i < input; i++)
            {
                int prima = 0;
                for (int j = i; j >0; j--)
                {
                    if (i%j==0)
                    {
                        prima += 1;
                        //Console.Write("{0}\t{1}\n", i, j);
                    }
                    
                }
                if (prima == 2)
                {
                   bilPrima = bilPrima + i + " ";
                }
            }
            Console.WriteLine("Bilangan Prima");
            Console.WriteLine(bilPrima);
        }
    }
}
