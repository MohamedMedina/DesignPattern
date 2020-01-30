using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Triangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("triangle");
        }
    }
}
