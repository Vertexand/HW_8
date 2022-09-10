// 8 HW Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию
//  элементы каждой строки двумерного массива. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// В итоге получается вот такой массив: 
// 1 2 4 7 
// 2 3 5 9 
// 2 4 4 8 
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

int[,] GetTMatrix(int[,] matrix)//на вход ожидаем int[,] matrix
{
    int[,] Vmatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < Vmatrix.GetLength(0); i++)//3
    {
        for (int j = 0; j < Vmatrix.GetLength(1); j++)//4
        {
            // for (int i = 0; i < Vmatrix.GetLength(0); i++)//3
            { 
               int min = matrix[0, 0];
                if (matrix[i, j] < min)
                    matrix[i, j] = min;//как записать первый мин в Vmatrix[0, 0]
                Vmatrix[i, j] = matrix[i, j];
                {
                    // Console.WriteLine((", ", Vmatrix));
                    // Console.WriteLine();
                }
            }
        }
        return Vmatrix;
    }
}


    int[,] ourMatrix = GetMatrix(3, 4, -10, 10);//подготов матрица
    PrintMatrix(ourMatrix);
    int[,] vmatrix = GetTMatrix(ourMatrix);//подготовим любое имя,  нашу разверн матрица tm.. на вход подаем исходн
    Console.WriteLine();
    PrintMatrix(vmatrix);
// ыыыыыыыыыыыыыыыыыы
// using System;

// namespace Draft
// {
//     class Program
//     {
//         static void Main()
//         {
//             int[][] jagged = new int[3][];
//             jagged[0] = new int[4];
//             jagged[1] = new int[3];
//             jagged[2] = new int[5];

//             // Заполняем массив случайными числами
//             Random random = new Random();
//             for (int i = 0; i < jagged[0].Length; i++)
//                 jagged[0][i] = random.Next(-10, 10);
//             for (int i = 0; i < jagged[1].Length; i++)
//                 jagged[1][i] = random.Next(-10, 10);
//             for (int i = 0; i < jagged[2].Length; i++)
//                 jagged[2][i] = random.Next(-10, 10);

//             // Исходное содержимое массива
//             Console.WriteLine("Исходное содержимое массива");
//             for (int i = 0; i < jagged[0].Length; i++)
//                 Console.Write(jagged[0][i] + " ");
//             Console.WriteLine();
//             for (int i = 0; i < jagged[1].Length; i++)
//                 Console.Write(jagged[1][i] + " ");
//             Console.WriteLine();
//             for (int i = 0; i < jagged[2].Length; i++)
//                 Console.Write(jagged[2][i] + " ");
//             Console.WriteLine();

//             // Сортировка массива
//             for (int i = 0; i < jagged[0].Length; i++)
//                 Array.Sort(jagged[0]);
//             for (int i = 0; i < jagged[1].Length; i++)
//                 Array.Sort(jagged[1]);
//             for (int i = 0; i < jagged[2].Length; i++)
//                 Array.Sort(jagged[2]);

//             // Отсортированное содержимое массива
//             Console.WriteLine("\nОтсортированное содержимое массива");
//             for (int i = 0; i < jagged[0].Length; i++)
//                 Console.Write(jagged[0][i] + " ");
//             Console.WriteLine();
//             for (int i = 0; i < jagged[1].Length; i++)
//                 Console.Write(jagged[1][i] + " ");
//             Console.WriteLine();
//             for (int i = 0; i < jagged[2].Length; i++)
//                 Console.Write(jagged[2][i] + " ");

//             Console.ReadKey();
//         }
//     }
// }
// ыыыыыыыыыыыыыыыыыыыыыыыыыыыыыыыыыы
//  Console.WriteLine($"в каждой строке возрастание элементов : {(", ", int[,] vmatrix)}");

// void average(int[,] matrix)//метод сред ариф по стобцам  работает 
// {
//     double[] b = new double[matrix.GetLength(1)];
//     int k = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)//столб 
//     {
//         double summa = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)//строки
//         {
//             summa += matrix[i, j];
//         }
//         b[k] = summa / matrix.GetLength(0);
//         Console.Write(b[k] + " ");
//         k++;
//     }
// }


// int temp = matrix[0, i];
//         matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];  //общее кол строк -1 получим послед индекс строки
//         matrix[matrix.GetLength(0) - 1, i] = temp;
//                 Console.Write($" {matrix[i, j] + " "});


// Console.WriteLine($"Исходный массив: {string.Join(", ", array)}");//39
// Console.WriteLine($"Скопированный массив: {string.Join(", ", copyArray)}");