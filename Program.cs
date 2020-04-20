/*1. Написать программу «успеваемость». 
 * Пользователь вводит 10 оценок студента.
 * Реализовать меню для пользователя.
Вывод оценок (вывод содержимого массива)
Пересдача экзамена(пользователь вводит номер элемента массива и новую оценку)
Выходит ли стипендия(стипендия выходит, если средний бал не ниже 3.7)*/

using System;
using System.Globalization;
using static System.Console;

namespace HomeWork_11._04._2020
{
    class Program
    {
       static void InputScores(int [] arr, int size)
        {             
            for (int i = 0; i < size; i++)
            {
                Write($"Введите {i+1} - ю оценку ученика: ");
                arr[i] = Convert.ToInt32(ReadLine());
                WriteLine();
            }
            WriteLine("\n");
        }

       static void ShowScores(int[] arr, int size)
        {
            WriteLine($"Оценки ученика: ");
            for (int i = 0; i < size; i++)
            {
                Write($"{arr[i]} \t ");
            }
            WriteLine("\n");
        }

        static void Retake(int [] arr, int size)
        {
            int scoreposition;
            int retakescore;
            Write($"Введите порядковый номер оценки для пересдачи: ");
            scoreposition = Convert.ToInt32(ReadLine());
            Write($"Введите желаемую оценку ");
            retakescore = Convert.ToInt32(ReadLine());

            for (int i = 0; i < size+1; i++)
            {
                if (i == scoreposition)
                {
                    arr[i-1] = retakescore;
                }
            }
            WriteLine("\n");
        }

        static void Grant (int [] arr, int size)
        {
            int summ = 0;
            int average;

            for (int i = 0; i < size; i++)
            {
                summ += arr[i];
            }

            average = summ / size;

            if (average > 3.7)
            {
                Write($"Студент достоин стипендии!");
            }

            else
            {
                Write($"Студент не достоин стипендии!");
            }
            WriteLine("\n");
            WriteLine("\n");
        }

        static void Main(string[] args)
        {
            const int SIZE = 3;
            int[] score = new int[SIZE];

            InputScores(score, SIZE);
            ShowScores(score, SIZE);
            Retake(score, SIZE);
            ShowScores(score, SIZE);
            Grant(score, SIZE);
        }
    }
}
