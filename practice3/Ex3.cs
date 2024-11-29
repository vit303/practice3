using System;
using System.Collections.Generic;
using System.Linq;

namespace practice3
{
    internal class Ex3
    {
        public static void Print()
        {
            Dictionary<CompEquipment, string> dictionary = CreateAndFillDictionary();
            DisplayDictionary(dictionary);

            RemoveElementsFromDictionary(dictionary, 2);
            DisplayDictionary(dictionary);

            AddNewElementsToDictionary(dictionary);
            DisplayDictionary(dictionary);

            Stack<CompEquipment> stack = CreateStackFromDictionary(dictionary);
            DisplayStack(stack);

            SearchValueInStack(stack, new CompEquipment("Asus", "AMD", 32, 120000));
        }

        private static Dictionary<CompEquipment, string> CreateAndFillDictionary()
        {
            return new Dictionary<CompEquipment, string>
            {
                { new CompEquipment("Apple", "Intel", 8, 100000), "Лучший выбор" },
                { new CompEquipment("Dell", "AMD", 16, 80000), "Хорошая цена" },
                { new CompEquipment("HP", "Intel", 4, 60000), "Бюджетный вариант" },
                { new CompEquipment("Asus", "AMD", 32, 120000), "Для геймеров" },
                { new CompEquipment("Lenovo", "Intel", 8, 90000), "Для бизнеса" }
            };
        }

        private static void DisplayDictionary(Dictionary<CompEquipment, string> dictionary)
        {
            Console.WriteLine("Первая коллекция (Dictionary):");
            foreach (var kvp in dictionary)
            {
                kvp.Key.PrintInfo();
                Console.WriteLine($"Описание: {kvp.Value}\n");
            }
        }

        private static void RemoveElementsFromDictionary(Dictionary<CompEquipment, string> dictionary, int n)
        {
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
        }

        private static void AddNewElementsToDictionary(Dictionary<CompEquipment, string> dictionary)
        {
            dictionary.Add(new CompEquipment("Microsoft", "AMD", 16, 110000), "Новый продукт");
            dictionary[new CompEquipment("Google", "Intel", 8, 70000)] = "Бюджетный вариант";
        }

        private static Stack<CompEquipment> CreateStackFromDictionary(Dictionary<CompEquipment, string> dictionary)
        {
            Stack<CompEquipment> stack = new Stack<CompEquipment>();
            foreach (var kvp in dictionary.Keys)
            {
                stack.Push((CompEquipment)kvp.Clone()); // Добавляем клонированный объект
            }
            return stack;
        }

        private static void DisplayStack(Stack<CompEquipment> stack)
        {
            Console.WriteLine("\nВторая коллекция (Stack):");
            foreach (var item in stack)
            {
                item.PrintInfo();
                Console.WriteLine();
            }
        }

        private static void SearchValueInStack(Stack<CompEquipment> stack, CompEquipment searchValue)
        {
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