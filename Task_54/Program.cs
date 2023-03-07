/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Clear();
//================================Методы===========================================================
//Ввод числа
int EnterMesseng(string messeng)
{
    Console.WriteLine(messeng);
    int num = int.Parse(Console.ReadLine());
    return num;
}

//Создаём размер массива
var CreateArray = (int sizeCol, int sizeRow) => new int[sizeCol, sizeRow];

// метод для печати двумерного массива
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Заполняем массив рандомными числами
void FillRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

//Метод упорядовачивания чисел в каждой строке
void SwapArray(int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}
//==============================================================================================

int rowSize = EnterMesseng("Введите количество строк : ");
int colSize = EnterMesseng("Введите количество столбцов : ");

int[,] array = CreateArray(rowSize, colSize);

Console.WriteLine();
FillRandomArray(array);

Console.WriteLine();
PrintArray(array);

SwapArray(array);

Console.WriteLine();
PrintArray(array);

