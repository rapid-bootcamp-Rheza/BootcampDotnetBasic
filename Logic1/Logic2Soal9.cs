using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic2
{
    public class Logic2Soal9
    {
        public Logic2Soal9() { }
        public static void Cetak9(int n)
        {
            int nilaiTengah = n / 2;
            for (int i = 0; i < n; i++)
            {
                int angka = 1;
                for (int j = 0; j < n; j++)
                {
                    if (i+j >= nilaiTengah + n - 1)
                    {
                        Console.Write(angka+"\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                    angka += 2;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
