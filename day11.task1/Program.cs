Console.Write("Enter x: ");
var x = double.Parse(Console.ReadLine());

Console.Write("Enter y: ");
var y = double.Parse(Console.ReadLine());

Console.Write("Enter z: ");
var z = double.Parse(Console.ReadLine());

var min = Math.Min(Math.Min(x, y), z);
var max = Math.Max(Math.Max(x, y), z);

var u = (Math.Pow(min, 2) - Math.Pow(2, x) * max) / (Math.Pow(Math.Cos(x), 2) + min / max);

Console.WriteLine("The value of the expression is: " + u);
