using MarsRover.Business.Business;
using MarsRover.Business.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MarsRover
{
    public static class Startup
    {
        public static ServiceProvider Start()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IReceiver, Reciever>();
            services.AddSingleton<IInvoker, Invoker>();
            return  services.BuildServiceProvider(true);
            
        }
    }
}
