using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace computer_printing
{
    class Program
    {
        static void Main(string[] args)
        {
            string text, answer, end_text = "exit()";
            bool check = true;
            int time;
            var paragraph = new List<string>();

            Console.WriteLine("Введите задержку в миллисекундах:");
            while (!Int32.TryParse(Console.ReadLine(), out time))
                Console.WriteLine("Ошибка! Нужно вводить целое число миллисекунд");

            Console.WriteLine("Внимание!!! Для обозначения конца текта необходимо ввести " + end_text);
            Console.WriteLine("Введите текст ниже:");
            text = Console.ReadLine();

            while (text != end_text)
            {
                paragraph.Add(text);
                text = Console.ReadLine();
            }
            Console.Clear();

            while (check)
            {
                int count = paragraph.Count;
                for (int i = 0; i < count; i++)
                {
                    text = paragraph[i];
                    for (int j = 0; j < paragraph[i].Length; j++)
                    {
                        Console.Write(text[j]);
                        Task.Delay(time).Wait();
                    }


                    Console.SetCursorPosition(Console.CursorLeft, 0);
                    Console.ReadKey();
                    for (int k = paragraph[i].Length; k >= 0; k--)
                        {
                            Console.SetCursorPosition(k, 0);
                            Console.Write(" ");
                            Task.Delay(80).Wait();
                        }
                }

                check = false;
                Console.WriteLine("Повторить?");
                answer = Console.ReadLine().ToUpper();
                if (answer == "ДА" || answer == "YES" || answer == "1")
                {
                    check = true;
                    Console.Clear();
                }
            }
            Console.ReadKey();
        }
    }
}
