using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_7
{
    public class Edge
    {
        public int Id { get; set; }
        public Vertex From { get; set; }
        public Vertex To { get; set; }
        public int Distance { get; set; }
        public Color Color { get; set; }
        public bool IsSelected { get; set; }

        public Edge(int id, Vertex from, Vertex to, int distance)
        {
            Id = id;
            From = from;
            To = to;
            Distance = distance;
            Color = Color.FromArgb(142, 142, 142);
            IsSelected = false;
        }

        public bool Contains(Point point, int threshold = 5)
        {
            float distance = PointToLineDistance(point, From.Location, To.Location);
            return distance <= threshold;
        }

        private float PointToLineDistance(Point p, Point v, Point w)
        {
            float l2 = (v.X - w.X) * (v.X - w.X) + (v.Y - w.Y) * (v.Y - w.Y);
            if (l2 == 0) return (float)Math.Sqrt((p.X - v.X) * (p.X - v.X) + (p.Y - v.Y) * (p.Y - v.Y));

            float t = ((p.X - v.X) * (w.X - v.X) + (p.Y - v.Y) * (w.Y - v.Y)) / l2;
            t = Math.Max(0, Math.Min(1, t));

            Point projection = new Point(
                v.X + (int)(t * (w.X - v.X)),
                v.Y + (int)(t * (w.Y - v.Y))
            );

            return (float)Math.Sqrt((p.X - projection.X) * (p.X - projection.X) +
                                   (p.Y - projection.Y) * (p.Y - projection.Y));
        }

        public void Draw(Graphics g)
        {
            Pen pen = null;

            try
            {
                if (IsSelected)
                {
                    pen = new Pen(Color.Red, 3);
                }
                else
                {
                    pen = new Pen(Color, 2);
                }

                g.DrawLine(pen, From.Location, To.Location);

                Point midPoint = new Point(
                    (From.Location.X + To.Location.X) / 2,
                    (From.Location.Y + To.Location.Y) / 2
                );

                string distanceText = Distance.ToString() + " км";
                Font font = new Font("Segoe UI", 8, FontStyle.Bold);
                SizeF textSize = g.MeasureString(distanceText, font);

                g.FillRectangle(Brushes.White,
                    midPoint.X - textSize.Width / 2 - 2,
                    midPoint.Y - textSize.Height / 2 - 2,
                    textSize.Width + 4, textSize.Height + 4);

                g.DrawString(distanceText, font, Brushes.Black, midPoint);
                font.Dispose();
            }
            finally
            {
                if (pen != null)
                    pen.Dispose();
            }
        }
    }
}
