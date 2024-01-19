﻿using Microsoft.EntityFrameworkCore;

public class ClientRepository : IClientRepository
{
    private readonly MyHotelDbContext _context;

    public ClientRepository(MyHotelDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Client client)
    {
        await _context.Clients.AddAsync(client);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var client = await _context.Clients.FindAsync(id);
        if (client != null)
        {
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Client>> GetAllAsync()
    {
        return await _context.Clients.ToListAsync();
    }

    public async Task<Client> GetByIdAsync(int id)
    {
        return await _context.Clients.FindAsync(id);
    }

    public async Task UpdateAsync(Client client)
    {
        _context.Clients.Update(client);
        await _context.SaveChangesAsync();
    }
}
