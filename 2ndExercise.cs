// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Activity 1. ");
        Console.WriteLine("Add your name: ");
        string nameInput = Console.ReadLine();
        Console.WriteLine("What is your course?: ");
        string courseInput = Console.ReadLine();
        Console.WriteLine("What is your year level?: ");
        string yearInput = Console.ReadLine();
        Console.WriteLine("What is your section?: ");
        string sectionInput = Console.ReadLine();

        Console.WriteLine("== SUMMARY ==");
        Console.WriteLine("Name: " + nameInput);
        Console.WriteLine("Course: " + courseInput);
        Console.WriteLine("Year: " + yearInput);
        Console.WriteLine("Section: " + sectionInput);
        
        Console.WriteLine("");
        Console.WriteLine("Activity 2. ");
        Console.WriteLine("Input Number 1: ");
        double numInput1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input Number 2: ");
        double numInput2 = Convert.ToDouble(Console.ReadLine());
        double addFinal = numInput1 + numInput2;
        double subFinal = numInput1 - numInput2;
        double multFinal = numInput1 * numInput2;
        double divFinal = numInput1 / numInput2;
        Console.WriteLine("== SUMMARY ==");
        Console.WriteLine("Addition:" + addFinal);
        Console.WriteLine("Subtraction:" + subFinal);
        Console.WriteLine("Multiplication:" + multFinal);
        Console.WriteLine("Division:" + divFinal);

        Console.WriteLine("");
        Console.WriteLine("Activity 3. ");
        Console.WriteLine("Length: ");
        int Length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Width: ");
        int Width = Convert.ToInt32(Console.ReadLine());
        int Area = Length * Width;
        Console.WriteLine("Area is: " + Area);

        Console.WriteLine("");
        Console.WriteLine("Activity 4. ");

    }
}
