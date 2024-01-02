class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Exercises 1");

        int userValue;

        do/* ------>// Kullanıcıdan giriş al  // Girişi değerlendir ve işle // Doğru bir durumda döngüden çık*/
           
          
        {
            Console.WriteLine("Please enter any number: ");
            string userInput = Console.ReadLine();

            if (IsInteger(userInput, out userValue))
            {
                Console.WriteLine($"Okay, you entered a number: {userValue}");
                break; // Doğru sayı girildiği için döngüden çıkılır.
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (true); // Kullanıcı doğru bir sayı girene kadar döngü devam eder.
    }

    static bool IsInteger(string input, out int result)/*IsInteger metodu: Verilen string ifadeyi tamsayıya dönüştürmeye çalışır
    */
    {
        
            result = 0; // Varsayılan bir değer atanabilir.
            
        


        return int.TryParse(input, out result);/* (int.TryParse). Eğer dönüşüm başarılı olursa, true döner ve çıktıyı out parametresi aracılığıyla iletir. E
    ğer dönüşüm başarısız olursa, false döner ve out parametresine varsayılan bir değeri atar.*/
    }
}