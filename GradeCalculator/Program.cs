// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your score (1-100)");
double score = double.Parse(Console.ReadLine());
string grade="";

if (score<=100 && score >= 90)
{
    grade= "A";
    Console.WriteLine("You passed");
    Console.WriteLine($"Grade = {grade}");
}
else if (score<90 && score >= 80)
{
    grade= "B";
    Console.WriteLine("You passed");
    Console.WriteLine($"Grade = {grade}");
}
else if (score<80 && score >= 70)
{
    grade= "C";
    Console.WriteLine("You passed");
    Console.WriteLine($"Grade = {grade}");
}
else if (score<70 && score >= 60)
{
    grade= "D";
    Console.WriteLine("You passed");
    Console.WriteLine($"Grade = {grade}");
}
else if (score < 60 && score>=0)
{
    grade= "F";
    Console.WriteLine("You failed");
    Console.WriteLine($"Grade = {grade}");
}
else
{
    Console.WriteLine("Invalid score was entered");
}

