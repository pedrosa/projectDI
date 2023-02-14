using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Services;

public class Example : IExample
{
    private static int instanceCount = 0;

    public Example()
    {
        instanceCount++;
    }

    public void ExecuteSingleton()
    {
        Console.WriteLine("Exemplo Singleton executado!");
    }
    public void ExecuteScoped()
    {
        Console.WriteLine("Exemplo Scoped executado!");
    } 
    public void ExecuteTransient()
    {
        Console.WriteLine("Exemplo Transient executado!");
    }

    public void PrintCounter()
    {
        Console.WriteLine($"Número de instâncias criadas: {instanceCount}");
    }
}

