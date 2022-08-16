﻿/*
Напишите программу, которая принимает на вход координаты точки (X и Y),
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/
Console.Clear();

int GetQuoterFromCoordinate (int x, int y)
    {
        int result = 0;
        if(x > 0 && y > 0)
        {
            result = 1;    
        }
        else if(x < 0 && y > 0)
        {
            result = 2;    
        }
        else if(x < 0 && y < 0)
        {
            result = 3;    
        }
        else if(x > 0 && y < 0)
        {
            result = 4;    
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ОШИБКА: X и Y не должны быть равны 0. Вы ввели X:{x}, Y:{y}");
            Console.ResetColor();
        }
        return result;
    }

int userX = 0;
int userY = 0;

Console.WriteLine("Введите X:");
userX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y:");
userY = Convert.ToInt32(Console.ReadLine());
int quoter = GetQuoterFromCoordinate (userX, userY);
Console.WriteLine($"Для координаты {userX}:{userY} X и Y находятся в {quoter} четверти");