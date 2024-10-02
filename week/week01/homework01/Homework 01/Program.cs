namespace homework_proje_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Değişkenlerin tanımlanması
            string myName = "Aysel";
            string className = "11-C";
            string classMate1 = "Selim";
            string classMate2 = "Ceren";
            string classMate3 = "Rukiye";
            string classMate4 = "Çigdem";
            string classMate5 = "Ufuk";
            string asistantManager = "Serhan";
            string asistantManagerGender = "bey";
            string destination1 = "Avcılar";
            string destination2 = "Maltepe";

            //konsola mesaj yazdırma
            Console.WriteLine($"Benim adım {myName}. Bizler {className} sınıfında okuyoruz.");

            Console.WriteLine($"Bugün sınıfta {classMate1}, {classMate2}, {classMate3}, {classMate4} ve {classMate5} birlikte bir oyun oynadık.");

            Console.WriteLine($"{myName}-{classMate1},{classMate2}-{classMate4} ve {classMate3}-{classMate5} şeklinde takımlara ayrıldık.");

            Console.WriteLine($"Oyunun sonunda {classMate2}-{classMate4} takımı şampiyon olurken,{myName}-{classMate1} sonuncu oldu.");

            Console.WriteLine($"Oyunun sonunda {classMate1} takımı müdür yardımcısının odasına gidip, yemek istedi.");

            Console.WriteLine($"Müdür yardımcısı {asistantManagerGender} {asistantManager}, bizlere kızıp bol bolnasihat etti.");

            Console.WriteLine($"{classMate1}, {classMate3} ve {classMate4} {destination1} otobüsüne binerken {classMate2} ve {classMate5} ise {destination2} otobüsüne bindi.");

            Console.WriteLine("Evlerimize dağılmış olduk.");








        }






    }
}
