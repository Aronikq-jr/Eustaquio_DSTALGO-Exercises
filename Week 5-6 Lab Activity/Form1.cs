namespace BigONotation;

public partial class Form1 : Form
{
    long counter = 0;
    string sample = "";

    public Form1()
    {
        InitializeComponent();

        btnConst1.Click += RunConst1;
        btnConst2.Click += RunConst2;
        btnConst3.Click += RunConst3;

        btnLog1.Click += RunLog1;
        btnLog2.Click += RunLog2;
        btnLog3.Click += RunLog3;

        btnLin1.Click += RunLin1;
        btnLin2.Click += RunLin2;
        btnLin3.Click += RunLin3;

        btnQuad1.Click += RunQuad1;
        btnQuad2.Click += RunQuad2;
        btnQuad3.Click += RunQuad3;

        btnExp1.Click += RunExp1;
        btnExp2.Click += RunExp2;
        btnExp3.Click += RunExp3;
    }

    bool ReadNumber(TextBox box, Label output, out int number)
    {
        if (!int.TryParse(box.Text, out number) || number < 0)
        {
            output.Text = "Enter a whole number (0 or more)";
            return false;
        }
        return true;
    }

    bool ReadText(TextBox box, Label output)
    {
        if (box.Text == "")
        {
            output.Text = "Type something first";
            return false;
        }
        return true;
    }

    void RunConst1(object? sender, EventArgs e)
    {
        if (!ReadNumber(txtConst1, lblConst1, out int n)) return;

        if (n % 2 == 0)
        {
            lblConst1.Text = n + " is even";
        }
        else
        {
            lblConst1.Text = n + " is odd";
        }
    }

    void RunConst2(object? sender, EventArgs e)
    {
        if (!ReadText(txtConst2, lblConst2)) return;

        lblConst2.Text = "First letter: " + txtConst2.Text[0];
    }

    void RunConst3(object? sender, EventArgs e)
    {
        if (!ReadNumber(txtConst3, lblConst3, out int n)) return;

        lblConst3.Text = "Last digit: " + (n % 10);
    }

    void RunLog1(object? sender, EventArgs e)
    {
        if (!ReadNumber(txtLog1, lblLog1, out int n)) return;

        int steps = 0;
        while (n > 1)
        {
            n = n / 2;
            steps++;
        }

        lblLog1.Text = "Halvings: " + steps;
    }

    void RunLog2(object? sender, EventArgs e)
    {
        if (!ReadNumber(txtLog2, lblLog2, out int n)) return;

        int digits = 0;
        if (n == 0)
        {
            digits = 1;
        }

        while (n > 0)
        {
            n = n / 10;
            digits++;
        }

        lblLog2.Text = "Digits: " + digits;
    }

    void RunLog3(object? sender, EventArgs e)
    {
        if (!ReadNumber(txtLog3, lblLog3, out int n)) return;

        if (n == 0)
        {
            lblLog3.Text = "Binary: 0";
            return;
        }

        string binary = "";
        while (n > 0)
        {
            binary = (n % 2).ToString() + binary;
            n = n / 2;
        }

        lblLog3.Text = "Binary: " + binary;
    }

    void RunLin1(object? sender, EventArgs e)
    {
        if (!ReadNumber(txtLin1, lblLin1, out int n)) return;

        if (n > 1000000)
        {
            lblLin1.Text = "Max is 1,000,000";
            return;
        }

        long sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = sum + i;
        }

