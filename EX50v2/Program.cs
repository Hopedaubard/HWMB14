/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

[1,7] -> такого числа в массиве нет*/

Main();

void Main()
{
    int[,] array = GetAndFillArray(5, 4);
    PrintArray(array);
    int row = Prompt($"Введите строчку, в которой хранится элемент массива: ");
    int column = Prompt($"Введите столбец, в котором хранится элемент массива: ");
    FindNumFromMatrix(array, row, column);
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetAndFillArray(int sizeM, int sizeN)
{
    int[,] newArray = new int[sizeM, sizeN];
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            newArray[i, j] = new Random().Next(-20, 20);
        }
    }
    return newArray;
}

void PrintArray(int[,] userArray)
{
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            Console.Write($"{userArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindNumFromMatrix(int[,] userArray, int enteredRow, int enteredColumn)
{
    if (enteredRow < userArray.GetLength(0) && enteredColumn < userArray.GetLength(1))
    {
        Console.WriteLine($"Значение искомого элемента: {userArray[enteredRow - 1, enteredColumn - 1]}");
    }
    if (enteredRow > userArray.GetLength(0))
    {
        Console.WriteLine("Элемент не найден, превышено значение количества строк");
    }
    if (enteredColumn > userArray.GetLength(1))
    {
        Console.WriteLine("Элемент не найден, превышено значение количества столбцов");
    }
}