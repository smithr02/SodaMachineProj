﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaRegister
    {
       public int orangeCount;
       public double orangePrice = 0.35;
       public int grapeCount;
       public double grapePrice = 0.60;
       public int lemonCount;
       public double lemonPrice = 0.06;

        public SodaRegister(int OC, int GC, int LC) //OC is orange count, GC is grape count, LC is lemon count. Passing thee in so they can be changed dynamically if need be.
        {
            this.orangeCount = OC;
            this.grapeCount = GC;
            this.lemonCount = LC;
        }
        
    }

}
