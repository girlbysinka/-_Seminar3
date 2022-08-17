/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Clear();

int userNumber = PrintNumber();

int digit1 = (userNumber / 1000) / 10;
int digit2 = (userNumber / 1000) % 10;
int digit4 = (userNumber % 100) / 10;
int digit5 = (userNumber % 100) % 10;

if (digit1 == digit5 && digit2 == digit4)
    {
        Console.WriteLine("Введённое число является палиндромом");
    }
else
    {
        Console.WriteLine("Введённое число не является палиндромом");
    }

int PrintNumber()
    {
    int userNumber = new int();
    Console.WriteLine("Введите пятизначное число:");
    userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber < 10000 || userNumber > 99999)
        {
            Console.WriteLine("Введённое число не является пятизначным. Введите пятизначное число:");
            userNumber = Convert.ToInt32(Console.ReadLine());
        }
    return userNumber;
    }
