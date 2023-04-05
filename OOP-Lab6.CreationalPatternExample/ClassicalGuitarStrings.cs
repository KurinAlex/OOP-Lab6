namespace OOP_Lab6.CreationalPatternExample;

public class ClassicalGuitarStrings : GuitarStrings
{
	public ClassicalGuitarStrings(int highGauge, int lowGauge)
		: base(highGauge, lowGauge, GuitarStringsMaterial.Nylon)
	{
	}
}
