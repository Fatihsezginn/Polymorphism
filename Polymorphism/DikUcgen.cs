public class DikUcgen : BaseGeometrikSekil
{
    public override double AlanHesapla() // Alan hesaplama metodu
    {
        return (Genislik * Yukseklik) / 2; // Dik Üçgen için alan
    }
}
