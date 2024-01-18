using Exercice01Personnage.DAO.Implementations;
using Exercice01Personnage.Data;
using Exercice01Personnage.IHM;
using Exercice01Personnage.Services;

namespace Exercice01Personnage
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {
                var personnageDao = new PersonnageDao(context);
                var personnageController = new PersonnageController(personnageDao);
                var consoleInterface = new ConsoleInterface(personnageController);

                await consoleInterface.Run();
            }
        }
    }
}
