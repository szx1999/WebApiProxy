using Microsoft.AspNetCore.Hosting;
using System;

namespace Jawasoft.ServiceProxy.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new TestService().Hi("szx"));
            new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://*:8000", "http://*:8001")
                .ConfigureServices(services =>
                {
                    //services.
                });

            Console.ReadKey();
        }
    }
}
