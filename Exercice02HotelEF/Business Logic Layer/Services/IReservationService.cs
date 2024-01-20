public interface IReservationService
{
    Task<Reservation> GetReservationByIdAsync(int id);
    Task<IEnumerable<Reservation>> GetAllReservationsAsync();
    Task AddReservationAsync(Reservation reservation);
    Task UpdateReservationAsync(Reservation reservation);
    Task DeleteReservationAsync(int id);
}
