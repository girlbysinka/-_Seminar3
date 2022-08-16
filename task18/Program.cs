/*
 Задача 18: Напишите программу, которая по заданному номеру четверти,
 показывает диапазон возможных координат точек в этой четверти (x и y).
*/

Console.Clear();

int userQuoter = 0;

Console.WriteLine("Введите номер четверти от 1 до 4:");
userQuoter = Convert.ToInt32(Console.ReadLine());
GetCoordinateFromQuoter ();

void GetCoordinateFromQuoter ()
    {
        
        if(userQuoter == 1)
        {
            Console.WriteLine("Диапазон возможных координат точек в 1 четверти составляет: X>0, Y>0 ");    
        }
        else if(userQuoter == 2)
        {
            Console.WriteLine("Диапазон возможных координат точек во 2 четверти составляет: X<0, Y>0 ");   
        }
        else if(userQuoter == 3)
        {
            Console.WriteLine("Диапазон возможных координат точек в 3 четверти составляет: X<0, Y<0 ");    
        }
        else if(userQuoter == 4)
        {
            Console.WriteLine("Диапазон возможных координат точек в 4 четверти составляет: X>0, Y<0 ");    
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ОШИБКА: Данной четверти не существует. Номер четверти должен лежать в диапозоне чисел от 1 до 4");
            Console.ResetColor();
        }
        return;
    }