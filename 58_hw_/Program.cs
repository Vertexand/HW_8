// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 5 2 6 7 
// и 
// 1 5 8 5 
// 4 9 4 2 
// 7 2 2 6 
// 2 3 4 7  
// Их произведение будет равно следующему массиву: 
// 1 20 56 10 
// 20 81 8 6 
// 56 8 4 24 
// 10 6 24 49 
Console.WriteLine("заданы 2 массива: ");
int[,] Matr = GetMatrix(4, 4, 1, 9);
PrintMatrix(Matr);
Console.WriteLine();
int[,] Matr2 = GetMatrix(4, 4, 1, 9);
PrintMatrix(Matr2);
Console.WriteLine();
Console.WriteLine("Их произведение будет равно следующему массиву: ");

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
void Multiplication(int[,] matrix, int[,] matrix2)
{
    int[,] Mmatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); ++i)//указать меньшую матрицу
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            for (int k = 0; k < matrix.GetLength(1); ++k)//пробегает по столб меньш массива
            {
                Mmatrix[i, j] = matrix[i, j] * matrix2[i, j];//как оно тут крутит? одновременно знач по одинак индексам
            }
            {
                Console.Write(Mmatrix[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}
Multiplication(Matr, Matr2);

