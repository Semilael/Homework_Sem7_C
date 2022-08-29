// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

Console.Write("Please, enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 100);

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]},  ");
        }
        Console.WriteLine();
    }
}

PrintArray(array);


void FindAverage(int[,] array)
{
    Console.WriteLine("Average is:");
    for (int i = 0; i < columns; i++)
    {
        int sum = 0;
        for (int j = 0; j < rows; j++)
        {
            sum += array[j, i];
                       
        }
        int average = sum / rows;
        Console.Write(average + ",  "); 
    }
       
}

FindAverage(array);
