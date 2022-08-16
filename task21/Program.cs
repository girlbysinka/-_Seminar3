/*
Задача 21: Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 2D пространстве. 
 A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21
*/

Console.Clear();


int userAx = 0;
int userAy = 0;
int userBx = 0;
int userBy = 0;

Console.WriteLine("Введите координаты точки А:");
userAx = Convert.ToInt32(Console.ReadLine());
userAy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B:");
userBx = Convert.ToInt32(Console.ReadLine());
userBy = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((userBx - userAx), 2) + Math.Pow((userBy - userAy), 2));
Console.WriteLine($"Расстояние между точкамиФ A и B составляет {distance}");