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
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Gestion des clients");
            Console.WriteLine("1. Ajouter un client");
            Console.WriteLine("2. Afficher les clients");
            Console.WriteLine("3. Modifier un client");
            Console.WriteLine("4. Supprimer un client");
            Console.WriteLine("5. Retour au menu principal");
            Console.Write("Entrez votre choix: ");

            var choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    AjouterClient();
                    break;
                case "2":
                    AfficherClients();
                    break;
                case "3":
                    ModifierClient();
                    break;
                case "4":
                    SupprimerClient();
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

    private void AjouterClient()
    {
        Console.Write("Entrez le nom du client : ");
        var nom = Console.ReadLine();

        Console.Write("Entrez le prénom du client : ");
        var prénom = Console.ReadLine();

        Console.Write("Entrez le numéro de téléphone du client : ");
        var numéroTéléphone = Console.ReadLine();
        Console.WriteLine("Client ajouté avec succès.");
    }


    private void SupprimerClient()
    {
        Console.Write("Entrez l'ID du client à supprimer : ");
        var id = int.Parse(Console.ReadLine());
        Console.WriteLine("Client supprimé avec succès.");
    }


    private void ModifierClient()
    {
        // Logique pour modifier les informations d'un client existant
    }

    private void SupprimerClient()
    {
        // Logique pour supprimer un client
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
