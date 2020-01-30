using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
 public    class FactoryPattern
    {
       
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            
            Shape shape1  =    shapeFactory.GetShape("circle");

            shape1.draw();

            //
            Shape shape2 = shapeFactory.GetShape("square");

            shape2.draw();
            
            Shape shape3 = shapeFactory.GetShape("triangle");

            shape3.draw();

        }
    }
}
