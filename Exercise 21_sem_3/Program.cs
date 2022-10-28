/* Задача 21:
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве. A (3,6,8); B (2,1,-7), -> 15.84, 
                                                 A (7,-5, 0); B (1,-1,9) -> 11.53.*/
/* Variant 1:
int[] A = new int[3];
int[] B = new int[3];
Console.WriteLine("Enter the Coordinate A(x,y,z): ");
int.TryParse(Console.ReadLine()!,out A[0]);
int.TryParse(Console.ReadLine()!,out A[1]);
int.TryParse(Console.ReadLine()!,out A[2]);

Console.WriteLine("Enter the Coordinate B(x,y,z): ");
int.TryParse(Console.ReadLine()!,out B[0]);
int.TryParse(Console.ReadLine()!,out B[1]);
int.TryParse(Console.ReadLine()!,out B[2]);

double distance3D_A_B = Math.Round(Math.Sqrt(Math.Pow((A[0]-B[0]),2) + Math.Pow((A[1]-B[1]),2) 
+Math.Pow((A[2]-B[2]),2)),2);

Console.Write("The distance from A to B in 3D space equal: distance3D_A_B= " + distance3D_A_B);*/

//Variant 2:
Console.WriteLine("Enter the 3D coordinates A(x,y,z):");
Console.Write("A(x)= ");
int.TryParse(Console.ReadLine()!,out int Ax);
Console.Write("A(y)= ");
int.TryParse(Console.ReadLine()!,out int Ay);
Console.Write("A(z)= ");
int.TryParse(Console.ReadLine()!,out int Az);

Console.WriteLine("Enter the 3D coordinates B(x,y,z):");
Console.Write("B(x)= ");
int.TryParse(Console.ReadLine()!,out int Bx);
Console.Write("B(y)= ");
int.TryParse(Console.ReadLine()!,out int By);
Console.Write("B(z)= ");
int.TryParse(Console.ReadLine()!,out int Bz);

double distance3D_A_B = Math.Round(Math.Sqrt(Math.Pow((Ax-Bx),2) + Math.Pow((Ay-By),2) 
+Math.Pow((Az-Bz),2)),2);
Console.WriteLine("The distance from A to B in 3D space equal: ");
Console.Write($"distance3D_A_B= {distance3D_A_B}");
