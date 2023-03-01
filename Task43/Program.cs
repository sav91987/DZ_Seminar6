System.Console.WriteLine($"Введите коэффициент k1 для первой прямой: ");
double k1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"Введите значение b1 для первой прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"Введите коэффициент k2 для первой прямой: ");
double k2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"Введите значение b2 для первой прямой: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1==k2) System.Console.WriteLine("Прямые параллельны");
else
{
    GetCrossPoint(k1, b1, k2, b2);
}

void GetCrossPoint(double k1,double b1, double k2, double b2)
{
    double x = Math.Round(((b2 - b1) / (k1 - k2)), 1);
    double y = Math.Round((k1 * ((b2 - b1) / (k1 - k2)) + b1), 1);
    System.Console.WriteLine($"Координаты точки пересечения прямых ({x}; {y})");
}

