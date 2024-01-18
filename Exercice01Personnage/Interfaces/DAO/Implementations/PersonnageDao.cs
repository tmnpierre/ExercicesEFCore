using Exercice01Personnage.DAO.Interfaces;
using Exercice01Personnage.Data;
using Exercice01Personnage.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice01Personnage.DAO.Implementations
{
    public class PersonnageDao : GenericDao<Personnage>, IPersonnageDao
    {
        public PersonnageDao(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Personnage>> GetPersonnagesWithMoreThanAverageHealthAsync()
        {
            var averageHealth = await _context.Personnages.AverageAsync(p => p.PointsDeVie + p.Armure);
            return await _context.Personnages
                .Where(p => (p.PointsDeVie + p.Armure) > averageHealth)
                .ToListAsync();
        }
    }
}
