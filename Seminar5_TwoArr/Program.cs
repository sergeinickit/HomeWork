

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