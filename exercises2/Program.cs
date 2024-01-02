/* Kullanıcıdan alınan bir sayının asal olup olmadığını kontrol eden bir program yazın. */



Console.WriteLine("Welcome to exercises 2");
Console.WriteLine("Lütfen Pozitif bir sayı giriniz:");
int value;
while(!int.TryParse(Console.ReadLine(),out value) || value<=0)
{
            Console.WriteLine("Hatalı giriş.Lütfen pozitif bir sayı giriniz !");
            Console.Write("Lütfen pozitif bir sayı girin:", + value);
}
          if(IsAsal(value))
            {
                Console.WriteLine("Girmiş olduğunuz sayı asaldır.");

            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz sayı asal bir sayı değildir");
            }



 static bool IsAsal(int sayi)
        {
         if (sayi < 2) // Sayı 2'den küçükse asal değildir.
         return false;


          // 2'den başlayarak sayının kareköküne kadar olan sayılara kadar bir döngü oluşturulur.
         // Bu döngü, sayının asal olup olmadığını kontrol etmek için kullanılır.
         for (int i = 2; i < Math.Sqrt(sayi); i++)


         // Eğer sayı i'ye tam bölünüyorsa, sayı asal değildir.
         {
            if (sayi % i == 0)
            return false;
         }
            return true;
        }
         // Döngüden hiçbir bölme işlemi sonucunda asal olmadığı belirlenmemişse, sayı asaldır.