using Exercice01Personnage.Models;
namespace Exercice01Personnage.DAO.Interfaces
{
    public interface IPersonnageDao : IGenericDao<Personnage>
    {
        Task<IEnumerable<Personnage>> GetPersonnagesWithMoreThanAverageHealthAsync();
    }
}
