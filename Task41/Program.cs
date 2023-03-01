System.Console.WriteLine($"Введите количество чисел (M), проверяемых на положительность: ");
int M = Convert.ToInt32(Console.ReadLine());

GetPositive(M);
void GetPositive(int M)
{
    int count = 0;

    for (int i = 1; i <= M; i++)
    {
        System.Console.WriteLine($"Введите {i} число");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number >= 0) count++;
    }
    System.Console.WriteLine($"Количество положительных чисел равно {count}");
}

