using ConsoleApp1.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1.Services;

public class ScopedExample
{
    public static void Run()
    {
        while (true)
        {
            var services = new ServiceCollection();
            services.AddScoped<IExample, Example>();
            var serviceProvider = services.BuildServiceProvider();
            var scopedExample = serviceProvider.GetService<IExample>();

            try
            {
                scopedExample?.ExecuteScoped();
                scopedExample?.PrintCounter();
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