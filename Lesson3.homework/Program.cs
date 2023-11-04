using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson3.homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Напечатать весь массив целых чисел:
            int[] numbers = { 10, 20, 15, 25, 5 };
            Console.WriteLine("1 Задание:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            //2.Найти индекс максимального значения в массиве:
            Console.WriteLine("2 Задание:");
            int maxIndex = Array.IndexOf(numbers, numbers.Max());
            Console.WriteLine("Индекс максимального значения: " + maxIndex);
            //3.Найти индекс максимального четного значения в массиве:
            Console.WriteLine("3 Задание:");
            int maxEvenIndex = Array.IndexOf(numbers, numbers.Where(n => n % 2 == 0).Max());
            Console.WriteLine("Индекс максимального четного значения: " + maxEvenIndex);
            //4. Удалить элемент из массива по индексу:
            Console.WriteLine("4 Задание:");
            int indexToRemove = 2; // Индекс элемента для удаления
            if (indexToRemove >= 0 && indexToRemove < numbers.Length)
            {
                int[] newArray = new int[numbers.Length - 1];
                for (int i = 0, j = 0; i < numbers.Length; i++)
                {
                    if (i == indexToRemove)
                        continue; // Пропускаем элемент, который нужно удалить
                    newArray[j] = numbers[i];
                    j++;
                }

                numbers = newArray;


            }
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            //5. Удаление элементов из массива по значению:
            Console.WriteLine("5 Задание:");
            int valueToRemove = 10; // Значение для удаления
            numbers = numbers.Where(n => n != valueToRemove).ToArray();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            //6.Вставить элемент в массив по индексу
            Console.WriteLine("6 Задание:");
            int indexToInsert = 2; // Индекс для вставки
            int valueToInsert = 20; // Значение для вставки
            numbers = numbers.Take(indexToInsert).Concat(new[] { valueToInsert }).Concat(numbers.Skip(indexToInsert)).ToArray();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            //7. Удалить из строки слова, в которых есть буква 'a':
            Console.WriteLine("7 Задание:");
            string inputText = "I don't know what to write.";

            // Используем регулярное выражение для поиска слов с буквой 'a'
            string pattern = @"\b\w*a\w*\b";

            // Заменяем найденные слова на пустую строку
            string result = Regex.Replace(inputText, pattern, "");

            Console.WriteLine("Исходный текст:");
            Console.WriteLine(inputText);
            Console.WriteLine("Текст после удаления слов с буквой 'a':");
            Console.WriteLine(result);

            //8. Удалить из строки слова, в которых есть хоть одна буква последнего слова:
            Console.WriteLine("8 Задание:");
            string Text = "This is a sample text with some words that contain letters from the last word.";
            string[] words = Text.Split(' ');
            string lastWord = words[words.Length - 1].Trim(new char[] { '.', ',', '!', '?' }); // Последнее слово

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i].IndexOfAny(lastWord.ToCharArray()) == -1)
                {
                    Console.Write(words[i] + " ");
                }
            }

            Console.WriteLine(lastWord);
            //9.В строке выделить квадратными скобками слова, которые начинаются и заканчиваются одной буквой:
            Console.WriteLine("9 Задание:");
            string text = "This is a sample text with some words that contain letters from the last word.";
            string pattern1 = @"\b(\w)\w*\1\b";
            string result2 = Regex.Replace(text, pattern1, "[$0]");
            Console.WriteLine(result2);
        }
    }
}
