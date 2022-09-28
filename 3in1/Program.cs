using System;

namespace _3in1
{
    class Program
    {
       public static void GuessTheNumber ()
        {
            Console.WriteLine("угадай число от 0 до 100");
            Random rnd = new Random();
            int a = rnd.Next(0, 100);
            int guess = -1;
            while (guess != a)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess < a)
                {
                    Console.WriteLine("неправильно, попробуй число побольше");
                }
                else if (guess > a)
                {
                    Console.WriteLine("неправильно, попробуй число поменьше");
                }
                else if (guess > 100)
                {
                    Console.WriteLine("вводи только числа от 0 до 100");
                }
            }
            Console.WriteLine("ты угадал");
        }

        public static void Table()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("\n" + i + " ");
                for (int x = 1; x < 10; x++)
                {
                    Console.Write("\t" + x * i);
                }
            }
        }

        public static void Del()
        {
            Console.WriteLine("введите число, чтобы узнать все его делители");
            int del = Convert.ToInt32(Console.ReadLine());
            for (int y = 1; y <= del; y++)
            {
                if ((del % y) == 0)
                {
                    Console.WriteLine(y);
                }
            }
        }
       public static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            Console.WriteLine("1 - игра угадай число");
            Console.WriteLine("2 - таблица умножения");
            Console.WriteLine("3 - вывод делителей числа");
            Console.WriteLine("4 - выход из программы");
            int num = Convert.ToInt32(Console.ReadLine());
            while ((num >= 1) && (num <= 4))
            {
                switch (num)
                {
                    case 1:
                        GuessTheNumber();
                        break;
                    case 2:
                        Table();
                        break;
                    case 3:
                        Del();
                        break;
                    case 4:
                        Console.WriteLine("вы вышли из программы");
                        break;
                        num = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\n введите число");
                num = Convert.ToInt32(Console.ReadLine());
            }
            if((num > 4) || (num < 1))
            {
                Console.WriteLine("такого действия нет");
            }
        }
    }
}
