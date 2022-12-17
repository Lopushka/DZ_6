


/* // через массив
static double Positivenamber(double[] myArray) // кол-во чисел > 0
{
    int counter = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > 0)
        {
            counter++;
        }

    }
    return counter;

}

static double Negativenamber(double[] myArray) // кол-во чисел < 0
{
    int counter = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] < 0)
        {
            counter++;
        }

    }
    return counter;

}





starter1:
Console.Write("Сколько целых положительных чисел будет введено: ");
int namder = Convert.ToInt32(Console.ReadLine());

if (namder > 0)
{
    double[] myArray = new double[namder];
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"\nВведите {i + 1} число: ");
        myArray[i] = Convert.ToDouble(Console.ReadLine());

    }

    Console.WriteLine("\nВы ввели числа: ");

    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + ",");

    }

    Console.WriteLine();
starter4:
    Console.WriteLine("\nЧто хотите сделать?\n\n1 - Посчитать, сколько чисел больше 0\n\n2 - Посчитать, сколько чисел меньше 0\n\n3 - Найти максимальное\\минимальное число\n\n4 - Найти сумму чисел\n\n5 - Я просто люблю смотреть на свои ЦИфРЫ!!");

    Console.WriteLine();
    int namder_choice = Convert.ToInt32(Console.ReadLine());
    if (namder_choice == 1)
    {

        Console.WriteLine("Чисел больше 0: " + Positivenamber(myArray));
    }

    Console.WriteLine();
    if (namder_choice == 2)
    {
        Console.WriteLine("Чисел меньше 0: " + Negativenamber(myArray));
    }

    if (namder_choice == 3)
    {
        Console.WriteLine($"\nМаксимальное число:{myArray.Max()}\nМинимальное число:{myArray.Min()}");
    }

    if (namder_choice == 4)
    {
        Console.WriteLine($"Сумма чисел:{string.Format("{0:F5}", myArray.Sum())}"); // F1-(1) кол-во знаков после запятой
    }

    if (namder_choice == 5)
    {
        Console.WriteLine("Я знал что ты правильный человек!!! Наслаждайся!");
        for (int i = 0; i < 100; i++)
        {
            Thread.Sleep(100);
            for (int j = 0; j < myArray.Length; j++)
            {
                Console.Write(myArray[j]);
                Thread.Sleep(50);
            }

        }
        Console.WriteLine();
        Console.WriteLine("\nСпасибо за внимание! ВСЕГО ХО-РО-ШЕГО!");

    }

    if (namder_choice > 5 || namder_choice < 1)
    {
        Console.Write("\nКоманда не распознана!\nПопытайтесь еще раз.");
        goto starter4;
    }
}

if (namder == 0)
{
    Console.Write($"\nПоздравляю вы решили вести {namder} чисел");
starter2:
    Console.Write($"\nЖелаете начать сначало?\n 1-Yes 2-No: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 2)
    {
        Console.Write($"\nХорошего Вам дня! До новых встреч!");

    }

    if (choice == 1)
    {
        goto starter1;
    }
    if (choice > 2 || choice < 1)
    {
        Console.Write("\nКоманда не распознана!\nПопытайтесь еще раз.");
        goto starter2;
    }

}

if (namder < 0)
{
    Console.Write($"\nПоздравляю вы введи отрицательное число: {namder}");
starter3:
    Console.Write($"\nЖелаете начать сначало?\n 1-Yes 2-No: ");
    int choice_1 = Convert.ToInt32(Console.ReadLine());

    if (choice_1 == 2)
    {
        Console.Write($"\nХорошего Вам дня! До новых встреч!");

    }

    if (choice_1 == 1)
    {
        goto starter1;
    }
    if (choice_1 > 2 || choice_1 < 1)
    {
        Console.Write("\nКоманда не распознана!\nПопытайтесь еще раз.");
        goto starter3;
    }

}
*/

