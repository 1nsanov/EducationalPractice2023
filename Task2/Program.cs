Console.WriteLine("2. Дан массив целых чисел из n элементов, заполненный случайным образом числами из промежутка [-15,15].\nНайти произведение элементов, имеющих четное значение. Вывести индексы тех элементов массива, значения которых по модулю меньше заданного числа А.\nОпределить, есть ли в данном массиве положительные элементы, делящиеся на заданное число к с остатком 2.");
Console.WriteLine();

var n = 10;

var min = -15;
var max = 15;

var A = 5;
var k = 3;

var rng = new Random();

var arr = new int[n];
for (var i = 0; i < n; i++)
{
    arr[i] = rng.Next(min, max + 1);
}

Console.WriteLine("Array:");
Print(arr);
Console.WriteLine();

var number = 1;
for (var i = 0; i < n; i++)
{
    if (arr[i] % 2 == 0)
        number *= arr[i];
}
Console.WriteLine("Number of even values: " + number);

Console.Write("Indexes with mod < " + A + ": ");
for (var i = 0; i < n; i++)
{
    if (Math.Abs(arr[i]) % A < A)
        Console.Write(i + " ");
}
Console.WriteLine();

var hasPositiveDivisibleByKWithRemainder2 = false;
for (var i = 0; i < n; i++)
{
    if (arr[i] > 0 && arr[i] % k == 2)
    {
        hasPositiveDivisibleByKWithRemainder2 = true;
        break;
    }
}
Console.WriteLine("Positive element divisible by " + k + " with remainder 2: " + hasPositiveDivisibleByKWithRemainder2);


void Print(int[] arr)
{
    Console.WriteLine(string.Join(", ", arr));
}