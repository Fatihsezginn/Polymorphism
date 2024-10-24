public class Kare : BaseGeometrikSekil
{
    public override double AlanHesapla() // Alan hesaplama metodu
    {
        return Genislik * Yukseklik; // Kare için alan (Genislik = Yukseklik)
    }
}

