﻿// Задача 27: Напишите программу, 
// которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Promt(string messageToUser)
{
    Console.WriteLine(messageToUser);        // Введите команду
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);       // Приводим к числу
    return result;                           // возвращаем результат
}

int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = Promt("Наишите число");
System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAllDigit(number)}");




