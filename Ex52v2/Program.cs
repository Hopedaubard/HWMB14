/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Main();

void Main()
{
    int[,] array = GetAndFillArray(5, 6);
    PrintArray(array);
    FindAverageFromColumns(array);
}

int[,] GetAndFillArray(int sizeM, int sizeN)
{
    int[,] newArray = new int[sizeM, sizeN];
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            newArray[i, j] = new Random().Next(1, 10);
        }
    }
    return newArray;
}

void PrintArray(int[,] enteredArray)
{
    for (int i = 0; i < enteredArray.GetLength(0); i++)
    {
        for (int j = 0; j < enteredArray.GetLength(1); j++)
        {
            Console.Write($"{enteredArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindAverageFromColumns(int[,] userArray)
{
    double[,] doubleArray = new double[userArray.GetLength(0), userArray.GetLength(1)];
    double sum = 0;
    double average = 0;
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            doubleArray[i, j] = Convert.ToDouble(userArray[i, j]);
        }
    }
    for (int j = 0; j < userArray.GetLength(1); j++)
    {
        for (int i = 0; i < userArray.GetLength(0); i++)
        {
            sum += doubleArray[i, j];
        }
        average = sum / (userArray.GetLength(0));
        Console.Write($"{Math.Round(average, 2)} ");
        sum = 0;
    }
}
