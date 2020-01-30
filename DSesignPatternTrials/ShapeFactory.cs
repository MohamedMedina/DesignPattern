using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class ShapeFactory
    {

        public ShapeFactory()
        {
            FactoryPattern factoryPattern;
        }
        public Shape GetShape( String ShapeType)
        {

            if (ShapeType == null)
            {

                return null;
            }
            else if (ShapeType.Equals("circle"))
            {
                return new Circle();
            }
            else if (ShapeType.Equals("square"))
            {
                return new Square();
            }
            else if (ShapeType.Equals("triangle"))
            {
                return new Triangle();
            }
            return null;
        }
    }
}
