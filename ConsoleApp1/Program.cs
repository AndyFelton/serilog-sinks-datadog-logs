using Serilog.Sinks.Datadog.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Serilog.Debugging.SelfLog.Enable(Console.Error);

            var config = new DatadogConfiguration(url: "https://http-intake.logs.datadoghq.eu", port: 443, useSSL: true);
            //var log1 = new LoggerConfiguration()
            //    .WriteTo.DatadogLogs(
            //        "407f0d06e5c7057d58321048e24dae7d",
            //        source: "source",
            //        service: "service",
            //        host: "hostname",
            //        configuration: config
            //    );

            var log2Config = new LoggerConfiguration()
                .ReadFrom.AppSettings();

            var log2 = log2Config
                .CreateLogger();

            while (true)
            {
                log2.Warning("Disk quota {Quota} MB exceeded by {User}", 111, 222);
                System.Threading.Thread.Sleep(120000);
            }

        }
    }
}
