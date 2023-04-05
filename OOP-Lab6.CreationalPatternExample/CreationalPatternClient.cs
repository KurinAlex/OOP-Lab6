using OOP_Lab6.Utilities;

namespace OOP_Lab6.CreationalPatternExample;

public class CreationalPatternClient : IClient
{
	private static readonly Dictionary<string, (string Name, IGuitarFactory Factory)> s_actions = new()
	{
		["a"] = ("acoustic", new AcousticGuitarFactory("HOHNER HW 220-TWR", 0, 20, 6, 25.59, 10, 50)),
		["c"] = ("classical", new ClassicalGuitarFactory("YAMAHA C40", 0, 19, 6, 25.59, 28, 43)),
		["e"] = ("electric", new ElectricGuitarFactory("YAMAHA ERG121U", 3, 22, 6, 25.5, 13, 65))
	};

	public string Name => "creational pattern";

	private static IGuitarFactory CreateFactory()
	{
		foreach (var (key, (name, _)) in s_actions)
		{
			Console.WriteLine($"Enter {key} to create {name} guitar factory");
		}
		while (true)
		{
			Console.Write("> ");
			string input = Console.ReadLine()!;
			if (s_actions.TryGetValue(input, out var res))
			{
				Console.WriteLine();
				return res.Factory;
			}
		}
	}

	public void Main()
	{
		var guitarFactory = CreateFactory();
		Console.WriteLine($"Guitar factory created");

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

		Console.ReadLine();
	}
}