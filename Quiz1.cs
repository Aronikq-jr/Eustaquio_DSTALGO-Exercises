//First Problem (Input anything then display)
Console.WriteLine ("Type something!");
string userInput1 = Console.ReadLine();
Console.WriteLine ("Type again!");
string userInput2 = Console.ReadLine();
Console.WriteLine ("Type one more time!");
string userInput3 = Console.ReadLine();
Console.WriteLine ("How about another one?");
string userInput4 = Console.ReadLine();
Console.WriteLine ("Last one!");
string userInput5 = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("You typed:");
Console.WriteLine(userInput1);
Console.WriteLine(userInput2);
Console.WriteLine(userInput3);
Console.WriteLine(userInput4);
Console.WriteLine(userInput5);
Console.WriteLine("===============");

//Second Problem (Paper)
Console.WriteLine("");
Console.WriteLine ("Rectangle Length:");
Double recLength = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Rectangle Width:");
Double recWidth = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Circle Radius:");
Double cirRadius = Convert.ToDouble(Console.ReadLine());

Double recArea = recLength * recWidth;
Double recPerim = (recLength + recWidth) * 2;
Double cirArea = (cirRadius * cirRadius) * 3.14;
Double cirCircum = (2 * 3.14 * cirRadius);

Console.WriteLine(recArea);
bool isGreater = (recArea > cirArea);
bool isGreater2 = (recPerim > 100);
bool isGreater3 = (cirArea > 500);

Console.WriteLine("======== SUMMARY =======");
Console.WriteLine("Rectangle Area " + recArea);
Console.WriteLine("Rectangle Perimeter " + recPerim);
Console.WriteLine("Circle Area " + cirArea);
Console.WriteLine("Circle Circumference " + cirCircum);
Console.WriteLine("Rectangle Area > Circle Area: " + isGreater); 
Console.WriteLine("Rectangle Perimeter > 100: " + isGreater2); 
Console.WriteLine("Circle Area > 500: " + isGreater3); 
