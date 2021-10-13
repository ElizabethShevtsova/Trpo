using System;
using System.Collections.Generic;
using System.Text;

namespace Shevtsova
{
    class Line
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
        public object a;
    }
}
