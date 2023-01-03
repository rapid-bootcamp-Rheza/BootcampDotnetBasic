using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic2
{
    public class Logic2soal7
    {
        public Logic2soal7() { }
        public static void Cetak7(int n)
        {
            int nilaiTengah = n / 2;
            int angka = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= 1 || i <= 1|| i >= n-2 || j>= n-2)
                    {
                        Console.Write(angka);
                    }
                    else if (j >= i && j<n-i)
                    {

                    }
                }
            }
        }
    }
}
