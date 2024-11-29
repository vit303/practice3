using System;
using System.Collections.Generic;

namespace practice3
{
    internal class Ex2
    {
        public static void Print()
        {
            Dictionary<int, string> dictionary = CreateAndFillDictionary();
            DisplayDictionary(dictionary);

            RemoveElementsFromDictionary(dictionary);
            DisplayDictionary(dictionary);

            AddNewElementsToDictionary(dictionary);
            DisplayDictionary(dictionary);

            Stack<string> stack = CreateStackFromDictionary(dictionary);
            DisplayStack(stack);

            SearchValueInStack(stack);
        }

        private static Dictionary<int, string> CreateAndFillDictionary()
        {
            return new Dictionary<int, string>
            {
                { 1, "Первый" },
                { 2, "Второй" },
                { 3, "Третий" },
                { 4, "Четвертый" },
                { 5, "Пятый" }
            };
        }

        private static void DisplayDictionary(Dictionary<int, string> dictionary)
        {
            Console.WriteLine("Содержимое коллекции (Dictionary):");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Ключ: {kvp.Key}, Значение: {kvp.Value}");
            }
            Console.WriteLine();
        }

        private static void RemoveElementsFromDictionary(Dictionary<int, string> dictionary)
        {
            Console.WriteLine("Введите количество удаляемых элементов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                dictionary.Remove(i);
            }
        }

        private static void AddNewElementsToDictionary(Dictionary<int, string> dictionary)
        {
            dictionary.Add(6, "Шестой");
            dictionary[7] = "Седьмой"; // Используем другой метод добавления
        }

        private static Stack<string> CreateStackFromDictionary(Dictionary<int, string> dictionary)
        {
            Stack<string> stack = new Stack<string>();
            foreach (var kvp in dictionary)
            {
                stack.Push(kvp.Value); // Добавляем только значение
            }
            return stack;
        }

        private static void DisplayStack(Stack<string> stack)
        {
            Console.WriteLine("Содержимое коллекции (Stack):");
            foreach (var item in stack)
            {
                Console.WriteLine($"Значение: {item}");
            }
            Console.WriteLine();
        }

        private static void SearchValueInStack(Stack<string> stack)
        {
            Console.WriteLine("Введите значение элемента для поиска: ");
            string searchValue = Console.ReadLine();
            bool found = stack.Contains(searchValue);
            Console.WriteLine($"Значение '{searchValue}' найдено в Stack: {found}");
        }
    }
}