// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//string student1 = "Engin";
//string student2 = "Derin";
//string student3 = "Salih";

//Arraylerle aynı tipteki değerleri,değişkenleri tek bir noktada yönetebiliyoruz.

string[] students = new string[3]; //Bu bir string array.

students[0] = "Engin";
students[1] = "Derin";
students[2] = "Salih";

string[] students4 = new string[3] { "Engin", "Derin", "Salih" };

string[] students2 = new[] { "Engin", "Derin", "Salih" };
string[] students3 = { "Engin", "Derin", "Salih" };

foreach (var student in students)
{
    Console.WriteLine();
    Console.ReadLine();
}

//Arraylerde string yazıyorsan string devam etmeli. Farklı türde derleme hatası verir.

//Çok boyutlu diziler

string[,] regions = new string[5, 3]
{
    {"İstanbul","İzmit","Balıkesir" },
    {"Ankara","Konya","Kırıkkale" },
    {"Antalya","Anada","Mersin" },
    {"Rize","Trabzon","Samsun" },
    {"İzmir","Muğla","Manisa"},
};

for (int i =0; i<= regions.GetUpperBound(0); i++)
{
    for(int j =0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i, j]);
    }
    Console.WriteLine("********");
}