
// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// Пример: 
//   M = 1; N = 5 -> "1, 2, 3, 4, 5" 
//   M = 4; N = 8 -> "4, 5, 6, 7, 8"


// Console.WriteLine($"Введите первое чмсло: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Введите второе чмсло: ");
// int num2 = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine();

// int firstNum = num;                 
// int secondNum = num2;

// void PrintNumbers(int startNum, int endNum)
// {
//     Console.Write(startNum);

//     if (startNum >= endNum)
//     {
//         return;
//     }
//     PrintNumbers(startNum + 1, endNum );     
                                            
// }
// PrintNumbers(firstNum, secondNum);



// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Пример:    m = 2, n = 3 -> A(m,n) = 29


// Console.WriteLine($"Введите первое чмсло: ");
// int num = Convert.ToInt32(Console.ReadLine()); 

// Console.WriteLine($"Введите второе чмсло: ");
// int num2 = Convert.ToInt32(Console.ReadLine());  

// Console.WriteLine();

// int result = Ackermann(num, num2);
// Console.WriteLine($"A({num}, {num2}) = {result}");


// int Ackermann(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n == 0)
//     {
//         return Ackermann(m - 1, 1);
//     }
//     if (m > 0 && n > 0)
//     {
//         return Ackermann(m - 1, Ackermann(m, n - 1));
//     }
//     else
//     {
//         return -1;
//     }
// }



// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
// Пример:     [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1



// using System;
// class Program
// {
//     static void Main()
//     {
//         int[] array = { 2, 14, 3, 8, 46, 9 };
//         foreach (var element in array)         // Для вывода массива на консоль
//         {
//             Console.Write(element + " ");
//         }

//         Console.WriteLine();

//         Console.WriteLine("Элементы массива, начиная с конца:");
//         PrintArrayReversed(array, array.Length - 1);
//     }
//     static void PrintArrayReversed(int[] array, int index)
//     {
//         if (index >= 0)
//         {
//             Console.Write(array[index] + " ");
//             PrintArrayReversed(array, index - 1);
//         }

//     }
// }