namespace ConsoleApp1.Interfaces;

public interface IExample
{
    void ExecuteSingleton();
    void ExecuteScoped();
    void ExecuteTransient();
    void PrintCounter();
}