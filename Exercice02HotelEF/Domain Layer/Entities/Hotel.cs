public class Hotel
{
    public int HotelId { get; set; }
    public ICollection<Client> Clients { get; set; }
    public ICollection<Chambre> Chambres { get; set; }
    public ICollection<Reservation> Reservations { get; set; }
}
