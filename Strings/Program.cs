// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//String - Metinsel ifadeleri tanımlarız.

static void Main(string[] args)
{
    string city = "Ankara";
    //Console.WriteLine(city[0]); //İlk eleman a olduğu için ekrana a yazar.
    foreach(var item in city)
    {
        Console.WriteLine(item);
    }
    string city2 = "İstanbul";
    string result = city + city2; //İki stringi yan yana ekler.
    Console.ReadLine();
}

string sentence = "My name is Engin Demiroğ";

var result = sentence.Length; //Cümlenin kaç karakterden oluştuğunu verir.
Console.WriteLine(result);    //Boşlukta bir karakterdir.


var result2 = sentence.Clone(); // Klonlama işlemi
Console.WriteLine(result2);


bool result3 = sentence.EndsWith("ğ"); // Cümle ğ ile mi bitiyor?
Console.WriteLine(result3);            //True or false çıktı verir.


bool result4 = sentence.StartsWith("My name"); // My name ile başlıyor mu?
Console.WriteLine(result4);

var result5 = sentence.IndexOf("name"); //Bir sgtringte belirli bir ifadeyi aramak için kullanılır.
Console.WriteLine(result5);              //// Bulamadığında -1 döndürür.

var result6 = sentence.IndexOf(" "); // Metinde bir sürü boşluk var.Bulduğu ilk ifadeyi getirir.
Console.WriteLine(result6);

var result7 = sentence.LastIndexOf(" "); // Aramaya en sondan başlar. IndexOf ile aynıdır.
Console.WriteLine(result7);

var result8 = sentence.Insert(0, "Hello, "); // 0'dan itibaren Hello, ekle.
Console.WriteLine(result8);

var result9 = sentence.Substring(3, 4); // Metini parçalamak için kullanılır.
Console.WriteLine(result9);            // 3'den itibaren 4 tane al(Sonuç name)

var result10 = sentence.ToLower();    // Bütün karakterleri küçük harfe çevirmeye yarar.
Console.WriteLine(result10);

var result11 = sentence.ToUpper();  // Büyük harf çevirmeye yarar.
Console.WriteLine(result11); 

var result12 = sentence.Replace(" ", "-"); // Metin içerisinde belirli karakterleri değiştirmek için kullanırız..

var result13 = sentence.Remove(2, 4); // Metinden belli bir indexten sonrasını atar.
                                      //2 den sonra 4 tane kaldır.
Console.WriteLine(result13);

Console.ReadLine();

//Intro();

static void Intro()
{
    string city = "Ankara";

    Console.WriteLine(city[0]);

    foreach (var item in city)
    {
        Console.WriteLine(item);
    }

    string city2 = "İstanbul";

    //string result = city + city2;
    //Console.WriteLine(result);

    Console.WriteLine(String.Format("{0} {1}", city, city2));

    Console.ReadLine();
}