using System;
using System.Collections.Generic;
using System.Text;

namespace JudgeShape
{
    public abstract class Shape
    {
        protected double a, b, c;
        public abstract void CalculateArea();
        protected bool isRight = false;
    }
}
