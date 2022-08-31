// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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



if (n > array.GetLength(0) || m > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {array[n-1,m-1]}");
}



PrintArray(array);








