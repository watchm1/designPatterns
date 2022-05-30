using System.Reflection.Metadata;

namespace DesignPatterns.SingletonPattern;

public class SingleClass
{
    private int value;

    private SingleClass()
    {
        value = 12;
    }

    public int GetValue()
    {
        return value;
    }

    public void SetValue(int a)
    {
        value = a;
    }

    private static SingleClass UniqueInstance = null;

    public static SingleClass Instance()
    {
        if(UniqueInstance == null)
        {
            UniqueInstance = new SingleClass();
        }

        return UniqueInstance;
    }
}