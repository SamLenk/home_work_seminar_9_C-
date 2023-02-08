// Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

/*Console.Write("Введи число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N, 1));

// ------------------Метод------------------ 
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start - 1, end));
}*/

// Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*Console.WriteLine("Введите число  N"); 
int N = int.Parse(Console.ReadLine()!); 
 
Console.WriteLine("Введите число  M"); 
int M = int.Parse(Console.ReadLine()!); 

Console.WriteLine($"Сумма элементов в промежутке от {N} до {M} равна {PrintNumbers(N,M)}");
  
int PrintNumbers(int start, int end) 
{ 
    if(start == end) return start; 
    int gap = start + PrintNumbers(start + 1, end); 
    return gap;
}*/

// Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число  m = "); 
int m = int.Parse(Console.ReadLine()!); 
 
Console.Write("Введите число  n = "); 
int n = int.Parse(Console.ReadLine()!);

Console.Write($"m = {m}, n = {n} -> A(m,n) = {FunctionAckerman(m,n)}");

int FunctionAckerman(int a, int b)
{
    if (a == 0)  return (b + 1); 
    if (a != 0 && b == 0)  return FunctionAckerman(a - 1, 1); 
    if (a > 0 && b > 0)  return FunctionAckerman(a - 1, FunctionAckerman(a, b - 1)); 
    return FunctionAckerman(a, b);
}