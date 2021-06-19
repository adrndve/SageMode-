using System;

namespace arrayPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Enter number of rows: ");
            int MAX_ROW = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int MAX_COL = int.Parse(Console.ReadLine());

            int[,] table = createtable(MAX_COL, MAX_ROW);

            Console.WriteLine("Original table");
            disptable(table, -1, -1);

            Console.Write("Enter coordinate X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Entercoordinate Y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Replacement value: ");
            int replacementValue = int.Parse(Console.ReadLine());

            table[x,y] = replacementValue;

            disptable(table, x, y);

        }
        static int[,] createtable(int MAX_COL, int MAX_ROW)
        {
            int[,] table = new int[MAX_COL, MAX_ROW];

            for (int y = 0; y < MAX_ROW; y++)
            {
                for (int x = 0; x < MAX_COL; x++)
                {
                    table[x, y] = (x + 1) * (y + 1);
                }
            }
            return (table);
        }
        static void disptable(int[,] table, int xloc, int yloc)
        {
            for (int y = 0; y < table.GetLength(0); y++)
            {
                for (int x = 0; x < table.GetLength(1); x++)
                {
                    if(x == xloc && y == yloc) {
                        Console.Write("[");
                        Console.Write(table[x, y]);
                        Console.Write("]");
                    } else {
                        Console.Write(table[x, y]);
                    }
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            
        }
    }
}

