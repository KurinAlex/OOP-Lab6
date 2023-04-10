using SkiaSharp;

namespace OOP_Lab6.StructuralPatternExample;

public class RelationalElementAdapter<T> : Shape where T : Shape, new()
{
	private readonly RelationalElement _relationalElement;

	public RelationalElementAdapter(RelationalElement relationalElement)
		=> _relationalElement = relationalElement;

	public override void Render(SKCanvas canvas, SKPaint paint)
	{
		var clipBounds = canvas.DeviceClipBounds;
		double x = clipBounds.Left;
		double y = clipBounds.Top;
		double width = clipBounds.Width;
		double height = clipBounds.Height;

		var el = new T
		{
			X = (int)(_relationalElement.XRel * width + x),
			Y = (int)(_relationalElement.YRel * height + y),
			Width = (int)(_relationalElement.WidthRel * width),
			Height = (int)(_relationalElement.HeightRel * height),
		};
		el.Render(canvas, paint);
	}
}
