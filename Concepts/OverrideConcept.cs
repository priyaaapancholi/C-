using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    class OverrideConcept
    {
        
     class Dimension
        {
            public const double pi = 3.14;
            protected int x, y;
           public  Dimension()
            {

            }

            public Dimension(int a, int b)
            {
                x = a;
                y = b;
            }

            public virtual double area()
            {
                return x * y;
            }
        }



        class circle:Dimension
        {
             public circle(int r): base(r,0)
            {

            }

            public override double area()
            {
                return pi * x * x;
            }

        }



        class Square : Dimension
        {
            public Square(int l) : base(l, 0)
            {

            }

            public override double area()
            {
                return x*x;
            }

        }


        static void Main()
        {
            Dimension c = new circle(7);
            Dimension s = new Square(3);
            Console.WriteLine("area of circle is:" + c.area() + "---------area of square is:" + s.area());
        }
}
}