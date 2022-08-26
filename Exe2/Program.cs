double x, y;
Console.WriteLine("Введите значение точки B1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение точки K1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение точки B2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение точки K2:");
double k2 = Convert.ToDouble(Console.ReadLine());

if ((k1 == k2) && (b1 == b2))
    Console.WriteLine($"Прямые накладываются друг на друга {k1} = {k2} и {b1} = {b2}");
else
{
    if (k1 == k2)
        Console.WriteLine($"Прямые параллельны");
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k2 * x + b2;
        Console.WriteLine($"X равен {x}, Y равен {y}");
    }
}