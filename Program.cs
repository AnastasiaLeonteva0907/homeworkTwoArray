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

// void InputMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     for(int j = 0; j < matrix.GetLength(1); j++)
//         matrix[i, j] = new Random().Next(100, 1000);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//      Console.Write(matrix[i, j] + "\t");
//         Console.WriteLine();
//     }
// }

// void ReleaseMatrix(int[,] newmatrix)
// {
    
//     for(int i = 0; i < newmatrix.GetLength(0); i++)
//         for(int j = 0; j < newmatrix.GetLength(1)/2; j++)
//          int Fix = newmatrix[j];
//    newmatrix [j] = newmatrix[newmatrix.GetLength-j-1];
//    newmatrix[newmatrix.GetLength-j-1] = Fix;

// }

// Console.Write("Введите размер матрицы: ");
// int [] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int [,] matrix = new int [size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// int[,] newmatrix = matrix;
// ReleaseMatrix(newmatrix);

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

// }

// void MinStringMatrix(int [] avg )
// {
//     int index = 0;
//     int min = 0;
//     for(int k = 0; k < avg.Length; k++)
//     {
//     min = avg[0];
//     if(min >= avg[k])
//     {
//     min = avg[k];
//     index = k;
//     }
     
//     }
//    Console.WriteLine($"число {min}");
//     Console.WriteLine($"индекс {index}");
//     Console.WriteLine($"Строка с наименьшей суммой элементов: { index + 1 }");
// }

// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // [2, 5]
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// ReleaseMatrix(matrix);
// int[] avg = new int[matrix.GetLength(0)];
// MinStringMatrix(avg);


Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];

void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
for (j = 0; j < n; j++)
{
randomArray[i,j] = rand.Next(1,9);
}
}
}

void printm(int[,] array)
{
int i,j;
for (i = 0; i < array.GetLength(0); i++)
{
Console.WriteLine();
for (j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i,j]} ");
}
Console.WriteLine();
}
}

mas(m,n);
Console.WriteLine("\nИсходный массив:" );
printm(randomArray);

// Функция, считающая сумму элементов в строке
int SumLine(int[,] array, int i)
{
int sum = array[i,0];
for (int j = 1; j < array.GetLength(1); j++)
{
sum += array[i,j];
}
return sum;
}

int minSum = 1;
int sum = SumLine(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i++)
{
if (sum > SumLine(randomArray, i))
{
sum = SumLine(randomArray, i);
minSum = i+1;
}
}
Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");


// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца

