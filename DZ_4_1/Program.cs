//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//Без использования Math.Pow(A,B);

int PowMethod(int X, int Y)
{
  int result = 1;
  for(int i=1; i <= Y; i++){
    result = result * X;
  }
    return result;
}

Console.WriteLine("Введите число A");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());
  
int power = PowMethod(numA, numB);
Console.WriteLine($"{numA} в натуральной степени {numB} = " + power);
