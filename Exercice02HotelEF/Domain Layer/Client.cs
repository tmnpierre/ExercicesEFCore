public class Client
{
    public int ClientId { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string NuméroTéléphone { get; set; }

    public ICollection<Reservation> Reservations { get; set; }
}
