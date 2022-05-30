namespace DesignPatterns.AdapterPattern;

public class Music
{
    private string name;

    public Music(string value)
    {
        name = value;
    }

    public void PlayMP3()
    {
        Console.WriteLine(this.name + "playing...");
    }
}