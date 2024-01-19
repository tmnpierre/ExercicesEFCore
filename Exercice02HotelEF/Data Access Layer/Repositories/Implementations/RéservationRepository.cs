using Microsoft.EntityFrameworkCore;

public class ReservationRepository : IReservationRepository
{
    private readonly MyHotelDbContext _context;

    public ReservationRepository(MyHotelDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Reservation reservation)
    {
        await _context.Réservations.AddAsync(reservation);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var reservation = await _context.Réservations.FindAsync(id);
        if (reservation != null)
        {
            _context.Réservations.Remove(reservation);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Reservation>> GetAllAsync()
    {
        return await _context.Réservations.ToListAsync();
    }

    public async Task<Reservation> GetByIdAsync(int id)
    {
        return await _context.Réservations.FindAsync(id);
    }

    public async Task UpdateAsync(Reservation reservation)
    {
        _context.Réservations.Update(reservation);
        await _context.SaveChangesAsync();
    }
}
