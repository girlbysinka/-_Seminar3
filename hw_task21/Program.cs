/*
Задача 21
Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.Clear();

int userAx = 0;
int userAy = 0;
int userAz = 0;

int userBx = 0;
int userBy = 0;
int userBz = 0;

Console.WriteLine("Введите координату X точки A:");
userAx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y точки A:");
userAy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z точки A:");
userAz = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("Введите координату X точки B:");
userBx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y точки B:");
userBy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z точки B:");
userBz = Convert.ToInt32(Console.ReadLine());


double distance = Math.Sqrt(Math.Pow((userBx - userAx), 2) + Math.Pow((userBy - userAy), 2) + Math.Pow((userBz - userAz), 2));
Console.WriteLine($"Расстояние между точками A и B составляет {distance}");