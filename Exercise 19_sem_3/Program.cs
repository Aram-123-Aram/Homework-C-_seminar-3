/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. 14212 -> нет, 12821 -> да, 23432 -> да */
//Variant 1:
Console.Write("Enter any 5-digit number n= ");
int.TryParse(Console.ReadLine()!, out int n);
Console.WriteLine();
 if(n/10000 == n%10 && n/1000%10 == n/10%10) {Console.Write($"{n} -> Да,Палиндром!"); }
 else {Console.Write($"{n} -> Нет, не Палиндром!"); }

/*Variant 2:
int[] array = new int[5] {2,3,4,3,2};
if (array[0] == array[4] && array[1] == array[3]) {Console.Write("Заданное число являеться палиндромом!" );}
else {Console.Write("Заданное число не являеться полиндромом");}*/

/* Variant 3:
for(int n = 1; n < 100; n++) //Задача- сгенерируем 5-значное число и проверяем -являеться лы это число полиндромом или нет
{
int[] array = new int[5];
for(int i=0; i < 5; i++) {array[i] = new Random().Next(10);}
for(int i = 0; i < 5; i++) {Console.Write(array[i]);}

if (array[0] == array[4] && array[1] == array[3]) {Console.WriteLine(" -> Палиндром");}
else {Console.WriteLine(" -> Не палиндром!");} } */