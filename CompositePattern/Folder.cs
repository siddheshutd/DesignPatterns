namespace CompositePattern;

public class Folder : IFileSystem
{
    private string _name;
    private List<IFileSystem> _files = new List<IFileSystem>();

    public Folder(string name)
    {
        _name = name;
    }

    public void Add(IFileSystem file)
    {
        _files.Add(file);
    }

    public void Remove(IFileSystem file)
    {
        _files.Remove(file);
    }

    public int GetSize()
    {
        int tempSize = 0;
        foreach (IFileSystem file in _files)
        {
            tempSize += file.GetSize();
        }
        return tempSize;
    }

    public void PrintStructure()
    {
        Console.WriteLine($"Folder:{_name}");
        foreach (IFileSystem file in _files)
        {
            file.PrintStructure();
        }
    }
}
