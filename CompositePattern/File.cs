namespace CompositePattern;

public class File : IFileSystem
{
    private string _name;
    private int _size;

    public File(string name, int size)
    {
        _name = name;
        _size = size;
    }

    public int GetSize()
    {
        return _size;
    }

    public void PrintStructure()
    {
        Console.WriteLine($"File:{_name}");
    }
}