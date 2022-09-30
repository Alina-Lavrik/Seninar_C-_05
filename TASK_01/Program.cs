/*Задача. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.

[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

int positiveSum = 0;
int negativeSum = 0;

for (int i = 0; i < array.Length; i++ )
{
    if (array[i] < 0)
    {
        negativeSum += array[i];
    }
    else 
    {
        positiveSum += array[i];
    }
}

Console.WriteLine($"Сумма положительных элементов массива {positiveSum}, сумма отрицательных элементов массива {negativeSum}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++ )
    {
        res[i] = new Random().Next(minValue, maxValue +1);
    }
    return res;
}

