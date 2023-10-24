class Program
{
    static void Main(string[] args)
    {
        //Add();
        //Add();
        //Add();
        //var result = Add2();

        //int number1 = 20;
        //int number2 = 100;
        //var result2 = Add3(out number1, number2);
        //Console.WriteLine(result2);
        //Console.WriteLine(number1);
        Console.WriteLine(Multiply(2, 4));
        Console.WriteLine(Multiply(2, 4,5));
        Console.WriteLine(Add4(2, 3, 4, 5,6));
        //Console.Readline();



    }


    static void Add()
    {
        Console.WriteLine("Added!!!");

    }

    //Farklı bir yerde ihtiyaç olduğunda tanımladığımız metodu çağırıyoruz.

    static int Add2(int number1, int number2 = 30)
    {
        var result = number1 + number2;
        return result;
    }

    //Add();
    //Add();
    //var result = Add2(20, 30);
    //Console.WriteLine(result);
    //Console.ReadLine();

    //Default Parametreli Metotlarla Çalışmak
    //Üstteki örnekte number2 = 30 'un anlamı eğer number 2 ye değer verilmez ise 30 u kullan.
    //Default değerlerin her zaman metodun en sonunda olması gerekiyor.!

    static int Add3(out int number1, int number2)
    {
        number1 = 30;
        return number1 + number2;
    }


//Out Keyword
//ref'in alternatifidir

//Method Overloading
static int Multiply(int number1, int number2)
{
    return number1 * number2;
}

static int Multiply(int number1, int number2,int number3)
{
    return number1 * number2* number3;
 }
//Params Keyword
//Params ile metoda aynı tipte istediğin kadar parametre gönderebilirsin.
static int Add4(params int[] numbers)
{
        return numbers.Sum();
 }
}
