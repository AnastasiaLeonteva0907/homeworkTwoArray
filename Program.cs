Console.Clear();

// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// void InputMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(10, 100);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + "\t"); // \t табуляция в выводе
//         Console.WriteLine();
//     }
// }

// void ReleaseMatrix(int[,] matrix)
// {
//     int[] elements = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
//     int x = elements[0];
//     int y = elements[1];
//     int result = 0;
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)

//         if (i == x && j == y )
//         result ++;
//     }
//     if ( result > 0)
//        Console.WriteLine($"Элемент {x}, {y} существует"); 
//         else
//             Console.WriteLine("Такого элемента нет");
// }

// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // [2, 5]
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.Write("Введите позиции элемента марицы: ");
// ReleaseMatrix(matrix);


// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    for(int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = new Random().Next(100, 500);
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
    for(int j = 0; j < matrix.GetLength(1); j++)
     Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] newmatrix)
{
    int tmp = newmatrix[0,0];
    for(int m = 0; m < newmatrix.GetLength(0); m++)

    {
       
        tmp = newmatrix[newmatrix.GetLength(0)-1, m];
        newmatrix[newmatrix.GetLength(0)-1, m] = newmatrix[0, m];
        newmatrix[0, m] = tmp;
    }

        for (int k = 0; k < newmatrix.GetLength(0); k++)
            {
                for (int m = 0; m < newmatrix.GetLength(1); m++)
                {
                    Console.Write($"{newmatrix[k,m]}\t");
                }
                Console.WriteLine();
            }
    
}

Console.Write("Введите размер матрицы: ");
int [] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrix = new int [size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
int[,] newmatrix = matrix;
ReleaseMatrix(newmatrix);

// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// void InputMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(0, 10);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + "\t");
//         Console.WriteLine();
//     }
// }

// void ReleaseMatrix(int[,] matrix)
// {
//     int[] avg = new int[matrix.GetLength(0)];
//     int summa;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         summa = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             summa += matrix[i, j]; 
//         avg[i] = summa;
//     }
//     Console.WriteLine("Суммы строк: " + string.Join(", ", avg));


//     int index = 0;
//     int min = avg [0];
//     for(int k = 0; k < avg.Length; k++)
//     {
//     if(min >= avg[k])
//     {
//     min = avg[k];
//     index = k +1 ;
//     }
     
//     }

//     Console.WriteLine($"Строка с наименьшей суммой элементов: { index }");
// }


// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // [2, 5]
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// ReleaseMatrix(matrix);


// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца

