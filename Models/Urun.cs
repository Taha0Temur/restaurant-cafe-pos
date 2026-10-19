public class Urun
{
    public int UrunId { get; set; }
    public string UrunAd { get; set; } = "";
    public decimal SatisFiyati { get; set; }
    public decimal Maliyet { get; set; }
    public int Stok { get; set; }
    public string Kategori { get; set; } = ""; 
}