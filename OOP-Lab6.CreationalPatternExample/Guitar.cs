namespace OOP_Lab6.CreationalPatternExample;

public abstract class Guitar : IGuitar
{
	public Guitar(string model, int pickupCount, int fretsCount, int stringsCount, double scaleLength)
	{
		Model = model;
		PickupCount = pickupCount;
		FretsCount = fretsCount;
		StringsCount = stringsCount;
		ScaleLength = scaleLength;
	}

	public string Model { get; init; }
	public int PickupCount { get; init; }
	public int FretsCount { get; init; }
	public int StringsCount { get; init; }
	public double ScaleLength { get; init; }

	public abstract bool PutStrings(IGuitarStrings strings);
	public override string ToString() => Model;
}
