public class Hotel
{
    public ICollection<Client> Clients { get; set; }
    public ICollection<Chambre> Chambres { get; set; }
    public ICollection<Reservation> Reservations { get; set; }
}
