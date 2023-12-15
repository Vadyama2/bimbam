using System;
using System.Drawing;

class CCircleTriangles
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

    public CCircleTriangles(Graphics graphics, int X, int Y)
    {
        this.graphics = graphics;
        this.X = X;
        this.Y = Y;
        this.Radius = DefaultRadius;
    }

    public CCircleTriangles(Graphics graphics, int X, int Y, int Radius)
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
        DrawTriangle(pen, 0); // Перший трикутник
        DrawTriangle(pen, 180); // Другий трикутник (перевернутий)
    }

    private void DrawTriangle(Pen pen, int rotationAngle)
    {
        Point[] trianglePoints = new Point[3];

        double angle = rotationAngle * Math.PI / 180.0;
        double triangleHeight = Math.Sqrt(3) / 2 * Radius;
        double triangleBase = Radius;

        for (int i = 0; i < 3; i++)
        {
            int x = X + (int)(Math.Cos(angle) * triangleBase);
            int y = Y + (int)(Math.Sin(angle) * triangleBase);
            trianglePoints[i] = new Point(x, y);
            angle += (2 * Math.PI / 3); // 120 degrees
        }

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
