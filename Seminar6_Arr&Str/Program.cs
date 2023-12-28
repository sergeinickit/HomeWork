// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// Пример:  a b c => “abcdef”
//          d e f 
// using System.Data;

// class Program
// {
//    static void Main()
//    {
//        char[,] charArray = GenerateRandomCharArray(3,3);
       
//        PrintCharArray(charArray);

//        string str = GetStringFromArrayChar(charArray);
//        Console.WriteLine(str + " ");
//    }

//     static char[,] GenerateRandomCharArray(int rows, int columns)
//     {
//         char[,] resultArray = new char[rows, columns];
//         Random random = new Random();

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 char randomChar = (char)random.Next('a','z'+1);
//                 resultArray[i,j] = randomChar;
//             }
//         }
//         return resultArray;
//     }

//     static void PrintCharArray(char[,] charArray)
//     {
//         for (int i = 0; i < charArray.GetLength(0); i++)
//         {
//              for (int j = 0; j < charArray.GetLength(1); j++)
//              {
//                  Console.Write(charArray[i,j] + " ");
//              }
//              Console.WriteLine();
//         }
//     }

//       static string GetStringFromArrayChar(char[,] charArray)      
//     {
//         int rows = charArray.GetLength(0);
//         int columns = charArray.GetLength(1);

//         char[] elements = new char[rows * columns];      

//         for (int i = 0; i < rows; i++)
//           {
//             for (int j = 0; j < columns; j++)
//             {
//                 elements[i * columns + j ] = charArray[i,j];

//             }        
//           } 
//           string result = new string(elements);
//           return result;
//     } 
// } 


// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// Пример:   “aBcD1ef!-” => “abcd1ef!-”

// string inputString = "'A','f','b','M','c','z','F'";  
//  string str = "";                                    

// string GetStringFromArrayChar()     
// {
//   string result="";                 
//   for (int i = 0; i < inputString.Length; i++)    
//   {
//      result = result + inputString[i];    
//   }
//   return result;                   
// }
// str = GetStringFromArrayChar();    
// System.Console.WriteLine(str);

// string lowerCaseString = ToLowerCase(inputString);    

// Console.WriteLine(lowerCaseString);

// string ToLowerCase(string input)          
// {
//     return input.ToLower();
// }



// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// Пример:   “aBcD1ef!-” => Нет
//           “шалаш” => Да
//           “55655” => Да

Console.Write("Введите слово: ");      // Запрос у пользователя
// #pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
string str = Console.ReadLine();       // Чтение введенной строки
// #pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
if(IsPalindrome(str))
{
  Console.WriteLine("Да");
}
else
{
  Console.WriteLine("Нет");
}

// Console.WriteLine(str);                // Вывод строки
char[] elemtnts = new char [str.Length];                                     // Создаем прерменную

string GetStringFromArrayChar()     // Если нужен результат, который будем возвращать и передовать дальше заводим string
{
  string result="";                 // Создаем переменную типа string (пока пустая)
  for (int i = 0; i < elemtnts.Length; i++)    // Заполняем переменную
  {
     result = result + elemtnts[i];   // В переменную str записываем каждый элеменет массива elemets[]  
  }
  return result;                   // Наша функция сработала и её результатом будет result
}
str = GetStringFromArrayChar();    // Заполняем тем, что получилось в нашей функции str = и дальше выводим
System.Console.WriteLine();

bool IsPalindrome(string str)       // Функция для прверки, является ли строка палиндромом
{
  str = str.ToLower();              // Приведение строки к нижнему регистру для учета регистра букв

  str = str.Replace(" ","");        // Удаление пробелов из строки

  string reversed = new string(str.ToCharArray().Reverse().ToArray());      // Создание обратной копии строки

  return str == reversed;           // Сравнение исходной строки с ее обратной копией
}

