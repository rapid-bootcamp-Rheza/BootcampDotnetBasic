﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.CustomType
{
    public class SampleClass
    {
        public int dataX;
        public int dataY;

        //constructor
        public SampleClass()
        {

        }
        //Contrustor 2
        public SampleClass(int x , int y)
        {
            dataX = x;
            dataY = y;
        }

        public override string ToString()
        {
            return "SampleClass [x :" + dataX + ", y: " + dataY + "]";
        }
    }
}
