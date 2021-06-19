using System;

int [] products = new int [10];

Console.Write("Enter a number: ");
int multiplier = int.Parse(Console.ReadLine());

for (int x = 0; x < products.Length; x++)
{
    products[x] = (x+1) * multiplier;

    Console.WriteLine(products[x]);
}

// products
/*
    products[0] x * m
    products[1] x * m
    ...
    products[9] x * m
*/











