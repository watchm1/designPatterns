namespace DesignPatterns.AdapterPattern;

public class OGG
{
    private string SongName;

    public OGG(string value)
    {
        SongName = value;
    }

    public void OGGPlay(int speed)
    {
        Console.WriteLine(speed);
    }
}