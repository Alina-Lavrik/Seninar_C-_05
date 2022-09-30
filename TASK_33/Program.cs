// Задача 33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> no
// 6; массив [6, 7, 19, 345, 3] -> yes


Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int[] array = GetArray(10, 1, 500);
Console.WriteLine($"Массив [{String.Join(", ", array)}]");

if (Contains (array, num))
{
    Console.WriteLine($"Число {num} присутствует в массиве");
}
else
{
    Console.WriteLine($"Число {num} не присутствует в массиве");
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

bool Contains(int[] array, int findnum)
{
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }

    }
    return false;
}

