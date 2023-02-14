//Данным методом мы закладываем в массив, в каждый его индекс,
// поочерёдно значения диапозоном 1-10.
//Команда void - метод не возвращает значения.
void FillArray(int[] collection)
{
      int length = collection.Length;
      int index = 0;
      while (index < length)
      {
            collection[index] = new Random().Next(1, 10);
            index++;
      }
}

// Метод выводит значения на экран.
void PrintArray(int[] col)
{
      int count = col.Length;
      int position = 0;
      while (position < count)
      {
            Console.WriteLine(col[position]);
            position++;
      }
}

//Данный метод ищет в массиве индекс, где лежит необходимое значение
int IndexOF(int[] collection, int find)
{
      int count = collection.Length;
      int index = 0;
      // Взяли -1, чтобы ошибка была сразу видна
      int position = -1;

      while (index < count)
      {
            if (collection[index] == find)
            {
                  position = index;
                  // Останавливает цикл на первом совпадающем условии
                  break;
            }
            index++;
      }
      return position;
}

//Команда new int[10] означает - создай новый массив, 
// длиной в 10 символов(по умолчанию - нули), 
//конструкция выше, заполняет числами.
int[] array = new int[10];

array[4] = 4;
array[6] = 6;

// Вводим наши методы
//Этот метод заполнит индексы массива числами
FillArray(array);

//Назначаем несколько индексов предустановленными значениями
array[4] = 4;
array[6] = 4;

// Выводим на экран получившийся массив
PrintArray(array);
//Просто отступ строки
Console.WriteLine();

//Используем метод, чтобы найти первый индекс в массиве,
// который отвечает искомому значению, тут 4.
//Если в рандомном массиве не будет данного условия - 
// - выведет -1, как мы и ввели в метод.
int pos = IndexOF(array, 4);
Console.WriteLine(pos);

