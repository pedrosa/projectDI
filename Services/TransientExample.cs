using ConsoleApp1.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1.Services;

public class TransientExample
{
    public static void Run()
    {
        var services = new ServiceCollection();
        services.AddTransient<IExample, Example>();
        var serviceProvider = services.BuildServiceProvider();

        while (true)
        {
            var transientExample = serviceProvider.GetService<IExample>();

            try
            {
                transientExample?.ExecuteTransient();
                transientExample?.PrintCounter();
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