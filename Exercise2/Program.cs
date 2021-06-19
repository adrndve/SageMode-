using System;


Console.Clear();
int menu = 0, a = 0, b = 0, c = 0;
for (menu = 0;menu <=5; menu++)
{
Console.WriteLine("1.Addition");
Console.WriteLine("2.Subtraction");
Console.WriteLine("3.Multiplication");
Console.WriteLine("4.Division");
Console.WriteLine("Choose a number (1-4)");
menu = int.Parse(Console.ReadLine());

if (menu == 1) 
{
Console. ForegroundColor = ConsoleColor. Blue; 
Console.WriteLine("Enter first number:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
b = int.Parse(Console.ReadLine());
c = a + b;
Console.WriteLine("The sum is:" + c);
}
if (menu == 2)
{
Console. ForegroundColor = ConsoleColor. Red;   
Console.WriteLine("Enter first number:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
b = int.Parse(Console.ReadLine());
c = a - b;
Console.WriteLine("The difference is:" + c);
}
if (menu == 3)
{
Console. ForegroundColor = ConsoleColor. Green;
Console.WriteLine("Enter first number:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
b = int.Parse(Console.ReadLine());
c = a * b;
Console.WriteLine("The product is:" + c);
}
if (menu == 4)
{
Console. ForegroundColor = ConsoleColor. Yellow;
Console.WriteLine("Enter first number:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
b = int.Parse(Console.ReadLine());
c = a / b;
Console.WriteLine("The quotient is:" + c);
}
}
