namespace OOP_Lab6.CreationalPatternExample;

public abstract class GuitarStrings : IGuitarStrings
{
	protected GuitarStrings(int highGauge, int lowGauge, GuitarStringsMaterial material)
	{
		HighGauge = highGauge;
		LowGauge = lowGauge;
		Material = material;
	}

	public int HighGauge { get; init; }
	public int LowGauge { get; init; }
	public GuitarStringsMaterial Material { get; }

	public override string ToString() => $"{HighGauge}-{LowGauge}";
}
