namespace day4.task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = ClientSize.Width;
            int height = ClientSize.Height;

            // Рисуем флаг
            SolidBrush brushRed = new SolidBrush(Color.FromArgb(239, 33, 50));
            SolidBrush brushBlue = new SolidBrush(Color.FromArgb(0, 101, 177));
            Color colorOrange = Color.FromArgb(243, 126, 18);
            SolidBrush brushOrange = new SolidBrush(colorOrange);
            Rectangle rectRed = new Rectangle(0, 0, width, height / 3);
            Rectangle rectBlue = new Rectangle(0, height / 3, width, height / 3);
            Rectangle rectOragne = new Rectangle(0, height / 3, width, height / 3 * 2);
            g.FillRectangle(brushRed, rectRed);
            g.FillRectangle(brushOrange, rectOragne);
            g.FillRectangle(brushBlue, rectBlue);


            // Рисуем герб
            int centerX = width / 2;
            int centerY = height / 2;
            int radius = Math.Min(width, height) / 4;
            int strokeWidth = Math.Max(1, Math.Min(width, height) / 100);
            Color colorBlue2 = Color.FromArgb(21, 43, 105);
            Color colorRed2 = Color.FromArgb(195, 36, 41);
            
            Pen penBlue = new Pen(colorBlue2, strokeWidth);
            Pen penRed = new Pen(colorRed2, strokeWidth);

            // Рисуем круги
            g.FillEllipse(brushOrange, centerX - radius, centerY - radius, radius * 2, radius * 2);
            g.DrawEllipse(penBlue, centerX - radius, centerY - radius, radius * 2, radius * 2);
            g.DrawEllipse(penRed, centerX - radius * 3 / 4, centerY - radius * 3 / 4, radius * 1.5f, radius * 1.5f);

            // Рисуем символы
            Font font = new Font("Arial", radius / 2, FontStyle.Bold);
            string text = "Հ";
            SizeF textSize = g.MeasureString(text, font);
            PointF textPos = new PointF(centerX - textSize.Width / 2, centerY - textSize.Height / 2);
            g.DrawString(text, font, brushBlue, textPos);
        }
    }
}