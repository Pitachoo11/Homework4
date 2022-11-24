// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = {11, 2, 5, 7, 19, 6, 1, 33};

void PrintArray0_4(int[] array)
{
     int count = 5;
     for (int i = 0; i < count; i++)
     {
        System.Console.Write($"{array[i]}, ");
     }
    System.Console.WriteLine();
}

void PrintArray5_7(int[] array)
{
     int count = array.Length;
     for (int i = 5; i < array.Length; i++)
     {
        System.Console.Write($"{array[i]}, ");
     }
    System.Console.WriteLine();
}

PrintArray0_4(array);
PrintArray5_7(array);