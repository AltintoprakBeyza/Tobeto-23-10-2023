// See https://aka.ms/new-console-template for more information



using System.Linq;

Console.WriteLine("Sayı Giriniz:");
int sayiGir = Convert.ToInt32(Console.ReadLine());


Random rnd = new Random();
int[] rastgelesayi = new int[6];
for (int j = 0; j < sayiGir; j++)
{
    for (int i = 0; i < 6; i++)
    {
        int a = rnd.Next(1, 50);
        while (rastgelesayi.Contains(a))
        {
            a = rnd.Next(1, 50);
            if (!rastgelesayi.Contains(a))
            {
                break;
            }
        }
        rastgelesayi[i] = a;
    }
    Array.Sort(rastgelesayi);
    for (int i = 0; i < 6; i++)
    {
        Console.Write(rastgelesayi[i] + " ,");
    }
    Console.WriteLine("\n");
}
Console.ReadLine();
