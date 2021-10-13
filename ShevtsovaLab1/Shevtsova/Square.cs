using System;
using System.Collections.Generic;
using System.Text;
using core;

namespace Shevtsova
{
    class Square : Line, EquationInterface
    {
        protected float Discriminant(float a, float b, float c)
        {
            return (float)Math.Pow(b, 2) - (4 * a * c);
        }
        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                return Linear(b, c);
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

    }
}
