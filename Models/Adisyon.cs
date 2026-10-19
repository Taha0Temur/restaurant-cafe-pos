public class Adisyon
{
    public int AdisyonId { get; set; }
    public DateTime AcilisZaman { get; set; }
    public DateTime? KapanisZaman { get; set; }
    public decimal Bahsis { get; set; }
    public int MasaId { get; set; }
    public int GarsonId { get; set; }
    public List<SiparisKalemi> Kalemler { get; set; } = new();
}