//**********************************************************
//* Практическая работа №4                                *
//* Выполнил: Мельников Л. А., группа 2-ИСПд               *
//*Задание: составить программу работы линейного алгоритма *
//**********************************************************






using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Практическая работа №4";
        Console.BackgroundColor = ConsoleColor.Green; // изменение цвета консоли
        Console.ForegroundColor = ConsoleColor.Blue; // изменение цвета текста в консоли
       
        Console.WriteLine("Здравствуйте!");
        Console.Write("Введите число N: ");
        
        int N = int.Parse(Console.ReadLine());
        int P = 1;
        for (int i = 1; i <= 2 * N; i += 2)
        {
            P *= i;
        }
        Console.WriteLine("Произведение первых {0} натуральных чисел равно {1}", N, P);


        Console.ReadKey();
    }
}