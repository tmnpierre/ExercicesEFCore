﻿public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task AddClientAsync(Client client)
    {
        await _clientRepository.AddAsync(client);
    }

    public async Task DeleteClientAsync(int id)
    {
        await _clientRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Client>> GetAllClientsAsync()
    {
        return await _clientRepository.GetAllAsync();
    }

    public async Task<Client> GetClientByIdAsync(int id)
    {
        return await _clientRepository.GetByIdAsync(id);
    }

    public async Task UpdateClientAsync(Client client)
    {
        await _clientRepository.UpdateAsync(client);
    }
}
