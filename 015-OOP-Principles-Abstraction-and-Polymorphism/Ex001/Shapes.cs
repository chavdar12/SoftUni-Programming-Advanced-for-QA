namespace Ex001;

public interface IDrawable
{
    void Draw();
}

public class Circle : IDrawable
{
    private readonly int _radius;

    public Circle(int radius)
    {
        _radius = radius;
    }

    public void Draw()
    {
        var rIn = _radius - 0.4;
        var rOut = _radius + 0.4;

        for (double y = _radius; y >= -_radius; --y)
        {
            for (double x = -_radius; x < rOut; x += 0.5)
            {
                var value = x * x + y * y;
                Console.Write(value >= rIn * rIn && value <= rOut * rOut ? "*" : " ");
            }

            Console.WriteLine();
        }
    }
}

public class Rectangle : IDrawable
{
    private readonly int _width;
    private readonly int _height;

    public Rectangle(int width, int height)
    {
        _width = width;
        _height = height;
    }

    public void Draw()
    {
        DrawLine('*', '*');
        for (var i = 1; i < _height - 1; ++i) DrawLine('*', ' ');
        DrawLine('*', '*');
    }

    private void DrawLine(char end, char mid)
    {
        Console.WriteLine(end + new string(mid, _width - 2) + end);
    }
}
