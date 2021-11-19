using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    public class Point : Figure, IChange
    {
         public override void move()
        {
            Console.WriteLine("Движется влево");
        }
        public Point(string colour, string condition)
        {
            this.colour = colour;
            this.condition = condition;
        }
        public void changecolour(string s)
        {
            colour = s;
        }
    }
}
