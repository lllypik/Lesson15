using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // Проверка работы метода алгоритмической прогрессии
            //Задаем начальные параметры
            ArithProgression arith = new ArithProgression();
            arith.setStart(2);
            arith.setStep(10);

            //Выводим результат
            Console.WriteLine("Вывод значений арифметичской прогрессии");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arith.getNext());
            }

            //Сбрасываем начальное значение
            arith.reset();
            //Проверямем сброс значений до заданного и работу метода в дальнейшем
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arith.getNext());
            }
            Console.ReadKey();

            // Проверка работы метода алгоритмической прогрессии
            //Задаем начальные параметры
            GeomProgression geom = new GeomProgression();
            geom.setStart(13);
            geom.setStep(6);

            //Выводим результат
            Console.WriteLine("Вывод значений арифметичской прогрессии");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(geom.getNext());
            }

            //Сбрасываем начальное значение
            geom.reset();

            //Проверямем сброс значений до заданного и работу метода в дальнейшем
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(geom.getNext());
            }
            Console.ReadKey();

        }
    }


}
