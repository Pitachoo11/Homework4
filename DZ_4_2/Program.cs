// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int FillSummArray(int X)
{
    string number = X.ToString();
    int[] array = new int [number.Length];
    int result = 0;

    for (int i = 0; i < number.Length; i++)
    {
      array[i] = int.Parse(number[i].ToString());
      result = result + array[i];
    }
   return result;
}
Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int sumNumber = FillSummArray(numN);
Console.WriteLine("Сумма цифр введенного числа: " + sumNumber);