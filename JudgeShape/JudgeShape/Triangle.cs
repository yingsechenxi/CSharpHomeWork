using System;
using System.Collections.Generic;
using System.Text;

namespace JudgeShape
{
    public class Triangle:Shape
    {        
        public Triangle(double x, double y,double z)
        {
            if (x<=0||y<=0||z<=0 || y + z < x || x + z < y || x + y < z)
            {
                Console.WriteLine("It's not a legal triangle!");
            }
            else
            { 
                this.a = x;
                this.b = y;
                this.c = z;
                base.isRight = true;                               
            }
        }
        public override void CalculateArea()
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
