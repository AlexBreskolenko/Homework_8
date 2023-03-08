/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.Clear();

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

//Поиск строки с наименьшей суммой
int FoundMinSumLine(int[,] arr)
{
    int[] arrSum = new int[arr.GetLength(0)];
    
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        arrSum[i] = sum;
    }

    int index = 0;
    int minSum = arrSum[0];

    for(int i = 0; i < arrSum.Length; i++)
    {
        if(minSum > arrSum[i])
        {
            minSum = arrSum[i];
            index = i;
        }
    }

    return index + 1;
}

//Создаем прямоугольный массив 
int[,] array = new int[3, 5];
//Заполняем
FillRandomArray(array);
//Вывод
PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Строка с наименьшей суммой элементов : {FoundMinSumLine(array)}");

