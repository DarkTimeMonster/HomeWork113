using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Random number = new Random();
            int twonumber = number.Next(10, 99);
            Console.WriteLine(twonumber);
            string st = (twonumber % 2 == 0) ? "четное число":"не четное число";
            Console.WriteLine(st);*/

            /*
            Random number = new Random();
            int numberday = number.Next(1, 7);
            Console.WriteLine(numberday);
            switch (numberday)
            {
                case 1:
                Console.WriteLine("Понедельник");
                break;
                case 2:
                Console.WriteLine("Вторник");
                break;
                case 3:
                    Console.WriteLine("Среда");
                break;
                case 4:
                Console.WriteLine("Четверг");
                break;
                case 5:
                Console.WriteLine("Пятница");
                break;
                case 6:
                Console.WriteLine("Суббота");
                break;
                case 7:
                Console.WriteLine("Воскресенье");
                break;
            }*/

            //Задача 3. Даны три целых положительных числа. Если все они четные, каждое число уменьшить в 2 раза, если хотя бы одно из них четное, увеличить каждое число в 2 раза, если четных чисел нет, каждое число увеличить на 1.
            /*
            Console.Write("Введите первое число - ");
            int number1= int.Parse(Console.ReadLine());
            Console.Write("Введите первое число - ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Введите первое число - ");
            int number3 = int.Parse(Console.ReadLine());
            if (number1 % 2 == 0 & number2 % 2 == 0 & number3 % 2 == 0)
                {
                    number1/=2;
                    number2/=2;
                    number3/=2;
                }
            else if (number1 % 2 == 0 | number2 % 2 == 0 | number3 % 2 == 0)
                {
                    number1 *= 2;
                    number2 *= 2;
                    number3 *= 2;
                }
            else
                {
                    number1++;
                    number2++;
                    number3++;
                }
            Console.WriteLine($"Певрое число{number1},Второе число{number2},Третье число{number3}");*/
            /*
            Console.WriteLine("Введите набранный балл - ");
            byte ball = byte.Parse(Console.ReadLine());
            try
            {
                if (ball <= 100 & ball >= 90)
                    {
                        Console.WriteLine("Отлично");
                    }
                if (ball <= 89 & ball >= 70)
                    {
                        Console.WriteLine("Хорошо");
                    }
                if (ball <= 69 & ball >= 50)
                    {
                        Console.WriteLine("Удовлетворительно");
                    }
                if (ball <= 49)
                    {
                         Console.WriteLine("НеУдовлетворительно");
                    }

            }
            catch (Exception ex)
            {
                    Console.WriteLine($"Исключение: {ex.Message}");
                    Console.WriteLine($"Метод: {ex.TargetSite}");
                    Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }*/
            //Задача 5. Дан признак геометрической фигуры на плоскости: к – круг, п – прямоугольник, т - треугольник. Вывести на экран периметр и площадь заданной фигуры (данные, необходимые для расчетов, запросить у пользователя).
            /*
            Console.Write("Введите признак фигуры на плоскости (к – круг, п – прямоугольник, т - треугольник) - ");
            double squade,perimetr,p;
            int side1, side2, side3;
            char word = Convert.ToChar(Console.ReadLine());
            switch(word)
            {
                case 'к':
                case 'К':
                    Console.WriteLine("Круг");
                    Console.Write("Введите радиус круга - ");
                    int radius = int.Parse(Console.ReadLine());
                    perimetr = 2 * Math.PI * radius;
                    squade = Math.PI * Math.Pow(radius,2);
                    Console.WriteLine($"Периметр круга равен = {perimetr:f2}\n Площадь круга = {squade:f2}");
                    break;
                case 'п':
                case 'П':
                    Console.WriteLine("Прямоугольник");
                    Console.Write("Введите первую сторону прямоугольника - ");
                    side1 = int.Parse(Console.ReadLine());
                    Console.Write("Введите вторую сторону прямоугольника - ");
                    side2 = int.Parse(Console.ReadLine());
                    perimetr = 2 * (side1 + side2);
                    squade = side1 * side2;
                    Console.WriteLine($"Периметр прямоугольника равен = {perimetr:f2}\n Площадь прямоугольника = {squade:f2}");
                    break;
                case 'т':
                case 'Т':
                    Console.WriteLine("Треугольник");
                    Console.Write("Введите первую сторону треугольника - ");
                    side1 = int.Parse(Console.ReadLine());
                    Console.Write("Введите вторую сторону треугольника - ");
                    side2 = int.Parse(Console.ReadLine());
                    Console.Write("Введите третью сторону треугольника - ");
                    side3 = int.Parse(Console.ReadLine());                    
                    perimetr = side1 + side2 + side3;
                    p = perimetr / 2;
                    squade = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
                    Console.WriteLine($"Периметр прямоугольника равен = {perimetr:f2}\n Площадь прямоугольника = {squade:f2}");
                    break;
                default:
                    Console.WriteLine("Такой фигуры нет в списке");
                        break;
            }*/
            // Написать приложение, которое позволяет вычислить сумму страхового взноса (SV) для автомобиля. Входные данные будут вводиться с клавиатуры:
            Console.Write("Введите марку автомобиля - ");
            string MA = Console.ReadLine();

            Console.Write("Введите срок страхования - ");
            int Months = Convert.ToInt32(Console.ReadLine());
            double kt = 0;

            if (Months < 3)
            {
                kt = 10;
            }
            else if (Months >= 3 & Months < 6)
            {
                kt = 8;
            }
            else if (Months >= 6 & Months < 12)
            {
                kt = 5;
            }
            else if (Months > 12)
            {
                Console.WriteLine("Страховой взнос только на 12 месяцев");
                Console.ReadKey();
                return;
            }

            double Sum = 50 * Months * (1 + kt / 100);
            Console.Write($"Ваш автомобиль марки {MA} был застрахован.\nСумма страхового взноса составила {Sum}.");
            Console.ReadKey();
        }
    }
}
