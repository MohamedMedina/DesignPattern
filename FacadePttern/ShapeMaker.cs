using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePttern
{
   public  class ShapeMaker
    {
        private Shape circle;
        private Shape square;
        private Shape triangle;
        public ShapeMaker()
        {
            Circle circle = new Circle();
            Triangele triangele = new Triangele();
            Square square = new Square();

        }
        public void drawCircle()
        {

            circle.draw();
        }
        public void drawTriangle()
        {

            triangle.draw();
        }
        public void drawSquare()
        {

            square.draw();
        }


    }
}
