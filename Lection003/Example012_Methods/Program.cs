//В данных примерах, вызов методов будем брать в //.

// Вид 1
//Ничего не возвращают, ничего не принимают.

// Метод с текстом, например, авторство в конце.
void Method1()
{
      Console.WriteLine("Автор ...");
}
//Вызов метода:
//Method1();

// Вид 2
// Ничего не возвращают, но могут принемать аргументы.

void Method2(string msg)
{
      Console.WriteLine(msg);
}
//Вызов:
//Method2(msg: "Текст сообщения");

//Вывод сообщения несколько раз
void Method21(string msg, int count)
{
      int i = 0;
      while (i < count)
      {
            Console.WriteLine(msg);
            i++;
      }
}
//Вывод:
//Method21("Текст", 4);
//Можно использовать именование аргументов
//Method21(count: 4, msg: "новый текст");

//Вид 3.
//Возвращают, но не принимают.
// Как пример, будет возвращать год.
int Method3()
{
      return DateTime.Now.Year;
}
//Присвоим индитификатор переменной
int year = Method3();
//Вывод:
//Console.WriteLine(year);

// Вид 4.
// Принимают и возвращают.
// Будем строку компановать несколько раз
string Method4(int count, string text)
{
      //int i = 0;
      //Добавим пустую строку
      string result = String.Empty;
      // while (i < count)
      // {
      //       result = result + text;
      //       i++;
      // }
      // return result;
      //Запишим тожесамое через for
      for (int i = 0; i < count; i++)
      {
            result = result + text;
      }
      return result;
}
//Назначаем переменную
string res = Method4(10, "z");
//Вывод
//Console.WriteLine(res);

//Таблица умножения через цикл for
for (int i = 2; i <= 10; i++)
{
      for (int j = 2; j <= 10; j++)
      {
            //Запишим вывод через интерполяцию строк
            //Console.WriteLine($"{i} x {j} = {i * j}");
      }
      //Разделитель после блока
      //Console.WriteLine("-------------");
}

//======Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

//Будем менять символы
string Replace(string text, char oldValue, char newValue)
{
      string result = String.Empty;

      int length = text.Length;
      for (int i = 0; i < length; i++)
      {
            if (text[i] == oldValue) result = result + $"{newValue}";
            else result = result + $"{text[i]}";
      }

      return result;
}

string newText = Replace(text, ' ', '|');
//вывод
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

// //Алгоритм сортировки методом выбора, сортировки минмакс, методом максимального

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// //Создадим метод для выведения массива
// void PrintArray(int[] array)
// {
//       int count = array.Length;

//       for (int i = 0; i < count; i++)
//       {
//             Console.Write($"{array[i]} ");
//       }
//       Console.WriteLine();
// }

// //Напишем метод сортировки массива
// void SelectionSort(int[] array)
// {
//       for (int i = 0; i < array.Length - 1; i++)
//       {
//             int MinPosition = i;

//             for (int j = i + 1; j < array.Length; j++)
//             {
//                   if (array[j] < array[MinPosition]) MinPosition = j;
//             }
//             int temporary = array[i];
//             array[i] = array[MinPosition];
//             array[MinPosition] = temporary;
//       }
// }

// //Выводим начальный массив
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);


//Алгоритм сортировки методом выбора, сортировки минмакс, методом максимального,от максимального к мин

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
//Создадим метод для выведения массива
void PrintArray(int[] array)
{
      int count = array.Length;

      for (int i = 0; i < count; i++)
      {
            Console.Write($"{array[i]} ");
      }
      Console.WriteLine();
}

//Напишем метод сортировки массива
void SelectionSort(int[] array)
{
      for (int i = 0; i < array.Length - 1; i++)
      {
            int MaxPosition = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                  if (array[j] > array[MaxPosition]) MaxPosition = j;
            }
            int temporary = array[i];
            array[i] = array[MaxPosition];
            array[MaxPosition] = temporary;
      }
}

//Выводим начальный массив
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);