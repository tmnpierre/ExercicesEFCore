public enum StatutChambre
{
    Libre,
    Occupé,
    EnNettoyage
}

public class Chambre
{
    public int ChambreId { get; set; }
    public StatutChambre Statut { get; set; }
    public int NombreLits { get; set; }
    public decimal Tarif { get; set; }
    public int Numero { get; set; }
    public ICollection<Reservation> Reservations { get; set; }
}
