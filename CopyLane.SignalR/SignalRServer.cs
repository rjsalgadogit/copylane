﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CopyLane.SignalR
{
    public class SignalRServer
    {
        public SignalRServer() { }

        public void Start()
        {
            // Run the server in a separate thread to avoid blocking UI
            new Thread(() => ServerStart()).Start();
        }

        public void ServerStart()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSignalR();
                    services.AddCors(options =>
                    {
                        options.AddDefaultPolicy(policy =>
                        {
                            policy.AllowAnyHeader()
                                  .AllowAnyMethod()
                                  .AllowCredentials()
                                  .SetIsOriginAllowed(_ => true); // Allow all origins
                        });
                    });
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseKestrel() // Use Kestrel for the web server   
                        .Configure(app =>
                        {
                            app.UseRouting();
                            app.UseEndpoints(endpoints =>
                            {
                                endpoints.MapHub<SignalRHub>("/signalr-hub"); // Map the SignalR hub to "/myHub"
                            });
                        })
                        .UseUrls("http://localhost:5055"); // Listen on localhost:5055
                })
                .Build();

            host.RunAsync();
        }
    }
}