public class Dikdortgen : BaseGeometrikSekil
{
    public override double AlanHesapla() // Alan hesaplama metodu
    {
        return Genislik * Yukseklik; // Dikdörtgen için alan
    }
}
