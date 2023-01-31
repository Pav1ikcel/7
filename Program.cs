/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2


Console.Write("Enter the number of strings:  ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
CrateArrayRandomNumbers(numbers);
Console.WriteLine("Original Array:");
ShowArray(numbers);
SortArray(numbers);
Console.WriteLine("\nSorted Array:");
 ShowArray(numbers);
void CrateArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100));
        }
    }
}
void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
void SortArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int n = array.GetLength(1);
        double[] row = new double[n];
        for (int j = 0; j < n; j++)
        {
            row[j] = array[i, j];
        }
        Array.Sort(row, (x, y) => y.CompareTo(x));
        for (int j = 0; j < n; j++)
        {
            array[i, j] = row[j];
        }
    }
}
*/

/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;

namespace ArrayMinRow
{
    class Program
    {
        static int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
        {
            int[,] array = new int[rows, columns];

            for(int i = 0; i < rows; i++)
                for(int j = 0; j < columns; j++)
                     array[i, j] = new Random().Next(minValue, maxValue + 1);
                
            return array;
        }

        static void Show2dArray(int[,] array)
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i,j] + " ");
    
                Console.WriteLine();    
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("Input a number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a min possible value : ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a max possible number: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            int[,] arr = CreateRandom2dArray(rows, columns, minValue, maxValue);

            Console.WriteLine("Generated 2D Array:");
            Show2dArray(arr);

            int minRowIndex = 0;
            int minSum = int.MaxValue;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    rowSum += arr[i, j];
                }

                if (rowSum < minSum)
                {
                    minSum = rowSum;
                    minRowIndex = i;
                }
            }

            Console.WriteLine("Row " + (minRowIndex + 1) + " has the smallest sum of elements: " + minSum);
        }
    }
}
*/
/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value : ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible number: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
             array[i, j] = new Random().Next(minValue, maxValue + 1);
        
    return array;
}
void Show2dArray(int[,] array)
 {
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();    
    }
    Console.WriteLine();
 }
int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

int[,] MultiplyMatrices(int[,] firstMatrix, int[,] secondMatrix)
{
    int firstRows = firstMatrix.GetLength(0);
    int firstColumns = firstMatrix.GetLength(1);
    int secondRows = secondMatrix.GetLength(0);
    int secondColumns = secondMatrix.GetLength(1);

    if (firstColumns != secondRows)
        throw new Exception("Matrices can't be multiplied!");

    int[,] result = new int[firstRows, secondColumns];
    for (int i = 0; i < firstRows; i++)
    {
        for (int j = 0; j < secondColumns; j++)
        {
            for (int k = 0; k < firstColumns; k++)
            {
                result[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }

    return result;
}

int[,] firstMatrix = CreateRandom2dArray();
int[,] secondMatrix = CreateRandom2dArray();
int[,] result = MultiplyMatrices(firstMatrix, secondMatrix);
Show2dArray(result);

*/
/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

int[,,] CreateRandom3dArray()
{
Console.Write("Input number of layers: ");
int layers = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[layers, rows, columns];

for(int i = 0; i < layers; i++)
    for(int j = 0; j < rows; j++)
        for(int k = 0; k < columns; k++)
             array[i, j, k] = new Random().Next(minValue, maxValue + 1);

return array;
}
void Show3dArray(int[,,] array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
Console.WriteLine("Layer " + i + ":");
for(int j = 0; j < array.GetLength(1); j++)
{
Console.Write("Row " + j + ": ");
for(int k = 0; k < array.GetLength(2); k++)
Console.Write(array[i, j, k] + " ");
Console.WriteLine();
}
Console.WriteLine();
}
}
int[,,] newArray = CreateRandom3dArray();
Show3dArray(newArray);
*/

/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07


using System;

namespace SpiralArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4];

            int value = 1;
            int minCol = 0;
            int maxCol = 3;
            int minRow = 0;
            int maxRow = 3;

            while (value <= 16)
            {
                for (int i = minCol; i <= maxCol; i++)
                {
                    arr[minRow, i] = value;
                    value++;
                }

                for (int i = minRow + 1; i <= maxRow; i++)
                {
                    arr[i, maxCol] = value;
                    value++;
                }

                for (int i = maxCol - 1; i >= minCol; i--)
                {
                    arr[maxRow, i] = value;
                    value++;
                }

                for (int i = maxRow - 1; i >= minRow + 1; i--)
                {
                    arr[i, minCol] = value;
                    value++;
                }

                minCol++;
                minRow++;
                maxCol--;
                maxRow--;
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
*/