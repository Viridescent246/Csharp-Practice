Console.WriteLine("What is your name?");
string name = Console.ReadLine();

Console.WriteLine("How old are you?");
int age = int.Parse(Console.ReadLine()) + 1;

Console.WriteLine($"Hi {name} you will be {age} next year");
