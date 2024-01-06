Herkese selam bu programda,

Kullanıcıya "Lütfen pozitif bir sayı giriniz:" şeklinde bir mesaj gösterilir.
int.TryParse metodu kullanılarak kullanıcının girdiği değer tamsayıya çevrilmeye çalışılır. Eğer çevrim başarılı değilse veya kullanıcının girdiği sayı 0'dan küçükse, kullanıcıya hatalı giriş yaptığı bildirilir ve pozitif bir sayı girene kadar bu işlem tekrarlanır.

Girilen sayının asal olup olmadığını kontrol etmek için IsAsal metodu çağrılır.

IsAsal metodu, sayının 2'den küçükse asal olmadığını kontrol eder ve false döndürür. Aksi takdirde, 2'den başlayarak sayının kareköküne kadar olan sayılar arasında bir döngü oluşturur.

Döngü içinde, eğer sayı herhangi bir i'ye tam bölünüyorsa (sayi % i == 0), sayı asal değildir ve false döndürülür.

Döngü tamamlandığında, sayı asal ise true döndürülür.

Program, IsAsal metodunun dönüş değerine göre ekrana "asal" veya "asal değil" mesajını yazdırır.

--------------------------------------------------------------------------
Hello everyone in this program,

The user is shown a message saying "Please enter a positive number:".
The int.TryParse method is used to try to convert the value entered by the user to an integer. If the conversion is not successful or if the number entered by the user is less than 0, the user is notified that he/she entered an incorrect number and this process is repeated until the user enters a positive number.

The IsAsal method is called to check if the entered number is prime.

The IsAsal method checks if the number is less than 2 and returns false. Otherwise, it loops through the numbers starting from 2 up to the square root of the number.

Inside the loop, if the number is exactly divisible by any i (sayi % i == 0), the number is not prime and false is returned.

When the loop completes, true is returned if the number is prime.

The program prints the message "prime" or "not prime" on the screen according to the return value of the IsAsal method.



