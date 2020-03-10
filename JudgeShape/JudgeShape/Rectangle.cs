using System;
using System.Collections.Generic;
using System.Text;

namespace JudgeShape
{
    public class Rectangle : Shape
    {
        public Rectangle(double x, double y)
        {
            if (x<=0||y<=0||x==y)
            {
                Console.WriteLine("It's not a legal rectangle!");
             }
            else
            {
                this.a = x;
                this.b = y;
                base.isRight = true;
            }
        }
        public override void CalculateArea()
        {
            if(isRight)
            {
                Console.WriteLine(a * b);
            }            
        }
    }
}
