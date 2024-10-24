class Program
{
    static void Main(string[] args)
    {
        // Kare nesnesi oluşturma
        Kare kare = new Kare
        {
            Genislik = 5,
            Yukseklik = 5
        };

        // Dikdörtgen nesnesi oluşturma
        Dikdortgen dikdortgen = new Dikdortgen
        {
            Genislik = 4,
            Yukseklik = 6
        };

        // Dik Üçgen nesnesi oluşturma
        DikUcgen dikUcgen = new DikUcgen
        {
            Genislik = 4,
            Yukseklik = 3
        };

        // Alan hesaplama ve yazdırma
        Console.WriteLine("Kare Alanı: " + kare.AlanHesapla());
        Console.WriteLine("Dikdörtgen Alanı: " + dikdortgen.AlanHesapla());
        Console.WriteLine("Dik Üçgen Alanı: " + dikUcgen.AlanHesapla());
    }
}
