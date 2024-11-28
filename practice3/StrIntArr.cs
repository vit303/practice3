using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3
{
    public class StrIntArr
    {
        public static void Print() {
            ArrayList arrayList = new ArrayList();
            Random random = new Random();
            Console.WriteLine("Введите количество чисел в списке");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                arrayList.Add(random.Next(1, 100));
            }
            Console.WriteLine("Введите строку:");
            String str = Console.ReadLine();
            arrayList.Add(str);

            Console.WriteLine();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            if (arrayList.Count > 1)
            {
                Console.WriteLine("Введите индекс элемента для удаления");
                int index = Convert.ToInt32(Console.ReadLine());
                arrayList.RemoveAt(index);

                Console.WriteLine($"\nКоличество элементов в коллекции: {arrayList.Count}");
                Console.WriteLine("Коллекция после удаления элемента:");
                foreach (var item in arrayList)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Введите значение элемента для поиска");
                string inputValue = Console.ReadLine();
                object searchValue;

                // Попробуем преобразовать введенное значение в число
                if (int.TryParse(inputValue, out int intValue))
                {
                    searchValue = intValue;
                }
                else
                {
                    searchValue = inputValue;
                }

                bool containValue = arrayList.Contains(searchValue);
                Console.WriteLine($"\nКоллекция содержит значение {searchValue}: {containValue}");
            }

        }
    }
}
