﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision
{
    public class Scalar
    {
        public static Scalar BgrWhite => new Scalar(255, 255, 255);
        public static Scalar BgrGray => new Scalar(128, 128, 128);
        public static Scalar BgrBlack => new Scalar(0, 0, 0);
        public static Scalar BgrRed => new Scalar(0, 0, 255);
        public static Scalar BgrGreen => new Scalar(0, 255, 0);
        public static Scalar BgrBlue => new Scalar(255, 0, 0);
        public static Scalar BgrMagenta => new Scalar(255, 0, 255);
        public static Scalar BgrYellow => new Scalar(0, 255, 255);
        public static Scalar BgrCyan => new Scalar(255, 255, 0);

        public double Value1;
        public double Value2;
        public double Value3;
        public double Value4;

        public Scalar(double val1 = 0, double val2 = 0, double val3 = 0, double val4 = 255)
        {
            Value1 = val1;
            Value2 = val2;
            Value3 = val3;
            Value4 = val4;
        }

        public static Scalar All(double val)
        {
            return new Scalar(val, val, val, val);
        }
    }
}
