using OOP_Lab6.Utilities;

namespace OOP_Lab6.CreationalPatternExample;

public class CreationalPatternClient : IClient
{
	private static readonly Dictionary<string, IGuitarFactory> s_factories = new()
	{
		["a"] = new AcousticGuitarFactory("HOHNER HW 220-TWR", 0, 20, 6, 25.59, 10, 50),
		["c"] = new ClassicalGuitarFactory("YAMAHA C40", 0, 19, 6, 25.59, 28, 43),
		["e"] = new ElectricGuitarFactory("YAMAHA ERG121U", 3, 22, 6, 25.5, 13, 65)
	};

	public string PatternType => "creational";
	public string PatternName => "abstract factory";

	public void Main()
	{
		var guitarFactory = InputHelper.MakeChoice(s_factories, f => $"to create {f.Name} guitar factory");

		var guitar = guitarFactory.CreateGuitar();
		Console.WriteLine($"Guitar {guitar} created");

		var guitarStrings = guitarFactory.CreateGuitarStrings();
		Console.WriteLine($"Guitar strings {guitarStrings} created");

		if (guitar.PutStrings(guitarStrings))
		{
			Console.WriteLine($"Strings {guitarStrings} successfully put on {guitar}");
		}
		else
		{
			Console.WriteLine($"ERROR: Strings {guitarStrings} cannot be put on {guitar}");
		}
	}
}