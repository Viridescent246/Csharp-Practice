static double Add(double num1, double num2)
{
    return num1+num2;
}

static double Substract(double num1, double num2)
{
    return num1-num2;
}
static double Multiply(double num1, double num2)
{
    return num1*num2;
}
static double Divide(double num1, double num2)
{
    return num1/num2;
}
static int Menu()
{
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Substract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("5. Quit app");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("--------------------------------------");    
    Console.WriteLine("\nChoose an operation (1-5)");
    int choice = int.Parse(Console.ReadLine());
    while (choice>5 || choice < 1)
    {
        Console.WriteLine("Invalid value enter a number 1-5");
        choice = int.Parse(Console.ReadLine());
    }
    return choice;
}


int choice = Menu();
while (choice!=5)
{
    double num1;
    double num2;
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter the numbers to be added.");
            num1= double.Parse(Console.ReadLine());
            num2= double.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = {Add(num1,num2)}");
            break;

        case 2:
            Console.WriteLine("Enter the numbers to be substracted.");
            num1= double.Parse(Console.ReadLine());
            num2= double.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} - {num2} = {Substract(num1,num2)}");
            break;
        
        case 3:
            Console.WriteLine("Enter the numbers to be multiplied.");
            num1= double.Parse(Console.ReadLine());
            num2= double.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} x {num2} = {Multiply(num1,num2)}");
            break;
        
        case 4:
            Console.WriteLine("Enter the numbers to be divided.");
            num1= double.Parse(Console.ReadLine());
            num2= double.Parse(Console.ReadLine());
            while (num2 == 0)
            {
                Console.WriteLine("Invalid! Enter a non-zero integer.");
                num2= double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{num1}/{num2} = {Divide(num1,num2)}");
            break;
    }

    choice = Menu();

}
Console.WriteLine("Bye");
