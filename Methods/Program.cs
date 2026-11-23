// See https://aka.ms/new-console-template for more information
static bool IsEven(int num)
{
    if (num % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

static double Max3(double num1, double num2, double num3)
{
    double largest=num1;

    if (largest < num2)
    {
        largest=num2;
    } 
    if (largest < num3)
    {
        largest=num3;
    }

    return largest;
}

// Console.WriteLine("Enter a number");
// int number = int.Parse(Console.ReadLine());

// if (IsEven(number))
// {
//     Console.WriteLine($"{number} is even");
// }
// else
// {
//     Console.WriteLine($"{number} is odd");
// }

Console.WriteLine("Enter a number");
double num1= double.Parse(Console.ReadLine());
Console.WriteLine("Enter a number");
double num2= double.Parse(Console.ReadLine());
Console.WriteLine("Enter a number");
double num3= double.Parse(Console.ReadLine());

Console.WriteLine($"Largest number entered is {Max3(num1, num2, num3)}");