namespace OOP_Lab6.CreationalPatternExample;

public class ElectricGuitarFactory : GuitarFactory
{
	public ElectricGuitarFactory(
		string model, int pickupCount, int fretsCount, int stringsCount, double scaleLength,
		int highGauge, int lowGauge)
		: base(model, pickupCount, fretsCount, stringsCount, scaleLength, highGauge, lowGauge)
	{
	}

	public override string Name => "electric";

	public override IGuitar CreateGuitar()
		=> new ElectricGuitar(_model, _pickupCount, _fretsCount, _stringsCount, _scaleLength);

	public override IGuitarStrings CreateGuitarStrings()
		=> new ElectricGuitarStrings(_highGauge, _lowGauge);
}
