// See https://aka.ms/new-console-template for more information
static long Factorial(int n)
{
    long result=1;

    for (int  i=n; i > 0; i--)
    {
        result= result*i;
    }
    return result;
}

Console.WriteLine("Enter a number");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Factorial of {n} is {Factorial(n)}");