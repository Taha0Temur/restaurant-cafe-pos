public class Masa
{
    public int MasaId { get; set; }
    public bool Durum { get; set; }
    public List<Adisyon> Adisyonlar { get; set; } = new();
}