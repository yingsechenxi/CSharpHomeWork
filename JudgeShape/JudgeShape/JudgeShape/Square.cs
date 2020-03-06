using System;
using System.Collections.Generic;
using System.Text;

namespace JudgeShape
{
    public class Square:Shape
    {
        public Square(double x)
        {
            if (x < 0 )
            {
                Console.WriteLine("It's not a legal square!");
            }
            else
            {
                this.a = x;
                isRight = true;
            }
        }
        public override void CaculateArea()
        {
            if(isRight)
            {
                Console.WriteLine(a * a);
            }            
        }
    }
}
