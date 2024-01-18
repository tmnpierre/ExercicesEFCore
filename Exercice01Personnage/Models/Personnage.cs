namespace Exercice01Personnage.Models
{
    public class Personnage
    {
        public int Id { get; set; }
        public string Pseudo { get; set; }
        public int PointsDeVie { get; set; }
        public int Armure { get; set; }
        public int Degats { get; set; }
        public DateTime DateCreation { get; set; }
        public int NombrePersonneTues { get; set; }
    }
}
