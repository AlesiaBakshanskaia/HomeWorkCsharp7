//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4.
/*
double[,] Array47 = GetArray2d (3, 4, -10, 10);
PrintArray2d(Array47);
*/

//Создание двухмерного массива с типом double
double [,] GetArray2d (int m, int n, int minel, int maxel){
    double[,] result = new double[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minel, maxel) + new Random().NextDouble();//если сделать maxel+1, то при выпадании в первом рандоме числа 10, а во втором 1 мы уйдем за заданные границы
        }
    }
return result;
}

// Печать двумерного массива с типом double

void PrintArray2d(double[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
         for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]:f1} ");
         }
         Console.WriteLine();
    }
}



//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Console.WriteLine("Ведите номер ряда элемента"); 
int i = int.Parse(Console.ReadLine()!) - 1;
Console.WriteLine("Ведите номер столбца элемента"); 
int j = int.Parse(Console.ReadLine()!) - 1;

int[,]Array50 = GetArray2(5, 10, 0, 9);
PrintArray2(Array50);

if (i < 0 || i > Array50.GetLength(0) - 1 || j < 0 || j > Array50.GetLength(1) - 1){
    Console.WriteLine("Такого элемента в данном массиве нет");
}
else {
    Console.WriteLine($"Значение заданного вами элемента равно {Array50[i, j]}");
}
*/

//Создание двухмерного массива
int [,] GetArray2 (int m, int n, int minel, int maxel){
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minel, maxel+1);
        }
    }
return result;
}

// Печать двумерного массива

void PrintArray2(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
         for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
         }
         Console.WriteLine();
    }
}


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,]Array52 = GetArray2(3, 4, 0, 9);
PrintArray2(Array52);
Console.Write("Среднее арифметическое по столбцам ");


for (int j = 0; j < Array52.GetLength(1); j++){
    double sum = 0;
    for (int i = 0; i < Array52.GetLength(0); i++){
            sum += Array52[i, j];
    }
    double res = sum/Array52.GetLength(0);
    Console.Write($"{res:f1} ");
}
Console.WriteLine("");