using SkiaSharp;

namespace OOP_Lab6.StructuralPatternExample;

public abstract class Shape
{
	public int X { get; init; }
	public int Y { get; init; }
	public int Width { get; init; }
	public int Height { get; init; }

	public abstract void Render(SKCanvas g, SKPaint brush);
}
