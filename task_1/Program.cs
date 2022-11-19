// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Создание и вывод массива, заполненного рандомными числами от 1 до 9
Console.WriteLine("Исходный массив");
int[,]massiv = new int[4,4];
Random rnd = new Random();
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv [i,j] = rnd.Next(1,10);
        Console.Write($"{massiv[i,j]}   ");
    }
    Console.WriteLine();
}

// Метод вывода массива
void Print (int [,] massiv)
{
    for (int i = 0; i<massiv.GetLength(0); i++)
   {
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
    Console.Write ($"{massiv[i,j]}   ");
    }
    Console.WriteLine ();
   }
}

// Сортировка массива
   for (int i =0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1)-1; j++)
        {
            for (int x = j+1; x < massiv.GetLength(1); x++)
            {
                if (massiv[i,j]<massiv[i,x])
                {
                int temp = massiv[i,j]; 
                massiv[i,j] = massiv[i,x]; 
                massiv[i,x] = temp;
                }
            }
        }
    }

Console.WriteLine();
Console.WriteLine("Отсортированный массив");
Print(massiv);