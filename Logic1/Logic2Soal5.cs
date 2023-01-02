using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic2
{
    public class Logic2Soal5
    {
        public Logic2Soal5() { }
        public static void Cetak5(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int angka = 1;
                int angka1 = 1;
                for (int j = 0; j < n; j++)
                {
                    if(i + j >= n-1 && i-j <= 0 || i-j>=0 && i + j <= n - 1)
                    {
                        Console.Write(angka+"\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                    int sum = angka + angka1;
                    angka = angka1;
                    angka1 = sum;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
