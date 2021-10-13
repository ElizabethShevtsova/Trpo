using System;
using System.Collections.Generic;

namespace ShevtsovaLab1
{
    class Program
    {

        class A
        {

            protected List<float> x;
            public float[] Linear(float a, float b)
            {

                if (a == 0)
                {
                    return null;
                }

                return x = new List<float> { -b / a };

            }
           
        }
        class B : A
        {
            protected float Discriminant(float a, float b, float c)
            {
                return (float)Math.Pow(b, 2) - (4 * a * c);
            }

           
            public float[] Solution(float a, float b, float c)
            {
                if (a == 0)
                {
                    return Linear(a, b);
                }
                float d = Discriminant(a, b, c);

                if (d < 0)
                {
                    return null;
                }

                if (d == 0)
                {
                    return x = new List<float> { -b / (2 * a) };
                }


                d = (float)Math.Sqrt(d);
                return x = new List<float> { (-b + d) / (2 * a), (-b - d) / (2 * a) };



            }
           
           
            public object a;
        }

        class C : B
        {
            public object b;
            public object c;
            public object d;

        }
        static void Main(string[] args)
        {
            A a1 = new A { };
            A a2 = new A { };
            A a3 = new A { };
            B b4 = new B { };
            C c5 = new C { };
            A q = new A { };
            B k = new B { };
            b4.a = a1;
            c5.a = a1;
            c5.b = a2;
            c5.c = a3;
            c5.d = b4;

            k.Solution(5, 6, 3);
        }
    }
}
