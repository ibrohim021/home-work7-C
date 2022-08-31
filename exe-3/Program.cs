// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray(int n, int m)
{
    int[,] array = new int[n, m];

    for(int i = 0; i< array.GetLength(0); i++)
    {
       for(int j = 0; j< array.GetLength(1); j++)
       {
             array[i,j] = new Random().Next(-5, 5);
       }
    }

    return array;
}

void PrintArray(int[,]array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] +" ");
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Введите число n ");
if (!int.TryParse(Console.ReadLine()!, out var m))Console.WriteLine("Все плохо!");


Console.WriteLine("Введите число m ");
if (!int.TryParse(Console.ReadLine()!, out var n))Console.WriteLine("Все плохо!");


int[,] array = CreateArray(n,m);

for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage = (avarage + array[i, j]);
    }
    avarage = avarage / n;

    
    Console.Write("Средне Арифмитическое = " + avarage + "/ ");
}


Console.WriteLine();

PrintArray(array);