        lblLin1.Text = "Sum: " + sum;
    }

    void RunLin2(object? sender, EventArgs e)
    {
        if (!ReadText(txtLin2, lblLin2)) return;

        string text = txtLin2.Text.ToLower();
        int vowels = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if ("aeiou".Contains(text[i]))
            {
                vowels++;
            }
        }

        lblLin2.Text = "Vowels: " + vowels;
    }

    void RunLin3(object? sender, EventArgs e)
    {
        if (!ReadText(txtLin3, lblLin3)) return;

        string text = txtLin3.Text;
        string reversed = "";

        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversed = reversed + text[i];
        }

        lblLin3.Text = "Reversed: " + reversed;
    }

    void RunQuad1(object? sender, EventArgs e)
    {
        if (!ReadNumber(txtQuad1, lblQuad1, out int n)) return;

        if (n < 1 || n > 15)
        {
            lblQuad1.Text = "Enter 1 to 15";
            return;
        }

        string result = "";
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                result = result + "* ";
            }
            result = result + Environment.NewLine;
        }

        lblQuad1.Text = result;
    }

    void RunQuad2(object? sender, EventArgs e)
    {
        if (!ReadText(txtQuad2, lblQuad2)) return;

        string text = txtQuad2.Text;

        for (int i = 0; i < text.Length; i++)
        {
            for (int j = i + 1; j < text.Length; j++)
            {
                if (text[i] == text[j])
                {
                    lblQuad2.Text = "Duplicate letter: " + text[i];
                    return;
                }
            }
        }

        lblQuad2.Text = "No duplicate letters";
    }

    void RunQuad3(object? sender, EventArgs e)
    {
        if (!ReadNumber(txtQuad3, lblQuad3, out int n)) return;

        char[] digits = n.ToString().ToCharArray();

        for (int i = 0; i < digits.Length - 1; i++)
        {
            for (int j = 0; j < digits.Length - 1 - i; j++)
            {
                if (digits[j] > digits[j + 1])
                {
                    char temp = digits[j];
                    digits[j] = digits[j + 1];
                    digits[j + 1] = temp;
                }
            }
        }

        lblQuad3.Text = "Sorted digits: " + new string(digits);
    }

    long Fib(int n)
    {
        counter++;

        if (n <= 1)
        {
            return n;
        }

        return Fib(n - 1) + Fib(n - 2);
    }

    void Hanoi(int n)
    {
        if (n == 0)
        {
            return;
        }

        Hanoi(n - 1);
        counter++;
        Hanoi(n - 1);
    }

    void MakeStrings(int length, int position)
    {
        if (position == length)
        {
            counter++;
            return;
        }

        MakeStrings(length, position + 1);
        MakeStrings(length, position + 1);
    }

    long Grains(int square)
    {
        counter++;

        if (square == 1)
        {
            return 1;
        }

        return Grains(square - 1) + Grains(square - 1);
    }

    void MakeCombos(string word, int position, string current)
    {
        if (position == word.Length)
        {
            counter++;

            if (counter <= 5)
            {
                sample = sample + "[" + current + "] ";
            }
            return;
        }

        MakeCombos(word, position + 1, current);
        MakeCombos(word, position + 1, current + word[position]);
    }
    void RunExp1(object? sender, EventArgs e)
    {
        if (!ReadNumber(txtExp1, lblExp1, out int n)) return;

        if (n < 1 || n > 26)
        {
            lblExp1.Text = "Enter 1 to 26";
            return;
        }

        long totalCodes = 1L << n;
        long secretCode = totalCodes - 1;
        long attempts = 0;

        for (long guess = 0; guess < totalCodes; guess++)
        {
            attempts++;

            if (guess == secretCode)
            {
                break;
            }
        }

        lblExp1.Text = n + "-bit lock cracked in " + attempts + " attempts";
    }

    void RunExp2(object? sender, EventArgs e)
    {
        if (!ReadNumber(txtExp2, lblExp2, out int n)) return;

        if (n < 1 || n > 25)
        {
            lblExp2.Text = "Enter 1 to 25";
            return;
        }

        counter = 0;
        long grains = Grains(n);

        lblExp2.Text = "Grains on square " + n + ": " + grains + " | Calls: " + counter;
    }

   
    void RunExp3(object? sender, EventArgs e)
    {
        if (!ReadText(txtExp3, lblExp3)) return;

        string word = txtExp3.Text;

        if (word.Length > 20)
        {
            lblExp3.Text = "Max is 20 letters";
            return;
        }

        counter = 0;
        sample = "";
        MakeCombos(word, 0, "");

        lblExp3.Text = "Combinations: " + counter + " | First few: " + sample;
    }

    private void tabPage1_Click(object sender, EventArgs e)
    {

    }
}
