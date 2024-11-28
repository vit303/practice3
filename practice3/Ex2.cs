using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3
{
    internal class Ex2
    {
        public static void Print() {
            // a) Создаем и заполняем первую коллекцию Dictionary<TKey, TValue>
            Dictionary<int, string> dictionary = new Dictionary<int, string>
        {
            { 1, "Первый" },
            { 2, "Второй" },
            { 3, "Третий" },
            { 4, "Четвертый" },
            { 5, "Пятый" }
        };

            // Выводим коллекцию на консоль
            Console.WriteLine("Первая коллекция (Dictionary):");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Ключ: {kvp.Key}, Значение: {kvp.Value}");
            }

            // b) Удаляем n элементов
            Console.WriteLine("Введите количество удаляемых элементов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                dictionary.Remove(i);
            }

            // Выводим коллекцию после удаления
            Console.WriteLine("\nПосле удаления элементов:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Ключ: {kvp.Key}, Значение: {kvp.Value}");
            }

            // c) Добавляем другие элементы
            dictionary.Add(6, "Шестой");
            dictionary[7] = "Седьмой"; // Используем другой метод добавления

            // Выводим коллекцию после добавления
            Console.WriteLine("\nПосле добавления новых элементов:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Ключ: {kvp.Key}, Значение: {kvp.Value}");
            }

            // d) Создаем вторую коллекцию Stack<T> и заполняем ее данными из первой коллекции
            Stack<string> stack = new Stack<string>();

            foreach (var kvp in dictionary)
            {
                stack.Push(kvp.Value); // Добавляем только значение
            }

            // e) Выводим вторую коллекцию на консоль
            Console.WriteLine("\nВторая коллекция (Stack):");
            foreach (var item in stack)
            {
                Console.WriteLine($"Значение: {item}");
            }

            // f) Находим заданное значение во второй коллекции
            Console.WriteLine("Введите значение элемента для поиска: ");
            string searchValue = Console.ReadLine();
            bool found = stack.Contains(searchValue);
            Console.WriteLine($"\nЗначение '{searchValue}' найдено в Stack: {found}");
        }
    }
}
