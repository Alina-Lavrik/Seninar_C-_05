/* Задача 32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

Console.Clear();
int[] mas = GetArray(10, -10, 11);
Console.WriteLine($"[{String.Join(", ", mas)}]");
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = mas[i] * (-1);
}
Console.Write($"[{String.Join(", ", mas)}]");

    
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++ )
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}
