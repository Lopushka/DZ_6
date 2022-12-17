static double ProductSummer(double[] myArray)
{
    double product;
    double summer =0;
    for (int i = 0, j = myArray.Length-1;i < myArray.Length/2; i++,j-- )
    {
        product = myArray[i]*myArray[j];
        summer = summer + product;
    }
    return summer;
}


loop1:
Console.WriteLine($"Количество элиментов массива: ");
int numder = Convert.ToInt32(Console.ReadLine());
if (numder > 0)
{
    double[] myArray = new double[numder];
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"\nВведите {i + 1} число: ");
        myArray[i] = Convert.ToDouble(Console.ReadLine());

    }

    Console.Write("\nВы ввели числа: ");

    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + ",");

    }
    Console.WriteLine();
    Console.WriteLine($"\nCумма произведений пар чисел в одномерном целочисленном массиве {ProductSummer(myArray)}");
    
}
else
{
    Console.WriteLine($"Допускается вод только ввод положительного числа больше 0.");
    goto loop1;
}