// See https://aka.ms/new-console-template for more information
static bool IsPrime(int n)
{
    double half= n/2.0;
    half= Math.Round(half, 0);
    
    for(double i=half; i>1; i--)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    if (n==0 || n == 1 || n<0)
    {
        return false;
    }
    else
    {
        return true;
    }
}

Console.WriteLine("Enter a number");
int num = int.Parse(Console.ReadLine());

if (IsPrime((num)))
{
    Console.WriteLine($"{num} is prime");
}
else
{
    Console.WriteLine($"{num} is not prime");
}