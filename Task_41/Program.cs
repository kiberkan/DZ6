// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



int [] QueryAndCreateNum()
{
    System.Console.WriteLine("Введите целые числа используя разделитель запятая (,) или пробел ( )");
    string[] arrValues = (Console.ReadLine()!.Split(',', ' '));
    int[] arr2 = Array.ConvertAll(arrValues, number => int.Parse(number));
    return arr2;
}

void PrintArray(int[] array)            
{
    Console.WriteLine(@"[{0}]", string.Join(", ", array)); 
}

void CountPositiveNum(int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine("Количесвто чисел больше 0 = " + count);
}

int [] arr = QueryAndCreateNum();
PrintArray(arr);
CountPositiveNum(arr);