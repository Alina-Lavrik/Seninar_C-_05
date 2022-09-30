// Задача 35. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10, 99]
// * Пример массива из 5, а не из 123 элементов (сделать из 123)
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0

/*int[] array = GetArray(123, -100, 200);
Console.WriteLine($"[{String.Join(", ", array)}]");

int Countelement = 0;

for (int i = 0; i < array.Length; i++ )
{
    if (array[i] >= 10 && array[i] <= 99)
    {
        Countelement++;
    }
}
Console.WriteLine($"В массиве количество элементов в промежутке [10, 99] = {Countelement}");

Вариант 2*/

int[] array = GetArray(123, -100, 200);
Console.WriteLine($"[{String.Join(", ", array)}]");
int howMany = HowManyIntTheRange(array, 10, 100);
Console.WriteLine($"В массиве количество элементов в промежутке [10, 99] = {howMany}");

int HowManyIntTheRange(int[] array, int IntMin, int IntMax)
{
    int Countelement = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= IntMin && array[i] <= IntMax)
        {
            Countelement++;
        }
    }
    return Countelement;
}


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}