using SkiaSharp;

namespace OOP_Lab6.StructuralPatternExample;

public class Rectangle : Shape
{
	public override void Render(SKCanvas canvas, SKPaint paint)
	{
		canvas.DrawRect(X, Y, Width, Height, paint);
	}
}
