namespace DesignPatterns.ProxyPattern;

public class Apperance : Graph
{
    private byte[] data;

    public Apperance(string p)
    {
        filePath = p;
        data = null;
    }
    public override void Draw()
    {
        if (data == null)
        {
            Console.WriteLine("Dosya yükleniyor: "+filePath);
            data = new byte[11111111111];
            Console.WriteLine("Dosya çiziliyor...");
        }
        else
        {
            Console.WriteLine("Dosya çiziliyor...");
        }
    }

    public override void GraphInformation()
    {
        throw new NotImplementedException();
    }
}