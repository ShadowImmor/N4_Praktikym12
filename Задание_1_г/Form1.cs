using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1_г
{
    public partial class Form1 : Form
    {
        Point point = new Point();
        public Form1()
        {
            InitializeComponent();
            X.Maximum = int.MaxValue;
            X.Minimum = int.MinValue;
            Y.Maximum = int.MaxValue;
            Y.Minimum = int.MinValue;
            A.Maximum = int.MaxValue;
            A.Minimum = int.MinValue;
            B.Maximum = int.MaxValue;
            B.Minimum = int.MinValue;
            Scalar.Maximum = int.MaxValue;
            Scalar.Minimum = int.MinValue;
            Upd();
        }

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
            /// Метод, возвращающий строку с координатами точки
            /// </summary>
            /// <returns> возвращает строку с координатами точки </returns>
            public string Show()
            {
                return "x = " + x + ", y = " + y;
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
                    if (i == 1) return y;
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
                string[] strmas = str.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
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

        private void ZadCordbutton_Click(object sender, EventArgs e)
        {
            point.X = (int)X.Value;
            point.Y = (int)Y.Value;
            Upd();
        }

        private void PerVectorbutton_Click(object sender, EventArgs e)
        {
            point.Move((int)A.Value, (int)B.Value);
            Upd();
        }

        private void RasNachDoToch_Click(object sender, EventArgs e)
        {
            Ras.Text = point.Distance().ToString();
        }

        private void YmnScalar_Click(object sender, EventArgs e)
        {
            point.scalar = (int)Scalar.Value;
            Upd();
        }

        private void Inkr_Click(object sender, EventArgs e)
        {
            point++;
            Upd();
        }

        private void Dekr_Click(object sender, EventArgs e)
        {
            point--;
            Upd();
        }

        private void YvelScalar_Click(object sender, EventArgs e)
        {
            point = point + (int)Scalar.Value;
            Upd();
        }

        private void ZadAb_Click(object sender, EventArgs e)
        {
            point[0] = (int)X.Value;
            Upd();
        }

        private void ZadOrd_Click(object sender, EventArgs e)
        {
            point[1] = (int)Y.Value;
            Upd();
        }

        private void ZadXY_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(XY.Text, @"\d[ ,]+\d"))
                point = (Point)XY.Text;
            Upd();
        }

        private void Upd()
        {
            ShowCord.Text = point.Show();
            if (point)
                Odin.Text = "да";
            else
                Odin.Text = "нет";
            XY.Text = (string)point;
        }

        private void X_ValueChanged(object sender, EventArgs e)
        {
            if (X.Value != (int)X.Value)
                X.Value = (int)X.Value;
        }

        private void Y_ValueChanged(object sender, EventArgs e)
        {
            if (Y.Value != (int)Y.Value)
                Y.Value = (int)Y.Value;
        }

        private void A_ValueChanged(object sender, EventArgs e)
        {
            if (A.Value != (int)A.Value)
                A.Value = (int)A.Value;
        }

        private void B_ValueChanged(object sender, EventArgs e)
        {
            if (B.Value != (int)B.Value)
                B.Value = (int)B.Value;
        }

        private void Scalar_ValueChanged(object sender, EventArgs e)
        {
            if (Scalar.Value != (int)Scalar.Value)
                Scalar.Value = (int)Scalar.Value;
        }

        private void XY_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b]"))
                return;
            if ((e.KeyChar == ' ' || e.KeyChar == ',') && !Regex.IsMatch(XY.Text, @"[ ,]+"))
            {
                if(XY.SelectionStart > 0 && Regex.IsMatch(XY.Text[XY.SelectionStart -1].ToString(), @"\d"))
                {
                    return;
                }
            }
            e.Handled = true;            
        }
    }
}
