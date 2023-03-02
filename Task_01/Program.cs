// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputInt(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] Array(int length)
{
    int[] array = new int[length];
        for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputInt($"Введите {i + 1}-й элемент");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int SumPositive(int[]  array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}

int length = InputInt("Введите количество чисел ->");
int[] array;
array = Array(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {SumPositive(array)}");