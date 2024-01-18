using Exercice01Personnage.Models;
using Exercice01Personnage.Services;
namespace Exercice01Personnage.IHM
{
    public class ConsoleInterface
    {
        private readonly PersonnageController _personnageController;

        public ConsoleInterface(PersonnageController personnageController)
        {
            _personnageController = personnageController;
        }

        public async Task Run()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nGestion des Personnages:");
                Console.WriteLine("1. Créer un personnage");
                Console.WriteLine("2. Mettre à jour un personnage");
                Console.WriteLine("3. Afficher tous les personnages");
                Console.WriteLine("4. Taper un personnage");
                Console.WriteLine("5. Afficher les personnages avec plus de PVs que la moyenne");
                Console.WriteLine("6. Quitter");
                Console.Write("Choisissez une option: ");

                int.TryParse(Console.ReadLine(), out int choice);

                switch (choice)
                {
                    case 1:
                        await CreatePersonnageAsync();
                        break;
                    case 2:
                        await UpdatePersonnageAsync();
                        break;
                    case 3:
                        await DisplayAllPersonnagesAsync();
                        break;
                    case 4:
                        await HitPersonnageAsync();
                        break;
                    case 5:
                        await DisplayPersonnagesAboveAverageHealthAsync();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Option non valide, veuillez réessayer.");
                        break;
                }
            }
        }

        private async Task CreatePersonnageAsync()
        {
            Console.WriteLine("\nCréation d'un nouveau personnage:");
            Console.Write("Pseudo: ");
            string pseudo = Console.ReadLine();
            Console.Write("Points de Vie: ");
            int.TryParse(Console.ReadLine(), out int pointsDeVie);
            Console.Write("Armure: ");
            int.TryParse(Console.ReadLine(), out int armure);
            Console.Write("Dégâts: ");
            int.TryParse(Console.ReadLine(), out int degats);

            var personnage = new Personnage
            {
                Pseudo = pseudo,
                PointsDeVie = pointsDeVie,
                Armure = armure,
                Degats = degats,
                DateCreation = DateTime.Now
            };

            await _personnageController.AddPersonnageAsync(personnage);
            Console.WriteLine("Personnage créé avec succès!");
        }

        private async Task UpdatePersonnageAsync()
        {
            Console.WriteLine("\nMise à jour d'un personnage:");
            Console.Write("Entrez l'ID du personnage à mettre à jour: ");
            int.TryParse(Console.ReadLine(), out int id);

            var personnageToUpdate = await _personnageController.GetPersonnageByIdAsync(id);
            if (personnageToUpdate == null)
            {
                Console.WriteLine("Personnage non trouvé.");
                return;
            }

            Console.Write("Nouveau Pseudo (laisser vide pour ne pas changer): ");
            string newPseudo = Console.ReadLine();
            if (!string.IsNullOrEmpty(newPseudo))
            {
                personnageToUpdate.Pseudo = newPseudo;
            }

            Console.Write("Nouveaux Points de Vie (laisser vide pour ne pas changer): ");
            if (int.TryParse(Console.ReadLine(), out int newPointsDeVie))
            {
                personnageToUpdate.PointsDeVie = newPointsDeVie;
            }

            Console.Write("Nouvelle Armure (laisser vide pour ne pas changer): ");
            if (int.TryParse(Console.ReadLine(), out int newArmure))
            {
                personnageToUpdate.Armure = newArmure;
            }

            Console.Write("Nouveaux Dégâts (laisser vide pour ne pas changer): ");
            if (int.TryParse(Console.ReadLine(), out int newDegats))
            {
                personnageToUpdate.Degats = newDegats;
            }

            await _personnageController.UpdatePersonnageAsync(personnageToUpdate);
            Console.WriteLine("Personnage mis à jour avec succès!");
        }

        private async Task DisplayAllPersonnagesAsync()
        {
            Console.WriteLine("\nListe de tous les personnages:");
            var personnages = await _personnageController.GetAllPersonnagesAsync();
            foreach (var personnage in personnages)
            {
                Console.WriteLine($"ID: {personnage.Id}, Pseudo: {personnage.Pseudo}, PV: {personnage.PointsDeVie}, Armure: {personnage.Armure}, Dégâts: {personnage.Degats}");
            }
        }

        private async Task HitPersonnageAsync()
        {
            Console.WriteLine("\nTaper un personnage:");
            Console.Write("Entrez l'ID du personnage à taper: ");
            int.TryParse(Console.ReadLine(), out int id);
            Console.Write("Dégâts à infliger: ");
            int.TryParse(Console.ReadLine(), out int degats);

            var personnageToHit = await _personnageController.GetPersonnageByIdAsync(id);
            if (personnageToHit == null)
            {
                Console.WriteLine("Personnage non trouvé.");
                return;
            }

            personnageToHit.PointsDeVie -= degats;
            if (personnageToHit.PointsDeVie <= 0)
            {
                personnageToHit.PointsDeVie = 0;
                await _personnageController.DeletePersonnageAsync(personnageToHit);
                Console.WriteLine("Personnage a été supprimé car il n'a plus de points de vie.");
            }
            else
            {
                await _personnageController.UpdatePersonnageAsync(personnageToHit);
                Console.WriteLine($"Personnage tapé. Nouveaux PV: {personnageToHit.PointsDeVie}");
            }
        }

        private async Task DisplayPersonnagesAboveAverageHealthAsync()
        {
            Console.WriteLine("\nPersonnages avec plus de PV que la moyenne:");
            var personnages = await _personnageController.GetPersonnagesWithMoreThanAverageHealthAsync();
            foreach (var personnage in personnages)
            {
                Console.WriteLine($"ID: {personnage.Id}, Pseudo: {personnage.Pseudo}, PV: {personnage.PointsDeVie + personnage.Armure}");
            }
        }
    }
}
