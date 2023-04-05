namespace OOP_Lab6.CreationalPatternExample;

public class AcousticGuitarFactory : GuitarFactory
{
	public AcousticGuitarFactory(
		string model, int pickupCount, int fretsCount, int stringsCount, double scaleLength,
		int highGauge, int lowGauge)
		: base(model, pickupCount, fretsCount, stringsCount, scaleLength, highGauge, lowGauge)
	{
	}

	public override IGuitar CreateGuitar()
		=> new AcousticGuitar(_model, _pickupCount, _fretsCount, _stringsCount, _scaleLength);

	public override IGuitarStrings CreateGuitarStrings()
		=> new AcousticGuitarStrings(_highGauge, _lowGauge);
}
