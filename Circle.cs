using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class Circle : Point
    {
        public Circle(string colour, string condition) : base(colour, condition)
        {
        }
        public override void move()
        {
            Console.WriteLine("Движется вниз");
        }
        }
    public void Square(int a, int b)
    {
        Console.WriteLine($"Square = {a * b}");
    }
}

