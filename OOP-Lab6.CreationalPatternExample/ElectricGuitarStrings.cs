namespace OOP_Lab6.CreationalPatternExample;

public class ElectricGuitarStrings : GuitarStrings
{
	public ElectricGuitarStrings(int highGauge, int lowGauge)
		: base(highGauge, lowGauge, GuitarStringsMaterial.Nickel)
	{
	}
}
