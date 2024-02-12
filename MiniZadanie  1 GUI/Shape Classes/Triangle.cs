using System;

namespace Shapes
{
    internal class Triangle : Shape
    {
        private int height;
        public Triangle(int height)
        {
            this.height = height;
        }
        public void DrawPyramid()
        {
            for (int i = 1; i <= this.height; i++)
            {
                // Print spaces to center the pyramid
                for (int j = 0; j < this.height - i; j++)
                {
                    Console.Write(" ");
                }

                // Print asterisks for the pyramid
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public void DrawInvPyramid()
        {
            for (int i = this.height; i >= 1; i--)
            {
                // Print spaces to center the inverted pyramid
                for (int j = 0; j < this.height - i; j++)
                {
                    Console.Write(" ");
                }

                // Print asterisks for the inverted pyramid
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public void DrawRhombus()
        {
            // upper part
            for(int i = 1; i<= this.height; i++)
            {
                // Print spaces to center the pyramid
                for (int j = 0; j < this.height - i; j++)
                {
                    Console.Write(" ");
                }

                // Print asterisks for the pyramid
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // lower part
            for (int i = this.height-1; i >= 1; i--)
            {
                // Print spaces to center the pyramid
                for (int j = 0; j < this.height - i; j++)
                {
                    Console.Write(" ");
                }

                // Print asterisks for the pyramid
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

    }
}