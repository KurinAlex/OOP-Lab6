namespace OOP_Lab6.CreationalPatternExample;

public abstract class GuitarFactory : IGuitarFactory
{
	protected readonly string _model;
	protected readonly int _pickupCount;
	protected readonly int _fretsCount;
	protected readonly int _stringsCount;
	protected readonly double _scaleLength;
	protected readonly int _highGauge;
	protected readonly int _lowGauge;

	public GuitarFactory(
		string model, int pickupCount, int fretsCount, int stringsCount, double scaleLength,
		int highGauge, int lowGauge)
	{
		_model = model;
		_pickupCount = pickupCount;
		_fretsCount = fretsCount;
		_stringsCount = stringsCount;
		_scaleLength = scaleLength;
		_highGauge = highGauge;
		_lowGauge = lowGauge;
	}

	public abstract IGuitar CreateGuitar();
	public abstract IGuitarStrings CreateGuitarStrings();
}
