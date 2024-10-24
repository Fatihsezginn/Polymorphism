public class BaseGeometrikSekil
{
    public double Genislik { get; set; } // Genişlik
    public double Yukseklik { get; set; } // Yükseklik

    public virtual double AlanHesapla() // Alan hesaplama metodu
    {
        return Genislik * Yukseklik; // Varsayılan alan hesaplama (Dikdörtgen)
    }
}
