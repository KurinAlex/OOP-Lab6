namespace OOP_Lab6.CreationalPatternExample;

public class AcousticGuitarStrings : GuitarStrings
{
	public AcousticGuitarStrings(int highGauge, int lowGauge)
		: base(highGauge, lowGauge, GuitarStringsMaterial.Bronze)
	{
	}
}
