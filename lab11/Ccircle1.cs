using System;
using System.Drawing;

namespace lab11
{
    class CCircleTriangle
    {
        private const int DefaultRadius = 50;
        private Graphics graphics;
        private int _radius;

        public int X { get; set; }
        public int Y { get; set; }
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value >= 200 ? 200 : (value <= 5 ? 5 : value);
            }
        }

        public CCircleTriangle(Graphics graphics, int X, int Y)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = DefaultRadius;
        }

        public CCircleTriangle(Graphics graphics, int X, int Y, int Radius)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
        }

        private void Draw(Pen pen)
        {
            Rectangle rectangle = new Rectangle(X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            graphics.DrawEllipse(pen, rectangle);

            DrawTriangle(pen);
        }
        private void DrawTriangle(Pen pen)
        {
            int sideLength = Radius * 2; // Довжина сторони трикутника рівна діаметру кола

            PointF point1 = new PointF(X, Y - Radius); // Вершина трикутника вгорі
            PointF point2 = new PointF(X - sideLength / 2, Y + Radius); // Вершина трикутника ліворуч
            PointF point3 = new PointF(X + sideLength / 2, Y + Radius); // Вершина трикутника праворуч

            PointF[] trianglePoints = { point1, point2, point3 };

            graphics.DrawPolygon(pen, trianglePoints);
        }

        public void Show()
        {
            Draw(Pens.Red);
        }

        public void Hide()
        {
            Draw(Pens.White);
        }

        public void Expand()
        {
            Hide();
            Radius++;
            Show();
        }

        public void Expand(int dR)
        {
            Hide();
            Radius += dR;
            Show();
        }

        public void Collapse()
        {
            Hide();
            Radius--;
            Show();
        }

        public void Collapse(int dR)
        {
            Hide();
            Radius -= dR;
            Show();
        }

        public void Move(int dX, int dY)
        {
            Hide();
            X += dX;
            Y += dY;
            Show();
        }
    }
}