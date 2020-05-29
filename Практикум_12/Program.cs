using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Задание_1_к
{
    class Program
    {
        class Point
        {
            private int x, y;

            /// <summary>
            /// Свойство для чтения и записи координаты абциссы точки
            /// </summary>
            public int X
            {
                get
                {
                    return x;
                }
                set
                {
                    x = value;
                }
            }

            /// <summary>
            /// Свойство для чтения и записи координаты ординаты точки
            /// </summary>
            public int Y
            {
                get
                {
                    return y;
                }
                set
                {
                    y = value;
                }
            }

            /// <summary>
            /// Свойство, умножающее координаты точки на скаляр 
            /// </summary>
            public int scalar
            {
                set
                {
                    x *= value;
                    y *= value;
                }
            }

            /// <summary>
            /// Конструктор, создающий точку с нулевыми координатами
            /// </summary>
            public Point()
            {
                x = 0;
                y = 0;
            }

            /// <summary>
            /// Конструктор, создающий точку с заданными координатами
            /// </summary>
            /// <param name="xnew"> координата абциссы </param>
            /// <param name="ynew"> координата ординаты </param>
            public Point(int xnew, int ynew)
            {
                x = xnew;
                y = ynew;
            }

            /// <summary>
            ///  Метод, выводящий координаты точки на экран
            /// </summary>
            public void Show()
            {
                Console.WriteLine("Координаты точки :x = {0}, y = {1}", x, y);
            }

            /// <summary>
            /// Метод, возвращающий расстояние от начала координат до точки
            /// </summary>
            /// <returns> возвращает расстояние от начала координат до точки</returns>
            public double Distance()
            {
                return Math.Sqrt(x * x + y * y);
            }

            /// <summary>
            /// Метод, перемещающий точку на вектор (а,b)
            /// </summary>
            /// <param name="a"> a вектора </param>
            /// <param name="b"> b вектора </param>
            public void Move(int a, int b)
            {
                x += a;
                y += b;
            }

            /// <summary>
            /// Индексатор, позволяющий по индексу 0 обращаться к полю x, по индексу 1 – к полю y, при других значениях индекса выдается сообщение об ошибке
            /// </summary>
            /// <param name="i"> индекс 0 - абцисса, 1 - ордината, другие - ошибка </param>
            /// <returns></returns>
            public int this[int i]
            {
                get
                {
                    if (i == 0)
                        return x;
                    if (i == 1)
                        return y;
                    throw new Exception("Error");
                }
                set
                {
                    if (i == 0)
                        x = value;
                    else if (i == 1)
                        y = value;
                    else
                        throw new Exception("Error");
                }
            }

            /// <summary>
            /// Одновременно увеличивает значение полей х и у на 1;
            /// </summary>
            /// <param name="point"></param>
            /// <returns></returns>
            public static Point operator ++(Point point)
            {
                point.x++;
                point.y++;
                return point;
            }

            /// <summary>
            /// Одновременно уменьшает значение полей х и у на 1;
            /// </summary>
            /// <param name="point"></param>
            /// <returns></returns>
            public static Point operator --(Point point)
            {
                point.x--;
                point.y--;
                return point;
            }

            /// <summary>
            /// Констант false, обращение к экземпляру класса дает значение true, если значение полей x и у совпадает, иначе false
            /// </summary>
            /// <param name="point"></param>
            /// <returns></returns>
            public static bool operator false(Point point)
            {
                if (point.x != point.y)
                    return false;
                return true;
            }

            /// <summary>
            /// Констант true, обращение к экземпляру класса дает значение true, если значение полей x и у совпадает, иначе false
            /// </summary>
            /// <param name="point"></param>
            /// <returns></returns>
            public static bool operator true(Point point)
            {
                if (point.x == point.y)
                    return true;
                return false;
            }

            /// <summary>
            /// Одновременно добавляет к полям х и у значение скаляра
            /// </summary>
            /// <param name="point"></param>
            /// <param name="scalar"></param>
            /// <returns></returns>
            public static Point operator +(Point point, int scalar)
            {
                point.x = point.x + scalar;
                point.y = point.y + scalar;
                return point;
            }

            /// <summary>
            /// Явное преобразование типа Point в string
            /// </summary>
            /// <param name="point"></param>
            public static explicit operator String(Point point)
            {
                return String.Format("{0} {1}", point.x, point.y);
            }

            /// <summary>
            /// Явное преобразование типа string в Point
            /// </summary>
            /// <param name="str"></param>
            public static explicit operator Point(string str)
            {
                string[]  strmas = str.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
                Point point = new Point();
                if (strmas.Count() >= 2)
                {
                    point.x = int.Parse(strmas[0]);
                    point.y = int.Parse(strmas[1]);
                }
                else return null;
                return point;
            }
        }
        static void Main(string[] args)
        {
            Point p = new Point();
            ++p;
            p.Show();
            if (p)
                Console.WriteLine("одинаковы");
            else
                Console.WriteLine("не одинаковы");
            string str = (string)p;
            Console.WriteLine(str);
            p = p + 10;
            p.Show();
            if (p)
                Console.WriteLine("одинаковы");
            else
                Console.WriteLine("не одинаковы");
            bool prov = false;
            do
            {
                Console.Write("Введите абцису и ординату через пробел или запятую:");
                str = Console.ReadLine();
                if (Regex.IsMatch(str, @"\d[ ,]+\d") && !Regex.IsMatch(str, @"[^\d^ ^,]+"))
                    prov = true;
                else
                    Console.WriteLine("Некоррктный ввод");
            } while (!prov);
            p = (Point)str;
            p.Show();
            Console.WriteLine(str);
            p[0] = 10;
            p[1] = -1;
            p.Show();
            Console.ReadLine();
        }
    }
}
