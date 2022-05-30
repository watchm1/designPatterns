namespace DesignPatterns.AdapterPattern;

public class Player
{
    private List<Music> list;

    public Player()
    {
        list = new List<Music>();
    }

    public void AddToList(Music m)
    {
        list.Add(m);
    }

    public void Play()
    {
        foreach (var item in list)
        {
            item.PlayMP3();
        }
    }
}