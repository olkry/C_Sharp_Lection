// // Метод с рекурсией, который собирает слова из заданных символов
// int n = 1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//       if (length == word.Length)
//       {
//             Console.WriteLine($"{n++} {new String(word)}"); return;
//       }
//       for (int i = 0; i < alphabet.Length; i++)
//       {
//             word[length] = alphabet[i];
//             FindWords(alphabet, word, length + 1);
//       }
// }
// FindWords("аисв", new char[4]);

// //Работ с коталогом.Дата создания.
// string path = "C:/Учёба/3. Знакомство с языками/C#_Lection/C_Sharp_Lection";
// DirectoryInfo di = new DirectoryInfo(path);
// Console.WriteLine(di.CreationTime);

// //Метод.Игра в пирамидки
// int n = 1;
// void Towers(string with = "1", string on = "3", string some = "2", int count = 5)
// {
//  if (count > 1) Towers(with, some, on, count - 1);
//  Console.WriteLine($"{n++}. {with} >> {on}");
//  if (count > 1) Towers(some, on, with, count - 1);
// }

// Towers();


