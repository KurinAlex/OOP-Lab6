namespace OOP_Lab6.CreationalPatternExample;

public class AcousticGuitar : Guitar
{
	public AcousticGuitar(string model, int pickupCount, int fretsCount, int stringsCount, double scaleLength)
		: base(model, pickupCount, fretsCount, stringsCount, scaleLength)
	{
	}

	public override bool PutStrings(IGuitarStrings strings) => strings.Material == GuitarStringsMaterial.Bronze;
}
