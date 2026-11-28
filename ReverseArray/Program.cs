// See https://aka.ms/new-console-template for more information
Console.WriteLine("How many numbers do you want to enter?");
int n = int.Parse(Console.ReadLine());

double[] array = new double[n];

for (int i=0; i<array.Length; i++)
{
    array[i]= double.Parse(Console.ReadLine());
}
for (int k=array.Length-1; k>=0; k--)
{
    Console.Write($"{array[k]}, ");
}