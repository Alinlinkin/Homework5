double[] GetArray(int size, int startValue, int endValue)
{
    double[] array = new double[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble() + random.Next(startValue, endValue);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    return;
}

double MaxNumber(double[] array)
{
    double maxNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maxNumber < array[i])
        {
            maxNumber = array[i];
        }

    }
    return maxNumber;
}

double MinNumber(double[] array)
{
    double minNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minNumber > array[i])
        {
            minNumber = array[i];
        }

    }
    return minNumber;
}

try
{
    Console.WriteLine("Введите размер массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите начало отрезка цифр: ");
    int start = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите конец отрезка цифр: ");
    int end = Convert.ToInt32(Console.ReadLine());

    double[] array = GetArray(size, start, end);
    Console.WriteLine($"Наш массив:");
    PrintArray(array);
    double max = MaxNumber(array);
    double min = MinNumber(array);
    double result = max - min;
    Console.WriteLine("");
    Console.WriteLine($"Разница между максимальным {max} и минимальным {min} числом массива = {result}");

}
catch (Exception ex)
{
    Console.WriteLine($"Входное значение имеет неверный формат. Ошибка: {ex.Message}");
}
