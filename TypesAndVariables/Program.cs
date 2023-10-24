// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//C# Dersleri 5: Integer Veri Tipi
//integer veri tipi: Değer tiplerinden(Value Types) bir tanesidir.
//int - veri tipi, number1- variable(değişken)
int number1 = 10;
Console.WriteLine("Number1 is {0}",number1);


//Bütün veri tiplerinin sınırları vardır.integer veri tipinin sınırı -2147483648 ile 2147483647 arasındaki sayılardır.

//Long Veri Tipi

//long integer'ı kapsar.Integer 32 bit Long 64 bitlik yer kaplarFakat bellekte daha fazla yer kaplar.Sınırları 19 karakter. -9223372036854775808 ile 9223372036854775808.
long number2 = 9223372036854775807;
Console.WriteLine("Number2 is {0}", number2);
Console.ReadLine();

//Short Veri Tipi
//-32768 ve 32768
short number3 = -32768;
Console.WriteLine("Number3 is {0}", number3);

//Byte Veri Tipi
//Bellekte 8 bit yani 1 byte yer kaplar. 0 ile 255 arasında bir değer.
byte number4 = 255;
Console.WriteLine("Number4 is {0}", number4);

//Boolean - Değer Tipleri 
//Mantıksal bir veri tipidir. Tuttuğu değer true veya false.
bool condition = true;
Console.WriteLine(condition);

//Char Veri Tipi - Değer Tipleri
//string değişkeni character örneğidir. örneğin string city = "Ankara" 6 tane karakterden oluşan bir dizidir.
char character = 'A';
Console.WriteLine("Character is : {0}", character);
//Integer gibi bir veri tipine çevirilebilir. WriteLine kısmına (int)character yazdığımızda çıktı ASCII değeri olarak gelir. Sonuç 65 olur.

//Double Veri Tipi - Değer Tipleri
//ondalıklı sayıları tanımlıyoruz.Integer gibi değer de atayabiliyoruz. 64 bit yer kaplıyor.
double number5 = 10.4;
Console.WriteLine("Number5 is {0}", number5);

//Decimal Veri Tipi
//Hassas değerler, para tutarı gibi decimalden yararlanabiliyoruz. Virgülden sonra 28,29 değer tutabiliyor.Sonuna m harfini ekliyoruz.
decimal number6 = 10.4m;
Console.WriteLine("Number6 is {0}", number6);

//Enum Veri Tipi
//Karşılaştırma yapacağımız zaman Days.Friday == olarak çağırabiliyoruz.Tip Dönüşümümde: (int)Days.Friday sonuç 4 olur.4.Değeri çağırır.
//Başlangıç değeri Monday=10 dersek Tuesday 11 olacak şekilde kendisi ayarlar.
enum Days
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}

//Var Keyword'u
//Değişken tutmak için kullanılur.
var number7 = 10;
number7 = 'A'; //İlk atamamız integer olduğu için bundan sonraki tüm atamalarımız integer kabul edilir.Sonuç 65 olur.
//number7 = "A"; Bunu kabul etmez çünkü A bir string, string atayamazsın.