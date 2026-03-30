public class Singleton {
    public static Singleton Instance { get; private set; }

    string s = string.Empty;

    private Singleton()
    {

    }

    public static Singleton getInstance()
    {
        if(Instance == null) Instance = new Singleton();
        return Instance;
    }

    public string getValue()
    {
        return s;
    }

    public void setValue(string value)
    {
        s = value;
    }
}
