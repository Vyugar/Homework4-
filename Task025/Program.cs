/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetExponentiation(int NumberA, int NumberB)
{
  int result = 1;
  for(int i = 1; i <= NumberB; i++)
  {
    result = result * NumberA;
  }
  return result;
}
Console.Write("Введите число A: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
int Exponentiation = GetExponentiation(NumberA, NumberB);
Console.WriteLine("Ответ: " + Exponentiation);