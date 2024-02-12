using System;

namespace Shapes
{
    internal class Shape
    {
        private int width, height;

        public Shape(int width, int height) 
        { 
            this.width = width;
            this.height = height;
        }

        public Shape()
        {
            this.width = 1;
            this.height = 1;
        }
    }
}
