using ConsoleApp1.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1.Services;

public class SingletonExample
{
    public static void Run()
    {
        var services = new ServiceCollection();
        services.AddSingleton<IExample, Example>();
        var serviceProvider = services.BuildServiceProvider();

        while (true)
        {
            var singletonExample = serviceProvider.GetService<IExample>();

            try
            {
                singletonExample?.ExecuteSingleton();
                singletonExample?.PrintCounter();
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            Console.WriteLine("Executando...");
            Thread.Sleep(4000); // aguarda por 4 segundos antes de executar a próxima iteração
        }
    }  
}