using SkiaSharp;

namespace OOP_Lab6.StructuralPatternExample;

public class Ellipse : Shape
{
	public override void Render(SKCanvas canvas, SKPaint paint)
	{
		int rx = Width / 2;
		int ry = Height / 2;
		canvas.DrawOval(X + rx, Y + ry, rx, ry, paint);
	}
}
