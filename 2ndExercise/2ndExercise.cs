// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Activity 1
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
        
        //Activity 2
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
        Console.WriteLine("Addition: " + addFinal);
        Console.WriteLine("Subtraction: " + subFinal);
        Console.WriteLine("Multiplication: " + multFinal);
        Console.WriteLine("Division: " + divFinal);

        //Activity 3
        Console.WriteLine("");
        Console.WriteLine("Activity 3. ");
        Console.WriteLine("Length: ");
        int Length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Width: ");
        int Width = Convert.ToInt32(Console.ReadLine());
        int Area = Length * Width;
        Console.WriteLine("Area is: " + Area);

        //Activity 4
        Console.WriteLine("");
        Console.WriteLine("Activity 4. ");
        Console.WriteLine("Prelim Grade: ");
        double Grade1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Midterm: ");
        double Grade2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Final: ");
        double Grade3 = Convert.ToDouble(Console.ReadLine());
        double avg = (Grade1 + Grade2 + Grade3) / 3;
        Console.WriteLine("Your Average Grade is: " + avg);

        //Activity 5
        Console.WriteLine("");
        Console.WriteLine("Activity 5. ");
        Console.WriteLine("Are you a Student? (true/false)");
        string isStudent = (Console.ReadLine());
        if (isStudent == "true")
        {
            Console.WriteLine("Status: Student");
        } 
        else 
        {
            Console.WriteLine("Status: Not Student");
        }

        //Activity 6
        Console.WriteLine("");
        Console.WriteLine("Activity 6. ");
        Console.WriteLine("What is your age?: ");
        int age = Convert.ToInt32((Console.ReadLine()));
        if (age >= 18)
        {
            Console.WriteLine("You are old enough!");
        }
        else 
        {
            Console.WriteLine("You are NOT old enough!");
        }

        //Activity 7
        Console.WriteLine("");
        Console.WriteLine("Activity 7. ");
        Console.WriteLine("What is your first name?");
        string firstName = (Console.ReadLine());
        Console.WriteLine("What is your last name?");
        string lastName = (Console.ReadLine());

        Console.WriteLine("Hi! Your full name is: " + firstName + " " + lastName);

        //Activity 8
        Console.WriteLine("");
        Console.WriteLine("Activity 8. ");
        Console.WriteLine("Product name: ");
        string product = (Console.ReadLine());
        Console.WriteLine("Price: ");
        int price = Convert.ToInt32((Console.ReadLine()));
        Console.WriteLine("Quantity: ");
        int qty = Convert.ToInt32((Console.ReadLine()));
        int total = price * qty;
        Console.WriteLine("The total cost of " + product + " is P" + total);
        
        //Activity 9
        Console.WriteLine("");
        Console.WriteLine("Activity 9. ");
        Console.WriteLine("Employee name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hours worked: ");
        int hours = Convert.ToInt32((Console.ReadLine()));
        Console.WriteLine("Hourly rate: ");
        int rate = Convert.ToInt32((Console.ReadLine()));
        int salary = hours * rate;
        Console.WriteLine("Salary is: P" + salary);

        //Activity 10
        Console.WriteLine("");
        Console.WriteLine("Activity 10. ");
        Console.WriteLine("Name: ");
        string studentName = Console.ReadLine();
        Console.WriteLine("Course: ");
        string course = Console.ReadLine();
        Console.WriteLine("Age: ");
        int urAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Year Level: ");
        int yearLevel = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Grade 1: ");
        int grade1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Grade 2: ");
        int grade2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Grade 3: ");
        int grade3 = Convert.ToInt32(Console.ReadLine());
        int average = (grade1 + grade2 + grade3) / 3;
        Console.WriteLine("--- STUDENT INFORMATION ---");
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Course: " + course);
        Console.WriteLine("Age: " + urAge);
        Console.WriteLine("Year Level: " + yearLevel);
        Console.WriteLine("Average Grade: " + average);
        if (urAge >= 18)
        {
            Console.WriteLine("Status: Student is 18 or older!");
        }
        else
        {
            Console.WriteLine("Status: Student is under 18!");
        }
    }
}
