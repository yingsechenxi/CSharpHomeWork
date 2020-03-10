﻿using System;

namespace JudgeShape
{
    public static class CreateShapeFactory
    {
        public static Shape CreateShape(int shapeType)
         {
            Shape shape = null;
            Random rd = new Random();
            double a = rd.Next(1,100);
            double b = rd.Next(1,100);
            double c = rd.Next(1,100);
            switch (shapeType)
             {
                 case 1:                    
                    shape = new Square(a);
                     break;
                 case 2:
                     shape = new Rectangle(a,b);
                    break;
                 case 3:
                     shape = new Triangle(a,b,c);
                    break;
                 default:
                     break;
             } 
             return shape;
         }
    }
    class Program
    {               
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Random rd = new Random();
                int x = rd.Next(1, 4);
                Shape shape = CreateShapeFactory.CreateShape(x);
                shape.CalculateArea();
            }
            while (true) ;
        }
    }
}
