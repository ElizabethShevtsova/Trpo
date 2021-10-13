using System;
using System.Collections.Generic;

namespace ShevtsovaLab1
{
    class Program
    {

        class A
        {
        }
        class B : A
        {
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

          
        }
    }
}
