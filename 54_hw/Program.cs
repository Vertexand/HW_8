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

void MatrixLines(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)//длина строки т.е.3
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] > matrix[i, k + 1])//ВОПРОС привил ли я поним цикл, 
                // напр. стр 9438, 1-й проход ->3948, 2->3498. 3->3489?
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}
int[,] ourMatrix = GetMatrix(3, 4, 1, 10);
PrintMatrix(ourMatrix);
MatrixLines(ourMatrix);
Console.WriteLine();
PrintMatrix(ourMatrix);








/* int[][] jagged = new int[3][];//  пример  1
jagged[0] = new int[4];
jagged[1] = new int[4];
jagged[2] = new int[4];

// Заполняем массив случ  числами
Random random = new Random();
for (int i = 0; i < jagged[0].Length; i++)
    jagged[0][i] = random.Next(-10, 10);
for (int i = 0; i < jagged[1].Length; i++)
    jagged[1][i] = random.Next(-10, 10);
for (int i = 0; i < jagged[2].Length; i++)
    jagged[2][i] = random.Next(-10, 10);

// Исходное содержимое массива
Console.WriteLine("Исходное ");
for (int i = 0; i < jagged[0].Length; i++)
    Console.Write(jagged[0][i] + " ");
Console.WriteLine();
for (int i = 0; i < jagged[1].Length; i++)
    Console.Write(jagged[1][i] + " ");
Console.WriteLine();
for (int i = 0; i < jagged[2].Length; i++)
    Console.Write(jagged[2][i] + " ");
Console.WriteLine();

// Сортировка массива
for (int i = 0; i < jagged[0].Length; i++)
    Array.Sort(jagged[0]);
for (int i = 0; i < jagged[1].Length; i++)
    Array.Sort(jagged[1]);
for (int i = 0; i < jagged[2].Length; i++)
    Array.Sort(jagged[2]);

// Отсортированное 
Console.WriteLine("Отсортированное ");
for (int i = 0; i < jagged[0].Length; i++)
    Console.Write(jagged[0][i] + " ");
Console.WriteLine();
for (int i = 0; i < jagged[1].Length; i++)
    Console.Write(jagged[1][i] + " ");
Console.WriteLine();
for (int i = 0; i < jagged[2].Length; i++)
    Console.Write(jagged[2][i] + " ");

Console.ReadKey(); */

/* int[][] jagged = new int[3][]; //Пример 2 сортировк элем строк
            jagged[0] = new int[4];//кол элемен
            jagged[1] = new int[3];
            jagged[2] = new int[5];
 
            // Заполняем массив случайными числами
            Random random = new Random();
            for (int i = 0; i < jagged.Length; i++)//не более int [] строк
            {
                for (int j = 0; j < jagged[i].Length; j++)
                    jagged[i][j] = random.Next(-10, 10);
            } 
            // Исходное 
            Console.WriteLine("Исходное ");
            foreach (int[] item in jagged)
            {
                foreach (int element in item)
                    Console.Write(element + " ");
                Console.WriteLine();
            }
 
            // Сортировка массива
            foreach (int[] item in jagged)
            {
                foreach (int element in item)
                    Array.Sort(item);
            }
 
            // Отсортированное 
            Console.WriteLine("Отсортированное ");
            foreach (int[] item in jagged)
            {
                foreach (int element in item)
                    Console.Write(element + " ");
                Console.WriteLine();
            } */
 
        
       