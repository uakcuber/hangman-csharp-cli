namespace AdamAsmaca;


public class Kelimeler
{
    public List<string> kelimeler = new List<string>() {
        "elma", "armut", "cicek", "araba", "muz", "anahtar"
      };

    public string Kelime_Sec()
    {
        Random rand = new Random();
        string secilen_kelime = kelimeler[rand.Next(kelimeler.Count())];
        return secilen_kelime;
    }
}
