using Bookstore;

namespace Program
{
    public class Exercises
    {
        public static void Main()
        {
            //Products
            var book_1 = new Product("Memórias Póstumas de Brás Cubas", 24.90f);
            var book_2 = new Product("O Som e o Sentido", 34.90f);
            var book_3 = new Product("Os Sete Maridos de Evelyn Hugo", 39.90f);
            var book_4 = new Product("Poema Sujo", 29.90f);
            var book_5 = new Product("Genki", 199.90f);
            var book_6 = new Product("Felicidade Clandestina", 19.90f);
            var book_7 = new Product("Crime e Castigo", 69.90f);
            var book_8 = new Product("A Metamorfose", 39.90f);

            //Clients
            var machado = new Client("deassis@gmail.com", "Machado de Assis");

            //Cart
            var myCart = new Cart(machado);

            myCart.AddProduct(book_1);
            myCart.AddProduct(book_3);
            myCart.AddProduct(book_4);
            myCart.AddProduct(book_6);
            myCart.AddProduct(book_7);

            //Show info
            Console.WriteLine($"Order #5987\n------------------------------\n");
            machado.ShowInfo();
            Console.WriteLine("\n------------------------------\n");
            foreach (var item in myCart.Products)
            {
                Console.WriteLine($"Name: {item.Name} - Price: R$ {item.Price}");
            }
        }
    }
}
