using System;

int menu = 0 , a = 0, b = 0, c = 0;

for (; menu <= 5; menu++)
{
    Console.Clear();
    Console.WriteLine("1.Addtion");
    Console.WriteLine("2.Subtraction");
    Console.WriteLine("3.Multiplication");
    Console.WriteLine("4.Division");
    Console.WriteLine("Choose number 1-4");
    string input = Console.ReadLine();
    if (input == "break")
    {
        break;
    }
    menu = int.Parse(input);
    Console.Clear();
    switch (menu)
    {
        case 1:
            Console.WriteLine("[Addition]");
            Console.Write("First number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("The sum is: " + c);
            break;

        case 2:
            Console.WriteLine("First number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number:");
            b = int.Parse(Console.ReadLine());
            c = a - b;
            Console.WriteLine("The difference is:" + c);
            break;

        case 3:
            Console.WriteLine("First number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number:");
            b = int.Parse(Console.ReadLine());
            c = a * b;
            Console.WriteLine("The product is:" + c);
            break;

        case 4:
            Console.WriteLine("First number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number:");
            b = int.Parse(Console.ReadLine());
            c = a / b;
            Console.WriteLine("The qoutient is:" + c);
            break;
    }
    Console.WriteLine("Press enter key to continue...");
    Console.ReadKey();
}






