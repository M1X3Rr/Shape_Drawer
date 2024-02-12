using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : Shape
    {
        int width, height;

        public Square(int width, int height) : base(width, height)
        {
            this.width = width;
            this.height = height;
        }

        public void DrawSquare()
        {
            for(int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void DrawRectangle()
        {
            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
