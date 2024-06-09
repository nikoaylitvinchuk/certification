// Задайте произвольный массив. Выведете его элементы,
// начиная с конца. Использовать рекурсию, не использовать циклы.
// Пример:
// [1, 2, 5, 0, 10, 34]   =>   34 10 0 5 2 1

void PrintCoupArrayRecursion(int[] arr, int index)
{
    if (index >= 0)
    {
    Console.Write(arr[index] + " ");
    PrintCoupArrayRecursion(arr, index - 1);
    }
}

int[] normalArray = {1, 2, 5, 0, 10, 34};
PrintCoupArrayRecursion(normalArray, normalArray.Length - 1);