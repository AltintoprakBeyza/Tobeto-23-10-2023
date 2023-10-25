// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Loops (Döngüler)


static void Main(string[] args)
{
    for (int i = 1; i <= 100; i++)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished!");
    Console.ReadLine();
}


static void WhileLoop(string[] args)
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--; //Sonsuz döngüyü kırmak için
    }
    Console.WriteLine("Now number is {0}", number);
    Console.ReadLine();
}


static void DoWhileLoop(string[] args) //Sık kullanılan bir döngü değildir.
{
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;
    } while (number >= 11);
    Console.ReadLine();
}

static void ForEachLoop(string[] args) //En çok kullanılan döngülerden biridir.
{
    string[] students = new string[3] { "Engin", "Demir", "Salih" };
    foreach (var stundent in students)
    {
        Console.WriteLine(stundent);
    }
    Console.ReadLine();
}

static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number-1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            i = number;
        }
    }

    return result;
}

if (IsPrimeNumber(10))
{
    Console.WriteLine("This is a prime number");
}

else
{
    Console.WriteLine("This is not a prime number");
}