using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic2
{
    public class Logic2Soal2
    {
        public Logic2Soal2()
        {
        }
        public static void Cetak2(int n) 
        {
            for (int i = 0; i < n; i++)
            {
                int angka = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i == 0||j==0 || i==n-1|| j==n-1)
                    {
                        Console.Write(angka + "\t");
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
