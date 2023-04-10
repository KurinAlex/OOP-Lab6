namespace OOP_Lab6.CreationalPatternExample;

public interface IGuitar
{
	int PickupCount { get; }
	int FretsCount { get; }
	int StringsCount { get; }
	double ScaleLength { get; }

	bool PutStrings(IGuitarStrings strings);
}
