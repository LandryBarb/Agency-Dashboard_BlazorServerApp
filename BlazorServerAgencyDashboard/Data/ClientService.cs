using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerAgencyDashboard.Data
{
    public class ClientService : IClientService
    {
        private readonly DataContext _context;
        private readonly NavigationManager _navMan; //don't do this here move to razor page logic
        public ClientService(DataContext context, NavigationManager navMan)
        {
            _context = context;
            _navMan = navMan;
            _context.Database.EnsureCreated(); //only for inmemory db
        }

        public List<Client> Clients { get; set; } = new List<Client>();

        public async Task AddClient(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            _navMan.NavigateTo("clients");
        }

        public async Task DeleteClient(int id)
        {
            var dbClient = await _context.Clients.FindAsync(id);
            if (dbClient == null)
            {
                throw new Exception($"No client found. ");

            }
            else
            {
                _context.Clients.Remove(dbClient);
                await _context.SaveChangesAsync();
                _navMan.NavigateTo("clients");
            }
        }

        public async Task GetClients()
        {
            Clients = await _context.Clients.ToListAsync();
        }

        public async Task<Client> GetSingleClient(int id)
        {
            var client = await _context.Clients.FindAsync(id);

            if (client == null)
            {
                throw new Exception($"No client found. ");
            }
            return client;
        }

        public async Task UpdateClient(Client client, int id)
        {
            var dbClient = await _context.Clients.FindAsync(id);
            if (dbClient == null)
            {
                throw new Exception($"No client found. ");

            }
            else
            {
                dbClient.FirstName = client.FirstName;
                dbClient.LastName = client.LastName;
                dbClient.Email = client.Email;
                dbClient.Birthdate = client.Birthdate;
                dbClient.Age = client.Age;

                await _context.SaveChangesAsync();
                _navMan.NavigateTo("clients");
            }
        }
    }
}
