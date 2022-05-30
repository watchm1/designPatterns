namespace DesignPatterns.ObserverPattern;

public class OtherGraph : Observer
{
    private Data source;
    private List<int> datas;

    public OtherGraph(Data k)
    {
        datas = new List<int>();
        source = k;
        foreach (var item in source.GetData())
        {
            datas.Add(item);
        }
    }
    public void Update()
    {
        datas.Clear();
        foreach (var item in source.GetData())
        {
            datas.Add(item);
        }

        Console.WriteLine("Updated successfully");
        Console.WriteLine(datas);
    }
}