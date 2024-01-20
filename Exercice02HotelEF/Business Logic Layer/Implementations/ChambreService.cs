public class ChambreService : IChambreService
{
    private readonly IChambreRepository _chambreRepository;

    public ChambreService(IChambreRepository chambreRepository)
    {
        _chambreRepository = chambreRepository;
    }

    public async Task AddChambreAsync(Chambre chambre)
    {
        await _chambreRepository.AddAsync(chambre);
    }

    public async Task DeleteChambreAsync(int id)
    {
        await _chambreRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Chambre>> GetAllChambresAsync()
    {
        return await _chambreRepository.GetAllAsync();
    }

    public async Task<Chambre> GetChambreByIdAsync(int id)
    {
        return await _chambreRepository.GetByIdAsync(id);
    }

    public async Task UpdateChambreAsync(Chambre chambre)
    {
        await _chambreRepository.UpdateAsync(chambre);
    }
}
