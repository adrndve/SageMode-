using System;

Console.Clear();
while (true)
{
    Console.Write("Enter number of rows: ");
    int max_row = int.Parse(Console.ReadLine());

    Console.Write("Enter number of columns: ");
    int max_col = int.Parse(Console.ReadLine());
    Console.Clear();

    int[,] table = createTable(max_col, max_row);

    Console.WriteLine("Original table");
    dispTable(table, -1, -1);

    Console.Write("Do you want to change a number in any cordinate y/n? ");
    String input = Console.ReadLine();
    if (input == "y")
    {
        Console.Clear();

        Console.Write("Enter coordinate X: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Entercoordinate Y: ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("Replacement value: ");
        int replacementValue = int.Parse(Console.ReadLine());
        Console.Clear();
            
        table[x,y] = replacementValue;  

        Console.WriteLine("New Table");
        dispTable(table, x, y);


    }
    if (input == "n")
    {
        break;
    }
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();

}


static int[,] createTable(int max_col, int max_row)
{
    int[,] table = new int[max_col, max_row];

    for (int y = 0; y < max_row; y++)
    {
        for (int x = 0; x < max_col; x++)
        {
            table[x, y] = (x + 1) * (y + 1);
        }
    }
        return (table);
}

static void dispTable(int[,] table, int xloc, int yloc)
{
    for (int y = 0; y < table.GetLength(0); y++)
    {
        for (int x = 0; x < table.GetLength(1); x++)
        {
            if(x == xloc && y == yloc) 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(table[x, y]);
                Console.ForegroundColor = ConsoleColor.White;
            } 
            else 
            {
                Console.Write(table[x, y]);
            }
            Console.Write("\t");
        }
            Console.WriteLine();
    }
}
    