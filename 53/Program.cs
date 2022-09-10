// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую
//  и последнюю строку массива.

// Console.WriteLine("Введите m");
// int m = Convert.ToInt32(Console.ReadLine()); //количество строк
// Console.WriteLine("Введите n");
// int n = Convert.ToInt32(Console.ReadLine()); //количество столбцов
// int[,] ourMatrix = GetMatrix(m, n, -10, 10);
// PrintMatrix(ourMatrix);

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }

    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)//кол столбцов
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SwapFirsAndLastRows(int[,] matrix)//на вход ожидаем int[,] matrix
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];  //общее кол строк -1 получим послед индекс строки
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}

int[,] ourMatrix = GetMatrix(3, 4, -10, 10);
PrintMatrix(ourMatrix);
SwapFirsAndLastRows(ourMatrix);
Console.WriteLine();
PrintMatrix(ourMatrix);


// void ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }












// void SqrEvenIndexes(int[,] matrix)//зад заменить на четных позициях на квадраты значений
// {
//     for (int i = 0; i < matrix.GetLength(0); i = i + 2)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j = j + 2)
//         {
//             matrix[i, j] = matrix[i, j] * matrix[i, j];
//         }
//     }
//     return;
// }





