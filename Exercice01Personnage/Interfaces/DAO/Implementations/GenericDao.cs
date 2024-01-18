using Exercice01Personnage.DAO.Interfaces;
using Exercice01Personnage.Data;
using Microsoft.EntityFrameworkCore;

namespace Exercice01Personnage.DAO.Implementations
{
    public class GenericDao<T> : IGenericDao<T> where T : class
    {
        protected readonly ApplicationDbContext _context;

        public GenericDao(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
