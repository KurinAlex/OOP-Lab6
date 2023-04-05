namespace OOP_Lab6.CreationalPatternExample;

public interface IGuitarFactory
{
	IGuitar CreateGuitar();
	IGuitarStrings CreateGuitarStrings();
}
