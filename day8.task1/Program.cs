double[,] array = new double[6, 7];

Console.WriteLine("fill the array from the keyboard");
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 7; j++)
    {
        //Console.Write($"Enter the element at position [{i}, {j}]: ");
        //array[i, j] = Convert.ToDouble(Console.ReadLine());
        array[i, j] = new Random().Next(0, 100);
    }
}


Console.WriteLine("Array before the change:");
DisplayArray(array);

// 1
(array[1, 2], array[2, 4]) = (array[2, 4], array[1, 2]);

// count the number of even elements
int evenCount = 0;
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 7; j++)
    {
        if (array[i, j] % 2 == 0)
        {
            evenCount++;
        }
    }
}

// 2
double product = 1;
for (int i = 0; i < 6; i++)
{
    product *= array[i, 2];
}

// 3
Console.WriteLine("Array after the change:");
DisplayArray(array);
Console.WriteLine($"Number of even elements: {evenCount}");
Console.WriteLine($"Product of the elements in the 3rd column: {product}");


void DisplayArray(double[,] array)
{
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            Console.Write($"{array[i, j],8:F2}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}