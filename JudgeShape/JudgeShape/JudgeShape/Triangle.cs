using System;
using System.Collections.Generic;
using System.Text;

namespace JudgeShape
{
    public class Triangle:Shape
    {        
        public Triangle(double x, double y,double z)
        {
            if (x*y*z<0 || y + z < x || x + z < y || x + y < z)
            {
                Console.WriteLine("It's not a legal triangle!");
            }
            else
            { 
                this.a = x;
                this.b = y;
                this.c = z;
                isRight = true;                               
            }
        }
        public override void CaculateArea()
        {
            if (isRight)
            {
                double p = (a + b + c)/2;
                double area = System.Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine(area);
            }                
        }
    }
}
