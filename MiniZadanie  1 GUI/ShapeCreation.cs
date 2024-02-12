/*
     FUNCTIONS CONCERNING SHAPE CREATION
*/

using System;
using Shapes;

public partial class Program
{

    // Cration Methods

    static void CreateSquareShape()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Chose a shape:");
            Console.WriteLine("a) square \nb) rectangle \ne) back");

            switch (Console.ReadKey().KeyChar)
            {
                case 'a':
                    // square logic
                    CreateSquare();
                    break;
                case 'b':
                    // rectangle logic
                    CreateRectangle();
                    break;

                case 'e':
                    Cancel();
                    return;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Input! Pleas chose a valid option!");
                    Console.ReadLine();
                    break;
            }
        }
    }
    static void CreateTriangleShape()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Chose a shape:");
            Console.WriteLine("a) pyramid \nb) inverted pyramid \nc) rhombus \ne) back");

            switch (Console.ReadKey().KeyChar)
            {
                case 'a':
                    // pyramid logic
                    CreatePyramid();
                    break;
                case 'b':
                    // inverted pyramid logic
                    CreateInvPyramid();
                    break;
                case 'c':
                    // rhombus logic
                    CreateRhombus();
                    break;

                case 'e':
                    Cancel();
                    return;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Input! Pleas chose a valid option!");
                    Console.ReadLine();
                    break;
            }
        }
    }


    // SQUARE SHAPES
    static void CreateSquare()
    {
        Console.Clear();
        int height = GetParameters("Please input the height (or type 'cancel' to exit):");

        if (height == -1)
        {
            Console.WriteLine("Operation canceled.");
            return; // exit the method
        }

        Square square = new Square(height, height);
        Console.WriteLine($"Square created with height: {height}\n");
        square.DrawSquare();

        Console.WriteLine("\nPress any key to continue");
        Console.ReadLine();
    }

    static void CreateRectangle()
    {
        Console.Clear();
        int height = GetParameters("Please input the height (or type 'cancel' to exit):");
        int width = GetParameters("Please input the width (or type 'cancel' to exit):");

        if (height == -1 || width == -1)
        {
            Console.WriteLine("Operation canceled.");
            return; // exit the method
        }

        Square rectangle = new Square(width, height);
        Console.WriteLine($"Rectangle created with height: {height} and width: {width}\n");
        rectangle.DrawRectangle();

        Console.WriteLine("\nPress any key to continue");
        Console.ReadLine();
    }

    // TRIANGLE SHAPES
    static void CreatePyramid()
    {
        Console.Clear();
        int height = GetParameters("Please input the height (or type 'cancel' to exit):");

        if (height == -1)
        {
            Console.WriteLine("Operation canceled.");
            return; // exit the method
        }

        Triangle pyramid = new Triangle(height);
        Console.WriteLine($"Pyramid created with height: {height}\n");
        pyramid.DrawPyramid();

        Console.WriteLine("\nPress any key to continue");
        Console.ReadLine();
    }
    static void CreateInvPyramid()
    {
        Console.Clear();
        int height = GetParameters("Please input the height (or type 'cancel' to exit):");

        if (height == -1)
        {
            Console.WriteLine("Operation canceled.");
            return; // exit the method
        }

        Triangle invPyramid = new Triangle(height);
        Console.WriteLine($"Inverted pyramid created with height: {height}\n");
        invPyramid.DrawInvPyramid();

        Console.WriteLine("\nPress any key to continue");
        Console.ReadLine();
    }
    static void CreateRhombus()
    {
        Console.Clear();
        int height = GetParameters("Pleas input the height, must odd (or type 'cancel' to exit):");

        if (height == -1)
        {
            Console.WriteLine("Operation canceled.");
            return; // exit the method
        }
        else if (height%2 == 0)
        {
            Console.Clear();
            Console.WriteLine("Pleas input an odd number");
            Console.ReadLine();
            return; // exit the method
        }

        Triangle rhombus = new Triangle(height);
        Console.WriteLine($"Rhombus created with height: {height}\n");
        rhombus.DrawRhombus();

        Console.WriteLine("\nPress any key to continue");
        Console.ReadLine();
    }


    // getter for height and width
    static int GetParameters(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            string response = Console.ReadLine();

            if (response.ToLower() == "cancel")
            {
                return -1; // return a special value to indicate cancel
            }

            if (Int32.TryParse(response, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}