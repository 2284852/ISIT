using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_7
{
    public class Vertex
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Point Location { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }
        public bool IsSelected { get; set; }

        public Vertex(int id, string name, Point location)
        {
            Id = id;
            Name = name;
            Location = location;
            Radius = 25;
            Color = Color.FromArgb(52, 152, 219);
            IsSelected = false;
        }

        public bool Contains(Point point)
        {
            int dx = point.X - Location.X;
            int dy = point.Y - Location.Y;
            return (dx * dx + dy * dy) <= (Radius * Radius);
        }

        public void Draw(Graphics g)
        {
            int diameter = Radius * 2;
            int x = Location.X - Radius;
            int y = Location.Y - Radius;

            Brush brush = null;
            Pen pen = null;

            try
            {
                // Создаем кисть и перо
                if (IsSelected)
                {
                    brush = Brushes.Gold;
                    pen = Pens.DarkOrange;
                }
                else
                {
                    brush = new SolidBrush(Color);
                    pen = Pens.Black;
                }

                g.FillEllipse(brush, x, y, diameter, diameter);
                g.DrawEllipse(pen, x, y, diameter, diameter);

                // Рисуем название НАД вершиной
                if (!string.IsNullOrEmpty(Name))
                {
                    Font font = new Font("Segoe UI", 9, FontStyle.Bold);
                    SizeF textSize = g.MeasureString(Name, font);
                    Point textLocation = new Point(
                        Location.X - (int)(textSize.Width / 2),
                        Location.Y - Radius - (int)textSize.Height - 5
                    );

                    g.FillRectangle(Brushes.White,
                        textLocation.X - 2, textLocation.Y - 2,
                        (int)textSize.Width + 4, (int)textSize.Height + 4);
                    g.DrawRectangle(Pens.Black,
                        textLocation.X - 2, textLocation.Y - 2,
                        (int)textSize.Width + 4, (int)textSize.Height + 4);
                    g.DrawString(Name, font, Brushes.Black, textLocation);
                    font.Dispose();
                }
            }
            finally
            {
                // Освобождаем только созданные нами ресурсы
                if (brush != null && brush != Brushes.Gold && brush != Brushes.White && brush != Brushes.Black)
                    brush.Dispose();

                if (pen != null && pen != Pens.DarkOrange && pen != Pens.Black)
                    pen.Dispose();
            }
        }
    }
}
