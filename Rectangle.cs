using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class Rectangle:Point
    {
        public Rectangle(string colour, string condition) : base(colour, condition)
        {
        }
         public override void move()
        {
            Console.WriteLine("Движется по вертикали");
        }

         public void changecolour(string s)
        {
            colour = s;
        }
      
    }
}
