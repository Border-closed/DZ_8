// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Ввод пользователем квадратной размера матрицы (количество строк = количеству столбцов)
Console.WriteLine("Введите размер квадратной матрицы (количество строк = количеству столбцов)");

try
{
int N = int.Parse(Console.ReadLine()); 
int [,] massiv_1 = new int [N,N];

Console.WriteLine();

// Заполнение массива по спирали
int count = 1;
int i = 0;
int j = 0;
while (count <= N*N)
{
    massiv_1[i,j] = count;
    count++;
    if (i<=j+1 && (i+j)<(N-1))
    {
        j++;
    }
    else if (i<j && (i+j)>=(N-1))
    {
        i++;
    }
    else if (i>=j && (i+j)>(N-1))
    {
        j--;
    }
    else
    {
        i--;
    }
}

//Вывод матрицы
for (int x = 0; x < N; x++)
{
    for (int y = 0; y < N; y++)
    {
        Console.Write($"{massiv_1[x,y]}    ");
    }
    Console.WriteLine();
}
}
catch
{
System.Console.WriteLine("Вы ввели не число");
}