using OOP_Lab6.Utilities;
using OOP_Lab6.CreationalPatternExample;

namespace OOP_Lab6;

class Program
{
	static readonly Dictionary<string, IClient> s_clients = new()
	{
		["c"] = new CreationalPatternClient()
	};

	static IClient ChooseClient()
	{
		foreach (var (key, client) in s_clients)
		{
			Console.WriteLine($"Enter {key} to choose creational pattern ({client.Name}) client");
		}
		while (true)
		{
			Console.Write("> ");
			string input = Console.ReadLine()!;
			if (s_clients.TryGetValue(input, out var client))
			{
				Console.WriteLine();
				return client;
			}
		}
	}

	static void Main()
	{
		while (true)
		{
			var client = ChooseClient();
			client.Main();

			Console.ReadLine();
			Console.Clear();
		}
	}
}
