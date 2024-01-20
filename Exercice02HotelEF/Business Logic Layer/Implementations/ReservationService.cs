public class ReservationService : IReservationService
{
    private readonly IReservationRepository _réservationRepository;

    public ReservationService(IReservationRepository reservationRepository)
    {
        _réservationRepository = reservationRepository;
    }

    public async Task AddReservationAsync(Reservation reservation)
    {
        await _réservationRepository.AddAsync(reservation);
    }

    public async Task DeleteReservationAsync(int id)
    {
        await _réservationRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Reservation>> GetAllReservationsAsync()
    {
        return await _réservationRepository.GetAllAsync();
    }

    public async Task<Reservation> GetReservationByIdAsync(int id)
    {
        return await _réservationRepository.GetByIdAsync(id);
    }

    public async Task UpdateReservationAsync(Reservation reservation)
    {
        await _réservationRepository.UpdateAsync(reservation);
    }
}
