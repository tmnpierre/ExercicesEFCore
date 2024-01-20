public class IHM : IIHM
{
    public void Lancer()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Bienvenue dans le système de gestion d'hôtel");
            Console.WriteLine("1. Gérer les clients");
            Console.WriteLine("2. Gérer les chambres");
            Console.WriteLine("3. Gérer les réservations");
            Console.WriteLine("4. Gérer l'hôtel");
            Console.WriteLine("5. Quitter");
            Console.Write("Entrez votre choix: ");

            var choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    GérerClients();
                    break;
                case "2":
                    GérerChambres();
                    break;
                case "3":
                    GérerRéservations();
                    break;
                case "4":
                    GérerHôtel();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Choix invalide. Veuillez réessayer.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("Appuyez sur une touche pour continuer...");
                Console.ReadKey();
            }
        }
    }

    private void GérerClients()
    {
        Console.WriteLine("Gestion des clients - Implémentation à venir");
        // Implémentation de la logique de gestion des clients
    }

    private void GérerChambres()
    {
        Console.WriteLine("Gestion des chambres - Implémentation à venir");
        // Implémentation de la logique de gestion des chambres
    }

    private void GérerRéservations()
    {
        Console.WriteLine("Gestion des réservations - Implémentation à venir");
        // Implémentation de la logique de gestion des réservations
    }

    private void GérerHôtel()
    {
        Console.WriteLine("Gestion de l'hôtel - Implémentation à venir");
        // Implémentation de la logique de gestion de l'hôtel
    }
}
