using System;
namespace KimMilyonerOlmakIster
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soruları ve cevapları dizi içerisinde tanımlandı.
            string[] questions = ["Soru1: Su kaç derecede donar? (A B)\r\n\rA) 0°C\r\nB) 100°C\r\n", "Soru2: Türkiye'nin başkenti neresidir?  (A B)\r\n\r\nA) İstanbul\r\nB) Ankara\n", "Soru3: Dünyanın uydusu hangisidir?  (A B)\r\n\r\nA) Mars\r\nB) Ay\n"];
            string[] answers = ["A", "B", "B"];

            // Doğru cevaplar için değişken oluşturuldu.
            int count = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]); // Sorular dizideki sıraya göre tek tek ekrana yazdırıldı.
                string read = Console.ReadLine().Trim(); // Kullanıcıdan cevap alındı.

                if (read != answers[i]) // Eğer cevap doğru değil ise ekrana yanlış cevap yazdırır.
                    Console.WriteLine("Yanlış Cevap!\n");

                else if (read == answers[i]) // Eğer cevap doğru ise doğru sayısını 1 arttırır.
                {
                    Console.WriteLine("Doğru Cevap!\n");
                    count++;

                    if (count == 2) // Doğru cevap sayımız 2 olduğunda yarışma kazanılır ve 3. soru ekranda çıkmaz.
                    {
                        Console.WriteLine($"Tebrikler Büyük Ödül Sizin!!! Doğru Sayınız : {count}");
                        break;
                    }
                } 
                if (i == 1 && count == 0) // Doğru cevap sayısı 0 olduğu için 3. soruyu görmeye gerek yok.                               
                    break;
            }
            if (count < 2) // 3 soru döngüsü tamamlandığında ve yanlış cevaplara göre başarısız olduğu ekrana yazdırıldı.
                Console.WriteLine($"Malesef Başarısız Oldunuz!!! Doğru Sayınız : {count} ");
        }
    }
}
