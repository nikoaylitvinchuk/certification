// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// Пример:
// m = 1, n = 5   =>   "1, 2, 3, 4, 5"
// m = 4, n = 8   =>   "4, 5, 6, 7, 8"
// m = 8, n = 4   =>   "8, 7, 6, 5, 4"

void PrintNaturalNumbers(int n, int m)
{
    if (n < m)
    {
        if (n > m) return;
        Console.Write($"{n} ");
        PrintNaturalNumbers(n + 1, m - 0);
    }
    else if (n > m)
    {
        if (n < m) return;
        Console.Write($"{n} ");
        PrintNaturalNumbers(n - 1, m - 0);
    }

}

PrintNaturalNumbers(-5, -1);

