using System;
using System.Collections.Generic;
using System.Text;

namespace inheritex2
{
        class shape
       {

        public int Sides { get; set; }
        public string Color { get; set; }

        public virtual void Area()
        {
            Console.WriteLine("Formula for specific shape ");
        }

        public shape(int s, string color)
        {
            Sides = s;
            this.Color = color;
        }
    }
}
