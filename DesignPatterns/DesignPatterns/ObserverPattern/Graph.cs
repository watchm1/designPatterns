namespace DesignPatterns.ObserverPattern;

public class Graph : Observer
{
    private Data source;
    private List<Int32> datas;

    public Graph(Data d)
    {
        datas = new List<int>();
        source = d;
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