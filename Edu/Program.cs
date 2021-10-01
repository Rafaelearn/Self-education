using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu
{
    class Program
    {
        static void Main(string[] args)
        {
            //lesson1();
            lesson2();

           // Console.ReadKey();
        }

        static private void lesson1()
        {

            // 0b - двоичные числа
            Console.WriteLine(0b11);        // 3
            Console.WriteLine(0b1011);      // 11
            Console.WriteLine(0b100001);    // 33

            //0x - 16-числа
            Console.WriteLine(0x0A);    // 10
            Console.WriteLine(0xFF);    // 255
            Console.WriteLine(0xA1);    // 161

            Console.WriteLine("Управляющие символы");

            //Звуковой сигнал (звонок)
            Console.WriteLine("\aЗвук");

            //Возврат на одну позицию
            Console.WriteLine("Hello\b world\n");

            //Новая строка
            Console.WriteLine("Hello\nworld\n");

            //Возрат каретки
           // Console.WriteLine("Hello\r world\n");

            //Горизонатльная и Вертикальная табуляция
            Console.WriteLine("Hello\t world");
            Console.WriteLine("Hello\v world");

            //Пустой символ
            Console.WriteLine("Hello\0\0 world");

            //Кавычки и косая черта
            Console.WriteLine("\' \" \\");

            // object может содержать любой тип
            object a1 = 22;

            // var
            var a2 = 12.34;
            a2 = 1;
            Console.WriteLine(a2);


            //Применение суффиксов
            float a3 = 3.14F;
            float a4 = 30.6f;             //То же самое
            decimal a5 = 1005.8M;
            decimal a6 = 334.8m;            //То же самое
            // float a = 1.4; Ошибка, но byte a  = 1; нет ошибка
            uint a7 = 10U;
            long a8 = 20L;
            ulong a9 = 30UL;

            // Системный тип данных
            int a10 = 1;
            Int32 a11 = 1; // То же самое

            //Методы типов 
            Console.WriteLine(a10.GetType()); // Вывод типа данных
            Console.WriteLine(a10.GetTypeCode()); //
            Console.WriteLine(Int32.MaxValue); 
            Console.WriteLine(Int32.MinValue);

            // Операции в си шарп
            int a12 = 2;
            int a13 = 1;
            a13 /= a12; // 0 Целочисленное деление
            double x = 10.0;
            double z = x % 4.0; //результат равен 2
            // Инкремент  Декремент
            x = 5;
            z = ++x; // z1=6; x1=6
            x = 5;
            z = x++; // z2=5; x2=6
            x = 5;
            z = --x; // z1=4; x1=4
            x = 5;
            z = x--; // z2=5; x2=4
            //Порядок выполнения операций
            int a = 3;
            int b = 5;
            int c = 40;
            int d = c-- - b * a;    // a=3  b=5  c=39  d=25

            //Поразрядные операции & | ~ >> <<

            Console.WriteLine("Нажмите Y или N");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "Y":
                    Console.WriteLine("Вы нажали букву Y");
                    break;
                case "N":
                    Console.WriteLine("Вы нажали букву N");
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                    break;
            }

            switch (a1)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }

            //Тернарная операция
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine(a == 0? (false) : (true));

        }
        static private void lesson2()
        {   /*
            for (; ;)
            {
             Бесконечный цикл
            }
            */

            int l = 0;
            for (; l < 10; l++)
            {
                Console.WriteLine($"Кывдрат числа {l} равен {l * l} ");
            }

            int k = 6;
            do
            {
                Console.WriteLine(k);
                k--;
            }
            while (k > 0);

            k = 6;
            while (k > 0)
            {
                Console.WriteLine(k);
                k--;
            }

            //Массивы
            //тип_переменной[] название_массива;
            Console.WriteLine("\n\n");
            int[] nums = new int[4];
            for (int i = 0; i < nums.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out nums[i]);
            }
            
            /*
            foreach (int i  in nums)
            {
                int.TryParse(Console.ReadLine(), out );
            }
            Console.WriteLine();
            */
            foreach (int item in nums)
            {
                Console.Write(item+"\t");
            }

            //Многомерные массивы
            int[] nums1 = new int[] { 0, 1, 2, 3, 4, 5 };

            int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };

        }
    }

}
