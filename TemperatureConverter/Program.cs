// See https://aka.ms/new-console-template for more information
static double CelsiusToFahrenheit(double c)
{
    return c*(9.0/5)+32;
}

static double FahrenheitToCelsius(double f, int decimals = 1)
{
    return Math.Round((f-32)*(5.0/9), decimals);
}

// Console.WriteLine("Enter temperature in Celsius");
// double celsiusTemp = double.Parse(Console.ReadLine());

Console.WriteLine("Enter temperature in Fahrenheit");
double fahrenheitTemp = double.Parse(Console.ReadLine());

Console.WriteLine($"{fahrenheitTemp} degrees Fahrenheit = {FahrenheitToCelsius(fahrenheitTemp, 2)} Celsius");