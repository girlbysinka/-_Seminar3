/*
Задача 23
Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Clear();

int userNumber = PrintNumber();
Console.WriteLine();
FindCubeNumbers (userNumber);


int PrintNumber()
    {
    int userNumber = new int();
    Console.WriteLine("Введите первое число:");
    userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
    }

void FindCubeNumbers (double number)
    {
        double cube = 0;
        for (int i=1; i <= number; i++)
        {
           cube = Math.Pow(i, 3);
           Console.WriteLine(cube);
        }
        return;
    }
