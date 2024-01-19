﻿using Microsoft.EntityFrameworkCore;

public class HotelRepository : IHotelRepository
{
    private readonly MyHotelDbContext _context;

    public HotelRepository(MyHotelDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Hotel hotel)
    {
        await _context.Hotels.AddAsync(hotel);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var hotel = await _context.Hotels.FindAsync(id);
        if (hotel != null)
        {
            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Hotel>> GetAllAsync()
    {
        return await _context.Hotels.ToListAsync();
    }

    public async Task<Hotel> GetByIdAsync(int id)
    {
        return await _context.Hotels.FindAsync(id);
    }

    public async Task UpdateAsync(Hotel hotel)
    {
        _context.Hotels.Update(hotel);
        await _context.SaveChangesAsync();
    }
}
