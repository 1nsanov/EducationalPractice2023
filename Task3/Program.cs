Console.WriteLine("3. Сформировать и вывести матрицу вида:");
Console.WriteLine();

var array = new int[5,5];
var counter = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = j >= counter ? 1 : 2;
    }
    counter++;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

