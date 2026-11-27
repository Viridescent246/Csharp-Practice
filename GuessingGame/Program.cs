Random rng = new Random();
int num = rng.Next(1, 101);

Console.WriteLine("Guess the number 1-100");
int guess = int.Parse(Console.ReadLine());
int count = 1;

while (guess != num)
{
    if(guess>=1 && guess <= 100)
    {
        Console.WriteLine("Wrong!");
        if (guess > num)
        {
            Console.WriteLine("This number is too big");
        }
        else if (guess < num)
        {
            Console.WriteLine("This number is too small");
        }
        count++;
    }
    else
    {
        Console.WriteLine("Invalid value! Enter a number from 1-100");
    }
    Console.WriteLine("Guess the number 1-100");
    guess = int.Parse(Console.ReadLine());
       
}

Console.WriteLine("Congratulations you guessed the correct number!!");
Console.WriteLine($"It took {count} tries");