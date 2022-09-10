// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь
//  содержит информацию о том, сколько раз встречается элемент входных данных. 
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6 
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза 
// В нашей исходной матрице встречаются элементы от 0 до 9 


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

void PrintRepeatsOfElements(int[,] matrix)
{
    int[] repeats = new int[10];//создали из нулей массив новый имя может быть countins repeats, на 10 мест

    for (int i = 0; i < matrix.GetLength(0); i++)//до длины строк 3, записываем сюда!!!!!!!!наш новый массив, 1 встреч n раз и т.д.
    {                                                       //[0] [1] [2] [3] .. индексы и по ним в значен пишем кол раз 1цы, 2ки 3ки
        for (int j = 0; j < matrix.GetLength(1); j++)// до длины столб 4
        {
            //  int index=matrix[i,j]; repeats[index]++; вместо этих двух 
            repeats[matrix[i, j]]++;//взять repeats по индексу наш массива 
        }
    }
    for (int i = 0; i < repeats.Length; i++)// это длина нов массива
    {
        if (repeats[i] > 0)//колич повтор элемента
        {
            Console.WriteLine($"Количество повторений {i} = {repeats[i]}");
        }
    }
}
int[,] ourMatrix = GetMatrix(3, 4, 0, 9);
PrintMatrix(ourMatrix);
PrintRepeatsOfElements(ourMatrix);

