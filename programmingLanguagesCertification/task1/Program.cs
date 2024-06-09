// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// Пример:
// m = 1, n = 5   =>   "1, 2, 3, 4, 5"
// m = 4, n = 8   =>   "4, 5, 6, 7, 8"
// m = 8, n = 4   =>   "8, 7, 6, 5, 4"

void PrintNaturalNumbers(int m, int n)
{
    if (m - 1 == n) return;
    PrintNaturalNumbers(m, n - 1);
    Console.Write($"{n} ");
}

void PrintRewersNaturalNumbers(int m, int n)
{
    if (m == n - 1) return;
    Console.Write($"{m} ");
    PrintRewersNaturalNumbers(m - 1, n);
}

int m = 1;
int n = -5;

if (m >= 0 && n >= 0)
{
    if (m < n)
    {
        PrintNaturalNumbers(m, n);
    }
    else
    {
        PrintRewersNaturalNumbers(m, n);
    }
}
else
{
    Console.WriteLine("Ошибка ввода!");
}