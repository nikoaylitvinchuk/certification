// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// Пример:
// m = 2, n = 3   =>   A(m, n) = 29
// m = 11, n = 3  =>   A(m, n) = 16381
// 
int FunctionAkr(int m, int n)
{
    if (m == 0) return n + 1;

    else if (n == 0) return FunctionAkr(m - 1, 1);

    else return FunctionAkr(m - 1, FunctionAkr(m, n - 1));
    
}


Console.Write("Введите не отрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите не отрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m >= 0 && n >= 0)
{
    int acr = FunctionAkr(m, n);
    Console.WriteLine(acr);
}
else
{
    Console.WriteLine("Ошибка ввода: ");
}