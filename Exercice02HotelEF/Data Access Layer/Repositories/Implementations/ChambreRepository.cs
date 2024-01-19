using Microsoft.EntityFrameworkCore;

public class ChambreRepository : IChambreRepository
{
    private readonly MyHotelDbContext _context;

    public ChambreRepository(MyHotelDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Chambre chambre)
    {
        await _context.Chambres.AddAsync(chambre);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var chambre = await _context.Chambres.FindAsync(id);
        if (chambre != null)
        {
            _context.Chambres.Remove(chambre);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Chambre>> GetAllAsync()
    {
        return await _context.Chambres.ToListAsync();
    }

    public async Task<Chambre> GetByIdAsync(int id)
    {
        return await _context.Chambres.FindAsync(id);
    }

    public async Task UpdateAsync(Chambre chambre)
    {
        _context.Chambres.Update(chambre);
        await _context.SaveChangesAsync();
    }
}
