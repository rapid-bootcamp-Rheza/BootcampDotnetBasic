using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic2
{
    public class Logic2Soal4
    {
        public Logic2Soal4()
        {
        }
        public static void Cetak4(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int angka = 1;
                int angka1 = 1; 
                for (int j = 0; j < n; j++)
                {
                    if (i==0||j==0||i==n-1||j==n-1||i==n/2||j==n/2)
                    {
                        Console.Write(angka + "\t");
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
