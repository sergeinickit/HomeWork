
// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Пример:
// [344 452 341 125] => 2

//  System.Console.WriteLine("Введите размер массива");        
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num]; 

// CreateArray();  

//  int[] CreateArray()     
// {
//    for (int i = 0; i < array.Length; i++)    
//      {
//          array[i] = new Random().Next(100, 1000);
//          System.Console.WriteLine(array[i] + " ");     
//      }
//      return array; 
// }

//   Console.WriteLine();

//   int evenCount = CountEvenNumbers(array);
//   Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");

//   static int CountEvenNumbers(int[] array)
//   {
//     int evenCount = 0;
//     foreach(int number in array)
//     {
//         if(number %2 == 0)
//         {
//             evenCount++;
//         }
//     }
//     return evenCount;
//   }


// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
// Пример:
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

//  System.Console.WriteLine("Введите размер массива");        
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num]; 

// CreateArray();  

//  int[] CreateArray()     
// {
//    for (int i = 0; i < array.Length; i++)    
//      {
//          array[i] = new Random().Next(0, 10);
//          System.Console.Write(array[i] + " ");     
//      }
//      return array; 
// }

//   Console.WriteLine();

// int temp = 0;

// for (int i = 0; i < array.Length/2; i++)    
//      {
//         temp = array[i];
//         array[i] = array[array.Length -1 -i];
//         array[array.Length -1 -i] = temp;
//      }
// System.Console.WriteLine("Перевернутый массив:");

// for (int i = 0; i < array.Length; i++) 
// {
//     System.Console.Write(array[i] + " ");
// }

// Вариант 2.(с исправлениями ChartGPT)

// using System;

// class Program
// {
//     static void Main()
//     {
//         System.Console.WriteLine("Введите размер массива");
//         int num = Convert.ToInt32(Console.ReadLine());
//         int[] array = CreateArray(num);

//         System.Console.Write("Исходный массив: ");
//         PrintArray(array);

//         int[] reversedArray = ArrReverse(array);
//         System.Console.Write("Обратный массив: ");
//         PrintArray(reversedArray);
//     }

//     static int[] CreateArray(int size)
//     {
//         int[] array = new int[size];
//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = new Random().Next(0, 10);
//             System.Console.Write(array[i] + " ");
//         }
//         System.Console.WriteLine();
//         return array;
//     }

//     static void PrintArray(int[] array)
//     {
//         foreach (int element in array)
//         {
//             System.Console.Write(element + " ");
//         }
//         System.Console.WriteLine();
//     }

//     static int[] ArrReverse(int[] array)
//     {
//         int[] reversedArray = new int[array.Length];
//         int index = array.Length - 1;

//         foreach (int element in array)
//         {
//             reversedArray[index] = element;
//             index--;
//         }

//         return reversedArray;
//     }
// }