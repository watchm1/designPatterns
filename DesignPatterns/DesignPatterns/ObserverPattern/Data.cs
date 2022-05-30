namespace DesignPatterns.ObserverPattern;

public class Data : Subject
{
    private List<int> list;
    private List<Observer> observers;
    private Random randomVal;

    public Data()
    {
        randomVal = new Random();
        list = new List<int>();
        list.Add(randomVal.Next());
        list.Add(randomVal.Next());
        list.Add(randomVal.Next());

        observers = new List<Observer>();
    }
    public void Attach(Observer o)
    {
        observers.Add(o);
    }

    public void Detach(Observer o)
    {
        observers.Remove(o);
    }

    public void Notify()
    {
        foreach (Observer item in observers)
        {
            item.Update();
        }
    }

    public void NewData()
    {
        list.Add(randomVal.Next());
    }

    public List<int> GetData()
    {
        return list;
    }
}