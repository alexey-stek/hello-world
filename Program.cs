using System;

namespace Dima_Zadaniy
{
    class Program
    {

        static void Main(string[] args)
        {
            //Разница в днях между датами - вводим две даты, 
            //    программа выдает разницу в днях между ними.
            //Количество дней до даты - вводим предполагаемую дату,
            //программа рассчитывает количество дней до нее от сегодняшнего дня.

            DateTime date1 = new DateTime();
            DateTime date2 = new DateTime();



            Console.WriteLine("Введите начальную дату");
            date1 = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Введите конечную дату");
            date2 = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine(date2.Subtract(date1));
            Console.WriteLine("Введите предполагаемую дату");
            var today = DateTime.Today;

            var date3 = Convert.ToDateTime(Console.ReadLine());
            var remainingDays = (date3 - today).TotalDays;
            Console.WriteLine("Оставшеся количество дней " + remainingDays);


            //Калькулятор переплаты по кредиту - вводим сумму кредита, годовую ставку, 
            //    срок, программа выводит сумму, которая будет выплачена банку в виде процентов.




            double Summa_Kredita;
            double stavka;
            double srok;
            double Summa_Pereplata;
            double platej_v_month;
            double procent_v_month;

            Console.WriteLine("Введите сумму кредита");

            Summa_Kredita = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите годовую ставку");

            stavka = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите срок");

            srok = Convert.ToDouble(Console.ReadLine());

            procent_v_month = (stavka / 12) / 10;
            Console.WriteLine("Процент по кредиту в месяц " + procent_v_month);

            platej_v_month = procent_v_month * Summa_Kredita;
            Console.WriteLine("Платеж в месяц по кредиту " + platej_v_month);

            Summa_Pereplata = (platej_v_month * srok) - Summa_Kredita;
            Console.WriteLine("Переплата по кредиту " + Summa_Pereplata);

            //Игра “Угадай число” - программа случайно генерирует число в некотором диапазоне,
            //    пользователь вводит предполагаемое значение, если они совпали - победа.
            //Доработать игру - после неудачной попытки давать еще одну,
            //и указывать в большую или в меньшую сторону была ошибка

            Random r = new Random();
            int i = r.Next(5);

            int l = 0;
            while (true)
            {
                Console.WriteLine("Компьютер загадал число. Попробуйте отгодать его.");
                Console.WriteLine("Введите  число:");
                int k = Convert.ToInt32(Console.ReadLine());

                l++;


                if (i == k)
                {
                    Console.WriteLine("Вы угодали число " + k + " Победа!");
                    break;
                }

                if (i > k)
                {
                    Console.WriteLine("Ваше число меньше загаданого, попробуйте еще раз");

                    k = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                if (i < k)
                {
                    Console.WriteLine("Ваше число ,больше  загаданого, попробуйте еще раз");
                    k = Convert.ToInt32(Console.ReadLine());
                    break;
                }


            }
            Console.ReadLine();

            //Написать программу для расчета площади стен в помещении, на вход даются длина, ширина, высота (возможности нестандартной планировки, а также окна и двери в расчет не берем). Нужно вывести площадь поверхности стен.
            //Доработать программу в п.1 - добавить исключения (дверь, окно, проем) для расчета только полезной площади.
            //Доработать программу в п.2 - по завершении расчета писать результаты в файл.


            double S;              // площадь стен
            double S1;         // площадь окон и дверей
            double S2;         // полезная площадь

            Console.Write("Введите ширину стены ");
            double shirina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите длину  стены ");
            double dlina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите высоту   стены ");
            double visota = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            S = 2 * (dlina + shirina) * visota;

            Console.WriteLine("Площадь стены " + S);

            Console.Write("Введите высоту двери ");
            double vdoor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите ширину  двери ");
            double sdoor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите высоту окна ");
            double vwindow = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите ширину окна ");
            double swindow = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            S1 = sdoor * vdoor + vwindow * swindow;

            Console.WriteLine("Площадь окна и двери " + S1);

            Console.WriteLine();

            S2 = S - S1;

            Console.WriteLine("Полезная площадь" + S2);

            ////StreamWriter output = new StreamWriter("Zadany_Dima");

            ////Ploshad ploshad = new Ploshad();

            //ploshad.SSteny(dlina, shirina, visota);


            //ploshad.Sdoor_Window();





        }
    }   } 

