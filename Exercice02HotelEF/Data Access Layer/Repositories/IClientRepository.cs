﻿public interface IClientRepository
{
    Task<Client> GetByIdAsync(int id);
    Task<IEnumerable<Client>> GetAllAsync();
    Task AddAsync(Client client);
    Task UpdateAsync(Client client);
    Task DeleteAsync(int id);
}
