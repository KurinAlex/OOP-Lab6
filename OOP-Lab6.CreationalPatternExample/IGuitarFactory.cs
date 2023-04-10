namespace OOP_Lab6.CreationalPatternExample;

public interface IGuitarFactory
{
	string Name { get; }

	IGuitar CreateGuitar();
	IGuitarStrings CreateGuitarStrings();
}
