// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("Задача 47. Задайте двумерный массив размером MxN, заполненный случайными вещественными числами.");
// общий массив на все задачи
Console.Write("\tВведите кол-во строк массива (M): ");
int n,m;
while (!(int.TryParse(Console.ReadLine(), out m)))
    Console.Write("\tВведите кол-во строк массива (M): ");
Console.Write("\tВведите кол-во столбцов массива (N): ");
while (!(int.TryParse(Console.ReadLine(), out n)))
    Console.Write("\tВведите кол-во столбцов массива (N): ");
if (m <=0 | n<=0){
    Console.WriteLine("Указан неверный размер массива");
    return;
}
double[,] arr = new double[m,n];
Random rnd = new Random();
Console.Write($"Массив {m}x{n}:");
for (int i=0; i<m; i++){ // Задача 47. Задайте двумерный массив размером MxN, заполненный случайными вещественными числами.
    Console.Write("\n");
    for (int j=0; j<n; j++ ){
        arr[i,j] = Math.Round(rnd.NextDouble()*20-10,2);
        Console.Write($"\t{arr[i,j]}");
    }
}
Console.WriteLine("\nЗадача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
n = new int();
m = new int();
    Console.Write("\tВведите строку элемента: ");
while (!(int.TryParse(Console.ReadLine(), out m)))
    Console.Write("\tВведите строку элемента: ");
Console.Write("\tВведите кол-во столбец элемента: ");
while (!(int.TryParse(Console.ReadLine(), out n)))
    Console.Write("\tВведите кол-во столбец элемента: ");
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
if ((m >0 & n>0) & (m <= arr.GetUpperBound(0) + 1) & (n<=arr.GetUpperBound(1)+1)){
    Console.WriteLine($"Значение в [{m}, {n}]: {arr[m-1,n-1]}");
}
else
    Console.WriteLine("Такого элемента нет");

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("\nЗадача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.Write($"Массив [{arr.GetUpperBound(0)+1},{arr.GetUpperBound(1)+1}]");
double[] sum = new double[arr.GetUpperBound(1)+1];
for (int i=0; i<arr.GetUpperBound(0)+1; i++){ 
    Console.Write("\n");
    for (int j=0; j<arr.GetUpperBound(1)+1; j++ ){
        arr[i,j] = rnd.Next(-10,10);
        Console.Write($"\t{arr[i,j]}");
        sum[j] += Math.Round(arr[i,j],2);
    }
}
Console.WriteLine("\nСреднее арифметическое столбцов:");
foreach (int i in sum){
    Console.Write($"\t{(double)i/(arr.GetUpperBound(0)+1)}");
}