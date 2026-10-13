// Q14
// 1. O(1) — Simple Interest: Calculate simple interest using given the principal, rate, and time
Console.WriteLine("1. ");
double interest = 0;

Console.WriteLine("Type your principal");
double principal = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Type your rate");
double rate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Type your time");
double time = Convert.ToDouble(Console.ReadLine());

interest = principal * rate * time;
Console.WriteLine("Your interest: " + interest);


// 2. O(log n) — Find a Sorted Number: Use binary search to find a target number.
/*
Console.WriteLine("");
Console.WriteLine("2. ");


Console.WriteLine("Type total amount:");
int nums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type your target number:");
int target = Convert.ToInt32(Console.ReadLine());

int low = 0;
while (low <= nums)
{
    int mid = low + (nums - low) / 2;
    if (mid == target)
    {
        return mid;
    }
    else if (mid < target)
    {
        low = mid + 1;
    }
    else
    {
        nums = mid - 1;
    }
}
*/
// 3. O(n) — Search for a Character: Check each character in a string for a target letter. 

Console.WriteLine("");
Console.WriteLine("3. ");
Console.WriteLine("Type your word: ");
string text = Convert.ToString(Console.ReadLine());
Console.WriteLine("Type your letter: ");
char chartarget = Convert.ToChar(Console.ReadLine());
bool found = false;
int index = -1;

for (int i = 0; i < text.Length; i++)
{
    if (text[i] == chartarget)
    {
        found = true;
        index = i;
    }
}

if (found)
{
    Console.WriteLine("Character " + chartarget + " found at position " + index);
}
else
{
    Console.WriteLine("Character " + chartarget + " not found.");
}



// 4. O(n²) — Equal Number Pairs: Find all pairs of equal numbers using nested loops.
Console.WriteLine("");
Console.WriteLine("4. ");
Console.WriteLine("Type your first number pair");
int numbers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type your second number pair");
int numbers2 = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < numbers; i++)
{
    for (int j = 0; j < numbers2; j++)
    {
        if (i == j)
        {
            Console.WriteLine("Equal pair found! " + i + ", " + j);
        }
    }
}


// 5. O(2ⁿ) — Answer Patterns: Generate all possible A/B/C? No—use two choices, A/B, for each of four questions. 

