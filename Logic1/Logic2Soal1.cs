﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic2
{
    public class Logic2Soal1
    {
        public Logic2Soal1()
        {
        }
        public static void CetakData(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int angka = 1;
                for (int j = 0; j < n; j++)
                {
                    if (i == j || i + j == n - 1)
                    {
                        Console.Write(angka + "\t");

                    }
                    else
                    {
                        Console.Write("\t");
                    }
                    
                }
                angka++;
                Console.WriteLine("\n");
            }
        }
    }
}
