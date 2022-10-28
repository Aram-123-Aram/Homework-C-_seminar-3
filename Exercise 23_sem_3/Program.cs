/* Задача 23:
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27, 
5 -> 1, 8, 27, 64, 125.*/

Console.Write("Enter any integer number N= ");
int.TryParse(Console.ReadLine()!,out int N);
Console.Write($"{N} -> ");
int i = 1;
while(i < N+1) {Console.Write($" {Math.Pow(i,3)}, "); i++;}

