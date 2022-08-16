/*
Задача 22: Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу квадратов чисел от 1 до N. 
5 -> 1, 4, 9, 16, 25. 2 -> 1,4
*/
Console.Clear();

int userNumber = PrintNumber();
FindSquareNumbers (userNumber);


int PrintNumber()
    {
    int userNumber = new int();
    Console.WriteLine("Введите первое число:");
    userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
    }

void FindSquareNumbers (double number)
    {
        double square = 0;
        for (int i=1; i <= number; i++)
        {
           square = Math.Pow(i, 2);
           Console.WriteLine(square);
        }
        return;
    }