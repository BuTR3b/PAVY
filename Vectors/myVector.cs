using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class myVector
    {
        public double X;
        public double Y;
        public double Z;

        public myVector(double X, double Y, double Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;

        }

        public double get_length(double X, double Y, double Z)
        {
            double length;
            length = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
            return length;
        }

        public static double[] operator +(myVector a, myVector b)
        {
            double[] nums = new double[3];
            nums[0] = a.X + b.X;
            nums[1] = a.Y + b.Y;
            nums[2] = a.Z + b.Z;
            return nums;
        }

        public static double[] operator -(myVector a, myVector b)
        {
            double[] nums = new double[3];
            nums[0] = a.X - b.X;
            nums[1] = a.Y - b.Y;
            nums[2] = a.Z - b.Z;
            return nums;
        }

        public static double operator *(myVector a, myVector b)
        {
            double num = 0;
            double[] nums = new double[3];
            nums[0] = a.X * b.X;
            nums[1] = a.Y * b.Y;
            nums[2] = a.Z * b.Z;
            for (int i = 0; i < 3; i++) 
            {
                num += nums[i];
            }
            return num;
        }
    }
}
