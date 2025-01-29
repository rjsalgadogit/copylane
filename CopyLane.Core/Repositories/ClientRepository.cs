using CopyLane.Core.Models;
using CopyLane.Core.Repositories.Interfaces;
using Sequel.Service.Interfaces;

namespace CopyLane.Core.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ISequelService<Client> _client;

        public ClientRepository(ISequelService<Client> client) 
        {
            _client = client;
        }

        public async Task GetData()
        {
            try
            {
                var test = await _client.ReadFromSequelClientAsync("SELECT * FROM [Transaction].[Client]", null);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
