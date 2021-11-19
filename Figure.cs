using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    public class Figure:IMove
    {
       public string colour;
       public string condition;
       public virtual void move()
        {
            Console.WriteLine("Движется вправо");
        }
       
    }
}
