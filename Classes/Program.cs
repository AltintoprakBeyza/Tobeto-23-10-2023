

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); //Tanımladığımız classı kullanmak için onun bir örneğini oluşturmamız gerekiyor.(Bir referansını oluşturduk.)
            customerManager.Add();
            customerManager.Update();//Bir class oluştururken PascalCase ama onun örneğini oluştururken
                                     //
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer //üstteki yöntemle aynı, sadece farklı yazılışı.
            {
                Id = 2, City = "İstanbul", FirstName = "Derin", LastName = "Demiroğ"
            };

            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }

    }


}


