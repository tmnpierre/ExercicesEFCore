public interface IHotelService
{
    Task<Hotel> GetHotelByIdAsync(int id);
    Task<IEnumerable<Hotel>> GetAllHotelsAsync();
    Task AddHotelAsync(Hotel hotel);
    Task UpdateHotelAsync(Hotel hotel);
    Task DeleteHotelAsync(int id);
}
