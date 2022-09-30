/* Задача 37. Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
 Результат записывайте в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

int[] array = GetArray(10, -10, 10);
int[] res = FactorPair(array);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"[{String.Join(", ", res)}]");

int[] FactorPair(int[] array)
{

    /* 
    int newSize = 0;
    if (array.Lenght % 2 == 0)
    {
        newSize = array.Length / 2;
    }
    else
    {
        newSize = array.Lenght / 2 + 1 ;
    }
    */

    int newSize = (int)Math.DivRem(array.Length, 2, out int rem) + rem;
    int[] newArr = new int[newSize];
    for (int i = 0, j = array.Length - 1; i < newSize; i++, j--)
    {
        if (i != j)
        {
            newArr[i] = array[i] * array[j];
        }
        else
        {
            newArr[i] = array[i];
        }
    
    }
    return newArr;
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
