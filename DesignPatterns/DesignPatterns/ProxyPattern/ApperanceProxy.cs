namespace DesignPatterns.ProxyPattern;

public class ApperanceProxy : Graph
{
    private Apperance graph;

    public ApperanceProxy(string p)
    {
        filePath = p;
        graph = new Apperance();
    }
    public override void Draw()
    {
        graph.Draw();
    }

    public override void GraphInformation()
    {
        Console.WriteLine("File name " + filePath);
    }
}