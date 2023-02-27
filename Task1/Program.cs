Console.WriteLine("1. Заменить последний положительный элемент массива на второй элемент массива");

int[] arr = { 1, -2, 3, -4, 5 };

Console.WriteLine("Array:");
Console.WriteLine(string.Join(", ", arr));

for (var i = arr.Length - 1; i >= 0; i--)
{
    if (arr[i] > 0)
    {
        arr[i] = arr[1];
        break;
    }
}

Console.WriteLine("Result:");
Console.WriteLine(string.Join(", ", arr));