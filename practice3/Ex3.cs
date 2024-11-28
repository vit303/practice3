using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3
{
    internal class Ex3
    {
        public static void Print() {
            // Создаем коллекцию Dictionary<CompEquipment, string>
            Dictionary<CompEquipment, string> dictionary = new Dictionary<CompEquipment, string>
        {
            { new CompEquipment("Apple", "Intel", 8, 100000), "Лучший выбор" },
            { new CompEquipment("Dell", "AMD", 16, 80000), "Хорошая цена" },
            { new CompEquipment("HP", "Intel", 4, 60000), "Бюджетный вариант" },
            { new CompEquipment("Asus", "AMD", 32, 120000), "Для геймеров" },
            { new CompEquipment("Lenovo", "Intel", 8, 90000), "Для бизнеса" }
        };

            // Выводим коллекцию на консоль
            Console.WriteLine("Первая коллекция (Dictionary):");
            foreach (var kvp in dictionary)
            {
                kvp.Key.PrintInfo();
                Console.WriteLine($"Описание: {kvp.Value}");
                Console.WriteLine();
            }

            // Удаляем n элементов (например, 2 элемента)
            int n = 2;
            int i = 0;
            foreach (var kvp in dictionary.Keys.ToArray())
            {
                if (i < n)
                {
                    dictionary.Remove(kvp);
                    i++;
                }
                else
                    break;
            }

            // Выводим коллекцию после удаления
            Console.WriteLine("\nПосле удаления элементов:");
            foreach (var kvp in dictionary)
            {
                kvp.Key.PrintInfo();
                Console.WriteLine($"Описание: {kvp.Value}");
                Console.WriteLine();
            }

            // Добавляем другие элементы
            dictionary.Add(new CompEquipment("Microsoft", "AMD", 16, 110000), "Новый продукт");
            dictionary[new CompEquipment("Google", "Intel", 8, 70000)] = "Бюджетный вариант";

            // Выводим коллекцию после добавления
            Console.WriteLine("\nПосле добавления новых элементов:");
            foreach (var kvp in dictionary)
            {
                kvp.Key.PrintInfo();
                Console.WriteLine($"Описание: {kvp.Value}");
                Console.WriteLine();
            }

            // Создаем вторую коллекцию Stack<CompEquipment> и заполняем ее данными из первой коллекции
            Stack<CompEquipment> stack = new Stack<CompEquipment>();

            foreach (var kvp in dictionary.Keys)
            {
                stack.Push((CompEquipment)kvp.Clone()); // Добавляем клонированный объект
            }

            // Выводим вторую коллекцию на консоль
            Console.WriteLine("\nВторая коллекция (Stack):");
            foreach (var item in stack)
            {
                item.PrintInfo();
                Console.WriteLine();
            }

            // Находим заданное значение во второй коллекции
            CompEquipment searchValue = new CompEquipment("Asus", "AMD", 32, 120000);
            bool found = false;
            foreach (var item in stack)
            {
                if (item.CompareTo(searchValue) == 0)
                {
                    found = true;
                    break;
                }
            }
            Console.WriteLine($"\nОбъект '{searchValue.GetBrand()}' найден в Stack: {found}");
        }
    }
}
