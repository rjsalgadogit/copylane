using Microsoft.Extensions.Configuration;
using Sequel.Service.Interfaces;

namespace CopyLane.Server.Sequel
{
    public class DataSequelConnection : ISequelConnection
    {
        private string _connectionString = string.Empty;

        public DataSequelConnection(IConfiguration config)
        {
            _connectionString = config.GetValue<string>("ConnectionStrings:DataConnection");
        }

        public string ConnectionString => _connectionString;
    }
}
