﻿//Задаём двумерный массив
string[,] table = new string[2, 5];
//table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
//table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]

// //в первую строку, второй столбец кладём слово
// table[1, 2] = "слово";
// //метод вывода на экран
// for (int rows = 0; rows < 2; rows++)
// {
//       for (int columns = 0; columns < 5; columns++)
//       {
//             Console.WriteLine($"-{table[rows, columns]}-");
//       }
// }

// //Вывод такого массива в строки
// int[,] matrix = new int[3,4];
// for (int i = 0; i < matrix.GetLength(0); i++) //заменим число строк(3) на GetLength(0 - первое число массива)
// {
//       for (int j = 0; j < matrix.GetLength(1); j++) //заменим число строк(4) на GetLength(1 - второе число массива)
//       {
//             Console.Write($"{matrix[i, j]} ");
//       }
//       Console.WriteLine();
// }

// //запишим метод вывода и заполнения такого массива
// //Метод вывода
// void PrintArrey(int[,] matr)
// {
//       for (int i = 0; i < matr.GetLength(0); i++)
//       {
//             for (int j = 0; j < matr.GetLength(1); j++)
//             {
//                   Console.Write($"{matr[i, j]} ");
//             }
//             Console.WriteLine();
//       }
// }
// //метод заполнения
// void FilltArrey(int[,] matr)
// {
//       for (int i = 0; i < matr.GetLength(0); i++)
//       {
//             for (int j = 0; j < matr.GetLength(1); j++)
//             {
//                   matr[i, j] = new Random().Next(1, 10);
//             }
//       }
// }

// int[,] matrix = new int[3, 4];
// PrintArrey(matrix);
// Console.WriteLine("----------");
// FilltArrey(matrix);
// PrintArrey(matrix);

//Рисунок и его закраска

// int[,] pic = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrintImage(int[,] image)
// {
//       for (int i = 0; i < image.GetLength(0); i++)
//       {
//             for (int j = 0; j < image.GetLength(1); j++)
//             {
//                   //Console.Write($"{image[i, j]} ");
//                   if (image[i, j] == 0) Console.Write($" ");
//                   else Console.Write($"+");
//             }
//             Console.WriteLine();
//       }
// }

// //Метод закраски с определённой точки
// void FillImege(int row, int col)
// {
//       if (pic[row, col] == 0)
//       {
//             pic[row, col] = 1;
//             //Обращаемся к самому методу.
//             FillImege(row - 1, col);
//             FillImege(row, col - 1);
//             FillImege(row + 1, col);
//             FillImege(row, col + 1);
//       }
// }

// PrintImage(pic);
// FillImege(13, 13);
//PrintImage(pic);


// //Работа с факториалом
// //Через int расчитает только до 16!, для дальнейшего используем double
// double Factorial(int n)
// {
//       //1! = 1
//       //0! = 1
//       if (n == 1) return 1;
//       else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//       Console.WriteLine($"{i}! = {Factorial(i)}");
// }

//Числа Фибоначчи
//f(1) = 1
//f(2) = 1
//f(n) = f(n-1)+f(n-2)

int Fibonacci(int n)
{
      if (n == 1 || n == 2) return 1;
      else return (Fibonacci(n - 1) + Fibonacci(n - 2));
}
for (int i = 1; i < 40; i++)
{
      Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}