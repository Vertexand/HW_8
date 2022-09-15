// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет 
// строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Console.WriteLine("Введите m");
// int m = Convert.ToInt32(Console.ReadLine()); //количество строк
// Console.WriteLine("Введите n");
// int n = Convert.ToInt32(Console.ReadLine()); //количество столбцов
// int[,] ourMatrix = GetMatrix(m, n, -10, 10);
// PrintMatrix(ourMatrix);
// SqrEvenIndexes(ourMatrix);
// Console.WriteLine();
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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] GetTMatrix(int[,] matrix)//1.14 cem 8 т.к матрица уже с др параметра ее надо вернуть БЫЛО
// возвращ значение для нашего метода GetTMatrix, на вход принимается sourecmatrix источник? sourec отбросили
{
    int[,] tmatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];//создать нашу матрицу с развернутым числом сторк и столб СТАЛО
    for (int i = 0; i < tmatrix.GetLength(0); i++)//пробегаем новую созданную марицу
    {
        for (int j = 0; j < tmatrix.GetLength(1); j++)
        {
            tmatrix[i, j] = matrix[j, i];//
        }
    }
    return tmatrix;
}
int[,] ourMatrix = GetMatrix(5, 3, -10, 10);//подготовили нашу матрицу
PrintMatrix(ourMatrix);                      //намечатали на экран
int[,] tttmatrix = GetTMatrix(ourMatrix);//подготовим любое имя,  нашу разверн матрица tm.. на вход подаем исходн
Console.WriteLine();
PrintMatrix(tttmatrix);
