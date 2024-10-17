using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро  пожаловать! Здесь вы можете выполнить бинарные операции");
        while (true)
            
        {
            Console.WriteLine("\nВыберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");

            //выбор операции пользователем
            Console.Write("Введите номер операции: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            //считывание выбора и выполнение операции
            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Делить на ноль нельзя!");
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    Console.WriteLine("Неккоректный выбор!");
                    break;
            }
            //вывод результата

            if (choice >= 1 && choice <= 4)
            {
                Console.WriteLine("Результат: " + result);
            }
        }
    }  
}

