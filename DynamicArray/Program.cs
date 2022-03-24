using System;
using ClassLibrary;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var operations = new ClassLibrary.DynamicArrayOperations<object>();
            var array = operations.array;
            var infinity = true;
            while (infinity)
            {
                Console.Clear();
                Console.WriteLine("Массив выглядит так:");
                foreach (object o in array)
                {
                    Console.Write(o + " ");
                }
                Console.Write("\n");
                Console.WriteLine("Выберите операцию: " + "\n" + "1. Изменить размер массива."
                    + "\n" + "2. Добавить элемент массива." + "\n" + "3. Изменить элемент массива."
                    + "\n" + "4. Удалить элемент массива.");
                switch(Console.ReadLine())
                {
                    case "1":
                        break;
                    case "2":
                        operations.Add(ref array,GetInsert("Введите элемент массива:"));
                        break;
                    case "3":
                        operations.Insert(ref array, GetInt("Введите индекс элемента:"), GetInsert("Введите элемент массива:"));
                        break;
                    case "4":
                        operations.Remove(ref array, GetInt("Введите индекс элемента:"));
                        break;
                    default:
                        Console.WriteLine("Не выбрана ни одна из функций.");
                        break;
                }
            }

        }

        private static int GetInt(string message)
        {
            Console.WriteLine(message);
            try
            {
                if (int.TryParse(Console.ReadLine(), out int result)==false)
                {
                    throw new Exception("Введите целое число.");
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        private static object GetInsert(string message)
        {
            Console.WriteLine(message);
            try
            {
                if (string.IsNullOrWhiteSpace(Console.ReadLine())==true)
                {
                    throw new Exception("Введите элемент.");
                }
                return Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
