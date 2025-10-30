using System.Collections.Generic;
namespace AdamAsmaca
{
    public class AdamAsmaca
    {
        public static void Main()
        {
            Console.Clear();
            Adam adam = new Adam();
            adam.Oyun();

        }
    }


    public class Kelimeler
    {
        public List<string> kelimeler = new List<string>() {
        "elma", "armut", "cicek"
      };

        public string Kelime_Sec()
        {
            Random rand = new Random();
            string secilen_kelime = kelimeler[rand.Next(kelimeler.Count())];
            return secilen_kelime;
        }
    }

    public class Adam
    {
        public List<string> adamlar = new List<string>()  {
    // Hata Sayısı: 0
    @"  +---+  
|   |  
|      
|      
|      
|      
|=========",

    // Hata Sayısı: 1
    @"  +---+  
 |   |  
 O   |  
|      
|      
|      
|=========",

    // Hata Sayısı: 2
    @"  +---+  
 |   |  
 O   |  
 |   |  
|      
|      
|=========",

    // Hata Sayısı: 3
    @"  +---+  
 |   |  
 O   |  
/|   |  
|      
|      
|=========",

    // Hata Sayısı: 4
    @"  +---+  
 |   |  
 O   |  
/|\  |  
|      
|      
|=========",

    // Hata Sayısı: 5
     @"  +---+  
 |   |  
 O   |  
/|\  |  
/    |  
|      
|=========",

    // Hata Sayısı: 6 (Oyun Bitti)
    @"  +---+  
 |   |  
 O   |  
/|\  |  
/ \  |  
|      
|========="
};

        public void Oyun()
        {
            char harf;
            Kelimeler kelime = new Kelimeler();
            string letter = kelime.Kelime_Sec();
            int i = 0;
            int hak = 7;
            int adam_index = 0;
            string gizli_kelime = new string('_', letter.Length);
            char[] gizli_kelime_dizi = gizli_kelime.ToCharArray();

            while (hak > 0 && i < letter.Length)
            {
                Console.Write(new string('\n', 10)); // 5 kere altsatıra geçer okunabilirlik için terminalde 
                Console.WriteLine("ADAM ASMACAYA HOŞGELDİNİZ!");
                Console.WriteLine(adamlar[adam_index]);
                Console.WriteLine(gizli_kelime);
                Console.Write("Harf tahmin ediniz-->");
                try
                {
                    harf = Convert.ToChar(Console.ReadLine()!); // ! ben bunun garanti null olmayacağımı biliyorum diyor compilera 
                                                                //string? ise o variable ın null olabileceğini söylüyor
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    harf = Convert.ToChar(Console.ReadLine()!); // ! ben bunun garanti null olmayacağımı biliyorum diyor compilera 
                }

                if (letter[i] == harf)
                {
                    Console.WriteLine($"tebrikler gerçekten de harf {harf}");
                    gizli_kelime_dizi[i] = harf;
                    gizli_kelime = new string(gizli_kelime_dizi);
                    i++;


                    if (i >= letter.Length)
                    {
                        Console.Clear();
                        Console.WriteLine($"tebrikler oyunu kazandınız!! {gizli_kelime}");
                        break;
                    }
                }


                else
                {
                    hak--;
                    adam_index++;
                    Console.WriteLine($"yanlış! {hak} hakkınız kaldı!");
                }

            }

            Console.WriteLine(adamlar[adam_index]);
            if (hak == 0) { Console.WriteLine("GAME OVER!!"); }
            else { Console.WriteLine(gizli_kelime); }
        }

    }
}
