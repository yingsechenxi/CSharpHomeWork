using System;
using System.Collections.Generic;
using System.Text;

namespace JudgeShape
{
    public class Rectangle : Shape
    {
        public Rectangle(double x, double y)
        {
            if (x*y < 0)
            {
                Console.WriteLine("It's not a legal rectangle!");
             }
            else
            {
                this.a = x;
                this.b = y;
                isRight = true;
            }
        }
        public override void CaculateArea()
        {
            if(isRight)
            {
                Console.WriteLine(a * b);
            }            
        }
    }
}
