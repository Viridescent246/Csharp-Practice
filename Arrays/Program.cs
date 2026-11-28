// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter five numbers");
double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
double num3 = double.Parse(Console.ReadLine());
double num4 = double.Parse(Console.ReadLine());
double num5 = double.Parse(Console.ReadLine());

double[] array = {num1, num2, num3, num4, num5};
double sum = 0;
double largest = num1;
double smallest = num5;

Console.WriteLine($"Numbers entered: {num1}, {num2}, {num3}, {num4}, {num5}");

for (int i=0; i<array.Length; i++)
{
    sum = sum + array[i];
    if (array[i] > largest)
    {
        largest = array[i];
    }
    if (array[i] < smallest)
    {
        smallest = array[i];
    }
}

Console.WriteLine($"Sum: {sum}\nAverage:{sum/array.Length}\nSmallest: {smallest}\nLargest: {largest}");

