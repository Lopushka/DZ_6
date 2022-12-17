Console.WriteLine("Я могу найти пересение двух отрезков, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("\nНо значения b1, k1, b2 и k2 напиши мне сам!");
Console.WriteLine($"И так начнем!");
Console.WriteLine();
Console.Write($"Введи b1= ");
double numder_b1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введи k1= ");
double numder_k1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введи b2= ");
double numder_b2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введи k2= ");
double numder_k2 = Convert.ToDouble(Console.ReadLine());

if (numder_k1==numder_k2 && numder_b1==numder_b2)
{
    Console.WriteLine($"Поскольку k1 ({numder_k1}) = K2 ({numder_k2}) и b1 ({numder_b1}) = b1 ({numder_b2}) прямые совпадают.");
}

if (numder_k1==numder_k2 && numder_b1!=numder_b2)
{
    Console.WriteLine($"Поскольку k1 ({numder_k1}) = k1 ({numder_k2}) прямые паралельны.");
    
}

if (numder_k1!=numder_k2)
{
    double numder_x = (numder_b2 - numder_b1) / (numder_k1 - numder_k2);
    double numder_y =  numder_k1 *numder_x + numder_b1;
    Console.WriteLine($"Точка пересечения двух прямых имеет координаты:{numder_x} , {numder_y} ");
    

}
