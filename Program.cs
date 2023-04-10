//-------------------------------Task 1---------------------------
//Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// int Exect(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }
// int NNumber(int n, int m)
// {
//   if (n == m) return n;
//   else Console.Write($"{NNumber(n, m + 1)}, ");
//   return m;
// }
// int n = Exect("Input N: ");
// if (n < 1)
// {
//   Console.WriteLine("Enter Positive Number! ");
//   return;
// }
// Console.WriteLine(NNumber(n, 1));




//----------------------------Task 2---------------------------------------------
//Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Exect(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}
int SumOfElements(int n, int m)
{
  if (n == m) return n;
  else return SumOfElements(n + 1, m) + n;
}
int n = Exect("Input N: ");
int m = Exect("Input M: ");
Console.WriteLine(SumOfElements(n, m));