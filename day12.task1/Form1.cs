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
        /// ���������� ������������� ����������
        /// </summary>
        /// <param name="g">����������� ���������</param>
        /// <param name="pen">����</param>
        /// <param name="x">���������� X ������ ����������</param>
        /// <param name="y">���������� Y ������ ����������</param>
        /// <param name="r">��������� ������</param>
        /// <param name="kR">����������� ��������� �������</param>
        /// <param name="distanceK">����������� ���������� ����� �������� ����������� �� ��������� � �������</param>
        /// <param name="direction">����������� ��� ���������</param>
        /// <param name="deltaAngle">���������� ������ �� ��� ���������</param>
        /// <param name="recCount">������� ��������</param>
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