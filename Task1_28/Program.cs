Console.WriteLine("Enter the cost of cargo:");
var costOfCargo = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the distance:");
var distance = int.Parse(Console.ReadLine());

Console.WriteLine("Select the car type:");
Console.WriteLine("1. Up to 1.8 tons");
Console.WriteLine("2. Up to 5 tons");
Console.WriteLine("3. Up to 10 tons");
Console.WriteLine("4. Manipulator up to 5 tons");
Console.WriteLine("5. Manipulator up to 10 tons");
var carType = Console.ReadLine();

Console.WriteLine("Select the delivery type:");
Console.WriteLine("1. Urban");
Console.WriteLine("2. Suburban");
var deliveryType = Console.ReadLine();


double shippingCost = 0;
switch (carType)
{
    case "1":
        if (deliveryType == "1")
        {
            shippingCost = costOfCargo >= 15000 ? 0 : 300;
        }
        else // deliveryType == "2"
        {
            shippingCost = 300 + 30 * distance;
        }
        break;
    case "2":
        if (deliveryType == "1")
        {
            shippingCost = costOfCargo >= 20000 ? 0 : 600;
        }
        else // deliveryType == "2"
        {
            shippingCost = 600 + 40 * distance;
        }
        break;
    case "3":
        if (deliveryType == "1")
        {
            shippingCost = costOfCargo >= 30000 ? 0 : 1200;
        }
        else // deliveryType == "2"
        {
            shippingCost = 1200 + 65 * distance;
        }
        break;
    case "4":
        if (deliveryType == "1")
        {
            shippingCost = 1500;
        }
        else // deliveryType == "2"
        {
            shippingCost = 1500 + 50 * distance;
        }
        break;
    case "5":
        if (deliveryType == "1")
        {
            shippingCost = 2000;
        }
        else // deliveryType == "2"
        {
            shippingCost = 2000 + 60 * distance;
        }
        break;
}


Console.WriteLine($"Shipping cost: {shippingCost:F2} rubles");