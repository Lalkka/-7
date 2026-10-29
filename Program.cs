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
                Console.WriteLine("1. Сумма первых N членов арифметической прогрессии.\n2. уже не 200.\n3. Лыжник.\n4. Бешенные проценты.\n5. Чётки\n6. Мышь и 5 грамм.\n7. Осёл.\n8. Покупатель не умеющий счиитать.\n9. Чёрный ход.");
                var key = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (key)
                {
                    case '1':
                        Console.Write("Введите число для возведения его в арифметическую погрессию:");
                        var N0 = Console.ReadLine();
                        Console.Write("Введите кол-во чисел арифметической прогрессии которое вы хотите видеть:");
                        var B0 = Console.ReadLine();
                        if (double.TryParse(N0, out double N) && double.TryParse(B0, out double B))
                        {
                            double N1 = N;
                            Console.Write($"{N} ");
                            for (int i = 1; B > i; i++)
                            {
                                Console.Write("- ");
                                N1 = N + N1;
                                Console.Write($"{N1} ");
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Введено неверное значение");
                        }
                        Console.ReadLine ();
                        Console.Clear ();
                        break;
                    case '2':
                        int num = 201;

                        while (num % 17 != 0)
                        {
                            num++;
                        }

                        Console.WriteLine($"Минимальное число больше 200 делимое на 17: {num}");
                        Console.ReadLine();
                        Console.Clear();
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
