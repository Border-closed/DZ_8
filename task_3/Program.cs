﻿// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Ввод первой матрицы
int [,] m_1 = new int [2,2]
{
    {2, 4},
    {3, 2},
};

// Ввод второй матрицы
int [,] m_2 = new int [2,2]
{
    {3, 4},
    {3, 3},
};

// Создание результирующей матрицы
int [,] res = new int [2,2];

Console.WriteLine("Результат произведения матриц");

// Заполнение и вывод результирующей матрицы
for (int i = 0; i < res.GetLength(0); i++)
{
    for (int j = 0; j < res.GetLength(1); j++)
    {
        int temp = 0;
        for (int x = 0; x < res.GetLength(0); x++)
        {
        temp = temp+m_1[i,x]*m_2[x,j];
        }
        res[i,j] = temp;
        Console.Write($"{res[i,j]}   ");
    }
    Console.WriteLine();
}