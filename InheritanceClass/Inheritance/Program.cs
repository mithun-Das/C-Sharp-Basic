using System;

namespace Inheritance
{
    class InheritanceClassTest
    {
        public class Shape
        {
            protected int height;
            protected int width;


            public Shape()
            {
                Console.WriteLine("Inside Shape");
            }

            public void setHeight(int h)
            {
                height = h;
            }

            public void setWidth(int w)
            {
                width = w;
            }
        }

        public class CalculateRectangle : Shape
        {
            public CalculateRectangle()
            {
                Console.WriteLine("Inside CalculateRectangle");
            }

            public void showResult(int h, int w)
            {
                setHeight(h);
                setWidth(w);
                int result = height * width;
                Console.WriteLine(result);
            }
        }

        static void Main(string[] args)
        {
            CalculateRectangle getRectangleResult = new CalculateRectangle();
            //Shape setShape = new Shape();
            //getRectangleResult.showResult(2,3);
            //setShape = new CalculateRectangle();
            //setShape = getRectangleResult;
            //setShape.showResult(2,3);
            //setShape.showResult(2,3);
            Console.ReadKey();
        }
    }
}
