// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,]massiv = new int[2,2,2];
Random rnd = new Random();
for (int x = 0; x < massiv.GetLength(0); x++)
{
    for (int y = 0; y < massiv.GetLength(1); y++)
    {
        for (int z = 0; z < massiv.GetLength(2); z++)
        {
        massiv [x,y,z] = rnd.Next(10,100);
        Console.Write($"{massiv[x,y,z]}   ");
        Console.Write((x,y,z));
        Console.Write("  ");
        }
    }
    Console.WriteLine();
}