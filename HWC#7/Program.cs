//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4.

double[,] Array47 = GetArray2 (3, 4, -10, 10);
PrintArray2(Array47);


//Создание двухмерного массива
double [,] GetArray2 (int m, int n, int minel, int maxel){
    double[,] result = new double[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minel, maxel) + new Random().NextDouble();//если сделать maxel+1, то при выпадании в первом рандоме числа 10, а во втором 1 мы уйдем за заданные границы
        }
    }
return result;
}

// Печать двумерного массива

void PrintArray2(double[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
         for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]:f1} ");
         }
         Console.WriteLine();
    }
}