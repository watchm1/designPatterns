namespace DesignPatterns.AdapterPattern;

public class OGGAdapter : Music
{
    private OGG ogg;
    public OGGAdapter(string value) : base(value)
    {
        ogg = new OGG(value);
    }

    public void MP3Play()
    {
        ogg.OGGPlay(1);
    }
}