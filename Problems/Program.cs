using System;

namespace Problems
{


    class Program
    {

        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.Write("n - порядок СЛАУ (n - число натуральное). Введите N: ");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                // n  - количество строк расширенной матрицы
                // n + 1 - количество столбцов расширенной матрицы
                var mtrExt = new double[n, n + 1];//Расширенная матрица
                var mtrSol = new double[n];//Матрица неизвестных


                //Заполнение расширенной матрицы
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < n + 1; j++)
                    {
                        mtrExt[i, j] = rnd.Next(-500,500);
                        Console.Write(mtrExt[i, j] + " ");
                    }
                }


                //Реализация прямого хода Гауса
                for (int i = 0; i < n - 1; i++)
                {
                    for (int k = i + 1; k < n; k++)
                    {
                        for (int j = i + 1; j < n + 1; j++)
                        {
                         //   mtrExt[k, j] = mtrExt[k, j] * mtrExt[i, i] - mtrExt[i, j] * mtrExt[k, i];
                            mtrExt[k, j] = mtrExt[k, j] / mtrExt[k, i] - mtrExt[i, j] / mtrExt[i, i];
                        }

                    }
                }

                //Вывод полученной треугольной расширенной матрицы 2 знака после запятой
                Console.WriteLine("\n\nПосле реализации прямого хода Гауса:");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine();
                    for (int j = i; j < n + 1; j++)
                    {
                        Console.Write(Math.Round(mtrExt[i, j], 2) + " ");
                    }
                }

                n -= 1;
                mtrSol[n] = mtrExt[n, n + 1] / mtrExt[n, n];
                // Реализация обратного хода Гауса
                for (int i = n - 1; i > -1; i--)
                {
                    for (int j = 1; j < n - i + 1; j++)
                    {
                        mtrExt[i, n + 1] -= mtrSol[i + j] * mtrExt[i, i + j];
                    }
                    mtrSol[i] = mtrExt[i, n + 1] / mtrExt[i, i];
                }
                Console.Write("\nРешение: ");
                foreach (var item in mtrSol)
                {
                    Console.Write(Math.Round(item, 4) + "  ");
                }

                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            


        }
       
    }

}
