// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// Пример:  a b c => “abcdef”
//          d e f 
using System.Data;

class Program
{
   static void Main()
   {
       char[,] charArray = GenerateRandomCharArray(3,3);
       
       PrintCharArray(charArray);

       string str = GetStringFromArrayChar(charArray);
       Console.WriteLine(str + " ");
   }

    static char[,] GenerateRandomCharArray(int rows, int columns)
    {
        char[,] resultArray = new char[rows, columns];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                char randomChar = (char)random.Next('a','z'+1);
                resultArray[i,j] = randomChar;
            }
        }
        return resultArray;
    }

    static void PrintCharArray(char[,] charArray)
    {
        for (int i = 0; i < charArray.GetLength(0); i++)
        {
             for (int j = 0; j < charArray.GetLength(1); j++)
             {
                 Console.Write(charArray[i,j] + " ");
             }
             Console.WriteLine();
        }
    }

    // static string GetStringFromArrayChar(char[,] charArray)      
    // {
    //     int rows = charArray.GetLength(0);
    //     int columns = charArray.GetLength(1);

    //     char[] elements = new char[rows * columns * 2 -1];        // Чтобы увеличить пробел между символами умножаем на 2

    //     for (int i = 0; i < rows; i++)
    //       {
    //         for (int j = 0; j < columns; j++)
    //         {
    //             elements[i * (columns * 2 -1) + j * 2] = charArray[i,j];

    //             if(j < columns -1)                    // И еще вводится if, чтобы правильно вывести
    //             {
    //                 elements[i * (columns * 2 -1) + j * 2 +1] = ' ';    // Ну и формула ... = ' ';
    //             }
    //         }        
    //       } 
    //       string result = new string(elements);
    //       return result;
    // } 

      static string GetStringFromArrayChar(char[,] charArray)      
    {
        int rows = charArray.GetLength(0);
        int columns = charArray.GetLength(1);

        char[] elements = new char[rows * columns];      

        for (int i = 0; i < rows; i++)
          {
            for (int j = 0; j < columns; j++)
            {
                elements[i * columns + j ] = charArray[i,j];

            }        
          } 
          string result = new string(elements);
          return result;
    } 
}
