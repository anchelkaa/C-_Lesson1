#region Автор
//Анна Буланова
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача №1

            #region Описание задачи
            /* Написать программу "Анкета". Последовательно задаются вопросы (имя, фамилия, возраст,
             * рост, вес). В результате вся информация выводится в одну строчку;
             * а) используя склеивание;
             * б) используя форматированный вывод;
             * в) используя вывод со знаком $.*/
            #endregion

            Console.WriteLine("Здравствуйте, не могли бы вы заполнить анкету?");

            Console.WriteLine("Ваше имя?");
            string name = Console.ReadLine();

            Console.WriteLine("Ваша фамилия?");
            string surname = Console.ReadLine();

            Console.WriteLine("Ваша возраст?");
            string age = Console.ReadLine();

            Console.WriteLine("Ваша ваш рост (в см)?");
            string height = Console.ReadLine();

            Console.WriteLine("Ваша ваш вес?");
            string weight = Console.ReadLine();

            Console.WriteLine($"{name} {surname}: {age} года (лет), {height} см, {weight} кг");
            Console.ReadLine();
            #endregion

            #region Задача №2

            #region Описание задачи
            //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
            #endregion

            Console.WriteLine("Пожалуйста, введите ваше имя");
            String name1 = Console.ReadLine();
            String text = "Привет, " + name1 + "! Данная программа поможет вычислить твой ИМТ (индекс массы тела).";
            Console.WriteLine(text);
            Console.ReadLine();

            Console.WriteLine("Введите ваш рост (в м)");
            double height1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите ваш вес (в кг)");
            double weight1 = double.Parse(Console.ReadLine());

            
            double I = weight1 / (height1 * height1);
            Console.WriteLine($"Ваш ИМТ + {I}");
            Console.ReadLine();
            #endregion

            #region Задача №4

            #region Описание задачи

            //Написать программу обмена значениями двух переменных с использованием третьей переменной.

            #endregion

            int a = 12;
            int b = 14;
            int c = a;
            a = b;
            b = c;

            Console.WriteLine($"{a},{b}");
            Console.ReadLine();

            #region Описание задачи

            //Написать программу обмена значениями двух переменных без использования третьей переменной.

            #endregion

            int r = 13;
            int q = 75;

            q = r + q;
            r = q - r;
            q = q - r;

            Console.WriteLine($"{r},{q}");
            Console.ReadLine();

            #endregion

        }

            #region Задача №3 

        #region Описание задачи

        /*Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
          Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);*/

        #endregion

        static double Distance(double x1, double y1, double x2, double y2)
        {

            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        }

        static void Main(string[] args) /* Честно говоря, я порылась в интернете для решения этой задачи, и, соответственно, у меня возник вопрос: почему если в отдельной програме я ввожу метод Main, то все работает,
                                         а в данной програме VS пишет, что такой метод уже есть? Точнее, как мне нужно задать метод, чтобы программа работала со всеми задачами, а не только с первыми тремя?*/
            
        {
            double x1 = 1.5;
            double y1 = 3.8;
            double x2 = 7.6;
            double y2 = 10.3;

            Console.Write("Вас приветствует программа для рассчёта расстояния между точками." + "Расстояние между данными точками равняется: ", x1, y1, x2, y2);

            double distance = Distance(x1, y1, x2, y2);

            Console.Write("{0:F2}", distance);

            Console.ReadKey();
        }
        #endregion

            #region Задача №5

        #region Описание задачи
        /*а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        б) *Сделать задание, только вывод организовать в центре экрана.
        в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).*/
        #endregion

        static void Main(string[] args)
        {
            string[] info = { "Анна", "Буланова", "Москва" };


            Print(info, 50, 13);

            Console.ReadKey();
        }
        static void Print(string[] msg, int x, int y)
        {
            for (int i = 0; i < msg.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(msg[i]);
            }

        }

        #endregion
    }
}
