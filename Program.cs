using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace урок_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tДобро пожаловать в практическую N6!\n\t    Нажмите что-бы продолжить");
            Console.ReadLine();
            Console.Clear();
            while (true)
            {

                Console.WriteLine("Выберите номер задания(1-9):");
                Console.WriteLine("1. Сумма первых N членов арифметической прогрессии.\n2. уже не 200.\n3. Лыжник.\n4. Бешенные проценты.\n5. Чётки\n6. Мышь и 5 грамм.\n7. Осёл.\n 8. Покупатель не умеющий счиитать.\n9. Чёрный ход.");
                var key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case '1':
                        Console.Clear();
                        
                        break;
                    case '2':

                        break;
                    case '3':

                        break;
                    case '4':

                        break;
                }
                Console.Clear();
            }
        }
    }
}
