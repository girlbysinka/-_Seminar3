/*
Задача 21
Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.Clear();

Console.WriteLine("Введите координаты точки A");
int userAx = PrintX ();
int userAy = PrintY ();
int userAz = PrintZ ();

Console.WriteLine();
Console.WriteLine("Введите координаты точки B");
int userBx = PrintX ();
int userBy = PrintY ();
int userBz = PrintZ ();

double distance = Math.Sqrt(Math.Pow((userBx - userAx), 2) + Math.Pow((userBy - userAy), 2) + Math.Pow((userBz - userAz), 2));
Console.WriteLine($"Расстояние между точками A и B составляет {distance}");



int PrintX ()
    {
        int userX = new int ();
        Console.WriteLine("Введите координату X:");
        userX = Convert.ToInt32(Console.ReadLine());
        return userX;
    }

int PrintY ()
    {
        int userY = new int ();
        Console.WriteLine("Введите координату Y:");
        userY = Convert.ToInt32(Console.ReadLine());
        return userY;
    }

int PrintZ ()
    {
        int userZ = new int ();
        Console.WriteLine("Введите координату Z:");
        userZ = Convert.ToInt32(Console.ReadLine());
        return userZ;
    }