// 8 HW Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 5 2 6 7 
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
//  суммой элементов: 1 строка 

int[,] ourMatrix = GetMatrix(3, 4, -10, 10);
PrintMatrix(ourMatrix);


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

// void SwapFirsAndLastRows(int[,] matrix)//на вход ожидаем int[,] matrix
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int temp = matrix[0, j];
//         matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];  //общее кол строк -1 получим послед индекс строки
//         matrix[matrix.GetLength(0) - 1, j] = temp;
//     }
// }


// SwapFirsAndLastRows(ourMatrix);
// Console.WriteLine();
// PrintMatrix(ourMatrix);