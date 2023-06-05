/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

Main();

void Main()
{
    int m = Prompt("Введите количество строк: ");
    int n = Prompt("Введите количество столбцов: ");
    double[,] array = GetAndFillArray(m, n);
    PrintDoubleArray(array);
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double[,] GetAndFillArray(int sizeM, int sizeN)
{
    double[,] newArray = new double[sizeM, sizeN];
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            newArray[i, j] = new Random().NextDouble() + new Random().Next(-10, 10);
        }
    }
    return newArray;
}

void PrintDoubleArray(double[,] userArray)
{
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(userArray[i, j], 1)} ");
        }
        Console.WriteLine();
    }
}