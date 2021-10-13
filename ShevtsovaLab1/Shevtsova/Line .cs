using System;
using System.Collections.Generic;
using System.Text;

namespace Shevtsova
{
    class Line
    {
        protected List<float> x;
        public List<float> Linear(float a, float b)
        {

            if (a == 0)
            {
                throw new ShevtsovaException("Определено, что такое уравнение не существует");
            }
            ShevtsovaLog.I().log("Определено, что это линейное уравнение");
            return x = new List<float> { -b/a };
        }
    }
}
