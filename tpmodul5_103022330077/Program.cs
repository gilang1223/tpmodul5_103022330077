// See https://aka.ms/new-console-template for more information
public class halloGeneric
{
    public void SayHello<T>(T name)
    {
        Console.WriteLine("Hello, " + name);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        halloGeneric hg = new halloGeneric();
        hg.SayHello("gilang");
    }
}
