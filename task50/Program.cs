// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


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
int rows = int.Parse(Console.ReadLine());

Console.Write("Please, enter number of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 100);

Console.WriteLine($"Good!  We have an array with {columns} columns and {rows} rows. \n\nPlease, enter column and row separated with \"Enter\" to find the element: ");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());


void FindArrayElement(int[,] array)
{
    if(a > rows || b > columns)
    {
        Console.WriteLine("The number is wrong. Try one more time.");
    }
    else
    {
        Console.WriteLine(array.GetValue(a,b));
    }
}

FindArrayElement(array);





