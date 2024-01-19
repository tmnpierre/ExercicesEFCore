public enum StatutReservation
{
    Prévu,
    EnCours,
    Fini,
    Annulé
}

public class Reservation
{
    public int ReservationId { get; set; }
    public StatutReservation Statut { get; set; }

    public int ClientId { get; set; }
    public Client Client { get; set; }
    public ICollection<Chambre> Chambres { get; set; }
}
