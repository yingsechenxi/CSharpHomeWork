using System;
using System.Collections.Generic;
using System.Text;

namespace JudgeShape
{
    public class Square:Shape
    {
        public Square(double x)
        {
            if (x <=0 )
            {
                Console.WriteLine("It's not a legal square!");
            }
            else
            {
                this.a = x;
                base.isRight = true;
            }
        }
        public override void CalculateArea()
        {
            if(isRight)
            {
                Console.WriteLine(a * a);
            }            
        }
    }
}
