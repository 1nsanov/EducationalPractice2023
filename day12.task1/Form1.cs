namespace day12.task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var pen = new Pen(Color.Blue, 2);
            SizeChanged += (s, e) => Invalidate();
            Paint += (s, e) =>
            {
                e.Graphics.DrawCircles(pen, ClientRectangle.X + ClientRectangle.Width / 2,
                    ClientRectangle.Top + ClientRectangle.Height / 2,
                    Math.Min(ClientRectangle.Width, ClientRectangle.Height) / 4, 0.5F, 1 + 0.5F, Math.PI / 2,
                    Math.PI / 4, 3);
            };
        }
    }

    public static class Ext
    {
        /// <summary>
        /// Отобразить уменьшающиеся окружности
        /// </summary>
        /// <param name="g">Поверхность рисования</param>
        /// <param name="pen">Перо</param>
        /// <param name="x">Координата X центра окружности</param>
        /// <param name="y">Координата Y центра окружности</param>
        /// <param name="r">Первичный радиус</param>
        /// <param name="kR">Коэффициент изменения радиуса</param>
        /// <param name="distanceK">Коэффициент расстояния между центрами окружностей по отношению к радиусу</param>
        /// <param name="direction">Направление оси симметрии</param>
        /// <param name="deltaAngle">Отклонение ветвей от оси симметрии</param>
        /// <param name="recCount">Уровень рекурсии</param>
        public static void DrawCircles(this Graphics g, Pen pen, float x, float y, float r, float kR, float distanceK, double direction, double deltaAngle, int recCount)
        {
            while (true)
            {
                if (recCount == -1) return;
                g.DrawEllipse(pen, x - r, y - r, 2 * r, 2 * r);
                g.DrawCircles(pen, x + r * distanceK * (float)Math.Cos(direction - deltaAngle),
                    y + r * distanceK * (float)Math.Sin(direction - deltaAngle), r * kR, kR, distanceK, direction,
                    deltaAngle, recCount - 1);
                x += r * distanceK * (float)Math.Cos(direction + deltaAngle);
                y += r * distanceK * (float)Math.Sin(direction + deltaAngle);
                r *= kR;
                recCount -= 1;
            }
        }
    }
}