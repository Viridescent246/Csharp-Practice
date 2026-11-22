// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter another number");
double num2 = double.Parse(Console.ReadLine());

double sum = num1 + num2;
double difference = num1-num2;
double product = num1*num2;

Console.WriteLine($"sum= {sum}\ndifference= {difference}\nproduct= {product}");
