namespace BlazorServerAgencyDashboard.Data
{
    public interface IClientService
    {
        List<Client> Clients { get; set; }
        Task GetClients();
        Task<Client> GetSingleClient(int id);
        Task AddClient(Client client);
        Task UpdateClient(Client client, int id);
        Task DeleteClient(int id);

    }
}
