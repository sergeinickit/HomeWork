

// Задача 1: Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Пример:
// 4 3 1 (1,2) => 9
// 2 6 9 

// using System;

// class Program
// {
//     static int[,] array;

//     static void Main()
//     {
//         Console.Write("Введите количество строк: ");
//         int rows = int.Parse(Console.ReadLine());

//         Console.Write("Введите количество столбцов: ");
//         int columns = int.Parse(Console.ReadLine());

//         array = new int[rows,columns]; 

//         CreateArray();
//         PrintArray();
//         // GetElementValue();

//         Console.Write("Введите номер строки: ");
//         int row = int.Parse(Console.ReadLine()); 

//         Console.Write("Введите номер столбца: ");
//         int column = int.Parse(Console.ReadLine());

//         int elementValue = GetElementValue(row, column);
//         Console.WriteLine($"Значение элемента в строке {row}, столбце {column}: {elementValue} ");
//     }
                                 
//     static void CreateArray()       
//     {
//          for (int i = 0; i < array.GetLength(0); i++)   
   
//          {
//              for (int j = 0; j < array.GetLength(1); j++)  
//              {
//                  array[i, j] = new Random().Next(1, 10);        
//              }
                   
//          }
//     }

//     static void PrintArray()          
//     {
//         for (int i = 0; i < array.GetLength(0); i++) 
//         {
//             for (int j = 0; j < array.GetLength(1); j++)  
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();                   
//         }
//     }

//     static int GetElementValue(int row, int column)       
//     {
//              if(row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
//            {
//               return array[row, column];
//            }
//             Console.WriteLine("Некорректные индексы!");
//            return -1;              
//     }  
// }


// Задача 2: Задайте двумерный массив. Напишите 
// программу, которая поменяет местами первую и 
// последнюю строку массива
// Пример:
// 4 3 1 => 4 6 2
// 2 6 9    2 6 9
// 4 6 2    4 3 1

// int[,]? array = new int[5,3];

// void CreateArray()       
// {
//     for (int i = 0; i < array.GetLength(0); i++)    
   
//     {
//         for (int j = 0; j < array.GetLength(1); j++)  
//         {
//             array[i,j] = new Random().Next(1,10);        
//         }
//     }
// }  

// CreateArray();
// PrintArray();
// Exchange();

//  void PrintArray()          
//  {
//      for (int i = 0; i < array.GetLength(0); i++) 

//     {
//         for (int j = 0; j < array.GetLength(1); j++)  
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//       System.Console.WriteLine();                   
//     }
//     System.Console.WriteLine();      

//  } 

// void Exchange()
// {
//     int numberOfRows = array.GetLength(0);
//     int numberOfColumns = array.GetLength(1);

//      int[] firstRow = new int[numberOfColumns];

//     // for (int j = 0; j < numberOfColumns; j++)
//     // {
//     //     firstRow [j] = array[0, j];
//     // }
    
//     // Console.WriteLine("Первая строка:");
//     // foreach (int element in firstRow)
//     // {
//     //     Console.Write(element + " ");
//     // }

//     // Console.WriteLine();

//     // int[] lastRow = new int [numberOfColumns];
//     // for (int j = 0; j < numberOfColumns; j++)
//     // {
//     //     lastRow[j] = array[numberOfRows -1, j];
//     // }
//     // Console.WriteLine("Последняя строка:");
//     // foreach (int element in lastRow)
//     // {
//     //    Console.Write(element + " "); 
//     // }

//     // Console.WriteLine();

//     for (int j = 0; j < numberOfColumns; j++)     
//     {
//         firstRow[j] = array[0,j];
//     }


//     for (int j = 0; j < numberOfColumns; j++)      
//     {
//         array[0,j] = array[numberOfRows -1, j];
//     }

//     for (int j = 0; j < numberOfColumns; j++)       
//     {
//         array[numberOfRows -1,j] = firstRow[j];
//     }

//     Console.WriteLine("Массив после замены:");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j]+ " ");
//         } 
//       Console.WriteLine(); 
//     }
//     Console.WriteLine();
// }


// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов
// Пример:
// 4 3 1 => Строка с индексом 0
// 2 6 9
// 4 6 2 

// int[,] array = new int[3,4];

// void CreateArray()       
// {
//     for (int i = 0; i < array.GetLength(0); i++)    
   
//     {
//         for (int j = 0; j < array.GetLength(1); j++)  
//         {
//             array[i,j] = new Random().Next(1,10);        
//         }
//     }
    
// }  

// CreateArray();
// PrintArray();
// SumEiements();

//  void PrintArray()          
//  {
//      for (int i = 0; i < array.GetLength(0); i++) 

//     {
//         for (int j = 0; j < array.GetLength(1); j++)  
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//       System.Console.WriteLine();                   
//     }
//     System.Console.WriteLine();      
//  } 
//  void SumEiements()
//  {
//     int numberOfRows = array.GetLength(0);
//     int numberOfColumns = array.GetLength(1);

//     int minSum = int.MaxValue;
//     int minSumRowIndex = -1;

//     for (int i = 0; i < numberOfRows; i++)
//     {
//         int sum =  0;

//         for (int j = 0; j < numberOfColumns; j++)
//         {
//             sum += array[i,j];
//         }

//         if(sum < minSum)
//         {
//             minSum = sum;
//             minSumRowIndex = i;
//         }
//     }
//     Console.WriteLine($"Строка с индексом: { minSumRowIndex }");
//     Console.WriteLine($"Сумма элементов в строке: {minSum}");
   
//  }