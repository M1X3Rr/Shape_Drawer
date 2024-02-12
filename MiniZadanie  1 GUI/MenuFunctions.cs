/*
     FUNCTIONS CONCERNING MENU FUNCTIONS
*/

using System;
using System.Globalization;

public partial class Program
{
    static void Start()
    {
        while (true)
        {
            Console.WriteLine("Pleas select the type of the to create shape:");
            Console.WriteLine("a) triangle\nb) square\ne) exit\n");

            switch (Console.ReadKey().KeyChar)
            {
                case 'a':
                    CreateTriangleShape();
                    break;
                case 'b':
                    CreateSquareShape();
                    break;

                case 'e':
                    Exit();
                    return;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Input! Pleas chose a valid option!");
                    Console.ReadLine();
                    break;
            }
            Console.Clear();
        }

    }


    static void Exit()
    {
        Console.WriteLine("\n\nPress enter to exit...");
        Console.Clear();
        Console.WriteLine("Exiting...");
    }

    static void Cancel()
    {
        Console.Clear();
        int j = 3;

        for (int i = 0; i < 3; i++)
        {
            Console.Clear();
            Console.WriteLine($"Canceling... {j}");
            Thread.Sleep(500);
            j--;
        }
        
        Console.Clear();
    }
}
