using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using core;

namespace Shevtsova
{
    class ShevtsovaLog : LogAbstract, LogInterface
    {
        private static ShevtsovaLog i = null;

        public static ShevtsovaLog I()
        {
            if (i == null)
            {
                i = new ShevtsovaLog();
            }
            return i;
        }
        private ShevtsovaLog() { }

        List<string> logs = new List<string>();
      
        public LogInterface log(string str)
        {
            logs.Add(str);
            return this;
        }

        public LogInterface write()
        {
            writeConsole(logs.ToArray());
            return this;
        }

       

        

       
    }
}
