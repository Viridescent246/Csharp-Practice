// See https://aka.ms/new-console-template for more information
static Boolean IsEven(int num)
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

Console.WriteLine("Enter a number");
int number = int.Parse(Console.ReadLine());

if (IsEven(number))
{
    Console.WriteLine($"{number} is even");
}
else
{
    Console.WriteLine($"{number} is odd");
}
