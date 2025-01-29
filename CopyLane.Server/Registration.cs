using CopyLane.Core.Repositories.Interfaces;
using CopyLane.Core.Repositories;
using CopyLane.Core.Services.Interfaces;
using CopyLane.Core.Services;
using CopyLane.Server.Sequel;
using Microsoft.Extensions.DependencyInjection;
using Sequel.Service.Interfaces;
using Sequel.Service;

namespace CopyLane.Server
{
    public static class Registration
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<MainForm>();
            services.AddTransient(typeof(ISequelConnection), typeof(DataSequelConnection));

            #region Services

            services.AddTransient<IServerService, ServerService>();

            #endregion

            #region Repositories

            services.AddTransient<IClientRepository, ClientRepository>();

            #endregion

            #region Sequel Services

            services.AddTransient(typeof(ISequelService<CopyLane.Core.Models.Client>), typeof(SequelService<CopyLane.Core.Models.Client>));

            #endregion
        }
    }
}
