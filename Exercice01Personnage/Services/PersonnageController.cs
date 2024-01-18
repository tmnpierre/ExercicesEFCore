using Exercice01Personnage.DAO.Interfaces;
using Exercice01Personnage.Models;

namespace Exercice01Personnage.Services
{
    public class PersonnageController
    {
        private readonly IPersonnageDao _personnageDao;

        public PersonnageController(IPersonnageDao personnageDao)
        {
            _personnageDao = personnageDao;
        }

        public async Task<Personnage> GetPersonnageByIdAsync(int id)
        {
            return await _personnageDao.GetByIdAsync(id);
        }

        public async Task<List<Personnage>> GetAllPersonnagesAsync()
        {
            return await _personnageDao.GetAllAsync();
        }

        public async Task AddPersonnageAsync(Personnage personnage)
        {
            await _personnageDao.AddAsync(personnage);
        }

        public async Task UpdatePersonnageAsync(Personnage personnage)
        {
            await _personnageDao.UpdateAsync(personnage);
        }

        public async Task DeletePersonnageAsync(Personnage personnage)
        {
            await _personnageDao.DeleteAsync(personnage);
        }

        public async Task<IEnumerable<Personnage>> GetPersonnagesWithMoreThanAverageHealthAsync()
        {
            return await _personnageDao.GetPersonnagesWithMoreThanAverageHealthAsync();
        }
    }
}