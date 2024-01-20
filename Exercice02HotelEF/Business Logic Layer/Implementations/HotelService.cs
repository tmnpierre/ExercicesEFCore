public class HotelService : IHotelService
{
    private readonly IHotelRepository _hotelRepository;

    public HotelService(IHotelRepository hotelRepository)
    {
        _hotelRepository = hotelRepository;
    }

    public async Task AddHotelAsync(Hotel hotel)
    {
        await _hotelRepository.AddAsync(hotel);
    }

    public async Task DeleteHotelAsync(int id)
    {
        await _hotelRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Hotel>> GetAllHotelsAsync()
    {
        return await _hotelRepository.GetAllAsync();
    }

    public async Task<Hotel> GetHotelByIdAsync(int id)
    {
        return await _hotelRepository.GetByIdAsync(id);
    }

    public async Task UpdateHotelAsync(Hotel hotel)
    {
        await _hotelRepository.UpdateAsync(hotel);
    }
}
