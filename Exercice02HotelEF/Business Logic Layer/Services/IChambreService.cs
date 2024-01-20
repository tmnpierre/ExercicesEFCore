public interface IChambreService
{
    Task<Chambre> GetChambreByIdAsync(int id);
    Task<IEnumerable<Chambre>> GetAllChambresAsync();
    Task AddChambreAsync(Chambre chambre);
    Task UpdateChambreAsync(Chambre chambre);
    Task DeleteChambreAsync(int id);
}
