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
            int kolom = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i==0 && j == n/2 || j==0 && i == n/2)
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
