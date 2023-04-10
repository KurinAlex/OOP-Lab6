using System.Diagnostics;

using SkiaSharp;

using OOP_Lab6.Utilities;

namespace OOP_Lab6.StructuralPatternExample;

public class StructuralPatternClient : IClient
{
	private const string PictureFile = "picture.png";

	private static readonly SKColor[] s_colors = new[]
	{
		new SKColor(255, 0, 0),
		new SKColor(0, 255, 0),
		new SKColor(0, 0, 255)
	};

	private static readonly SKPaint[] s_paints = s_colors.Select(c => new SKPaint { Color = c }).ToArray();

	public string PatternType => "structural";
	public string PatternName => "adapter";

	public void Main()
	{
		int imageWidth = InputHelper.GetInt32Input("picture width", w => w > 0);
		int imageHeight = InputHelper.GetInt32Input("picture height", h => h > 0);
		var imageInfo = new SKImageInfo(imageWidth, imageHeight);

		using var surface = SKSurface.Create(imageInfo);
		using var canvas = surface.Canvas;
		canvas.DrawColor(new SKColor(255, 255, 255));

		var rand = new Random();
		int shapesCount = InputHelper.GetInt32Input("shapes count", c => c > 0);
		for (int i = 0; i < shapesCount; i++)
		{
			double xRel = rand.NextDouble();
			double yRel = rand.NextDouble();
			var rel = new RelationalElement
			{
				XRel = xRel,
				YRel = yRel,
				WidthRel = rand.NextDouble() * (1.0 - xRel),
				HeightRel = rand.NextDouble() * (1.0 - yRel)
			};

			Shape adapter;
			if (rand.Next(2) == 0)
			{
				adapter = new RelationalElementAdapter<Rectangle>(rel);
			}
			else
			{
				adapter = new RelationalElementAdapter<Ellipse>(rel);
			}
			adapter.Render(canvas, s_paints[rand.Next(s_paints.Length)]);
		}

		using (var image = surface.Snapshot())
		using (var data = image.Encode(SKEncodedImageFormat.Png, 80))
		using (var stream = File.OpenWrite(PictureFile))
		{
			data.SaveTo(stream);
		}

		Process.Start("explorer.exe", PictureFile);
		Console.WriteLine("Picture created");
	}
}
