Selam bu programda;

Kullanıcıya "Lütfen herhangi bir sayı girin:" şeklinde bir mesaj gösterilir.
IsInteger metodu kullanılarak kullanıcının girdiği değer tamsayıya çevrilmeye çalışılır.

Eğer çevrim başarılıysa, IsInteger metodu true döner ve tamsayı değeri out parametresi üzerinden iletilir. Bu durumda döngüden çıkılır ve kullanıcıya girdiği sayı gösterilir.
Eğer çevrim başarısızsa, IsInteger metodu false döner ve out parametresine varsayılan bir değer atanır. Kullanıcıya "Geçersiz giriş. Lütfen geçerli bir sayı girin." mesajı gösterilir ve döngü devam eder.
Do-while döngüsü, kullanıcının geçerli bir sayı girene kadar devam eder (while (true)). Bu, kullanıcının doğru bir giriş yapana kadar tekrar tekrar giriş yapmasını sağlar.

Programın amacı, kullanıcının geçerli bir tamsayı girene kadar kullanıcı ile etkileşimde bulunmak ve ardından bu sayıyı ekrana yazdırmaktır.
-------------------------------------
Hi in this program;

The user is presented with a message saying "Please enter any number:".
The IsInteger method is used to convert the value entered by the user to an integer.

If the conversion is successful, the IsInteger method returns true and the integer value is passed through the out parameter. In this case the loop is exited and the user is shown the number they entered.
If the loop failed, the IsInteger method returns false and a default value is assigned to the out parameter. The user will receive the message "Invalid input. Please enter a valid number." and the loop continues.
The do-while loop continues until the user enters a valid number (while (true)). This allows the user to enter repeatedly until he/she enters a correct entry.

The goal of the program is to interact with the user until the user enters a valid integer and then print that number to the screen.
