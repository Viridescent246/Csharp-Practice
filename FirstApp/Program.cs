// See https://aka.ms/new-console-template for more information

Console.WriteLine("What is your name?");
string name = Console.ReadLine();

Console.WriteLine("What is your age?");
int age= int.Parse(Console.ReadLine());
while (age <= 0)
{
    Console.WriteLine("What is your age? (Enter a number greater than 0)");
    age= int.Parse(Console.ReadLine());
}

double num;
double sum= 0.0;
double largest;
int i=1;

Console.WriteLine("Enter a number");
num = double.Parse(Console.ReadLine());
sum= num + sum;
largest=num;

while (i<5)
{
    Console.WriteLine("Enter a number");
    num = double.Parse(Console.ReadLine());
    sum= num + sum;
    if (num > largest)
    {
        largest=num;
    }
    i++;

}

double avg = sum/(i);    

if (age >= 18)
{
    Console.WriteLine("User is an adult");
}
else
{
    Console.WriteLine("User is a minor");
}

Console.WriteLine($"Sum is {sum}\nAverage is {avg}\nLargest Number is {largest}");
