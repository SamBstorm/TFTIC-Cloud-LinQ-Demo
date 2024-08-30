namespace Demo_var_AnonymousType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Product> products = new List<Product>() { 
                new Product(1, "Souris gaming","mouse-gaming.png","Une souris pour pc, qui brille dans le noir",new List<string>{ "Multimédia","RGB","Souris","Gaming"},99.99M),
                new Product(2, "Clavier gaming","keyboard-gaming.png","Un clavier pour pc, qui brille dans le noir",new List<string>{ "Multimédia","RGB","Clavier","Gaming"},129.99M),
                new Product(3, "Ecran incurvé","curved-monitor.png","Un écran pour pc, qui a une courbe de 45°",new List<string>{ "Multimédia","OLED","Ecran","Incurvé"},149.99M),
                new Product(4, "Ventilateur USB","usb-fan.png","Un ventilateur de 12cm de diamètre fonctionnant sur USB",new List<string>{ "Confort","USB","Ventilateur","Portable"},9.99M)
            };

            for (int i = 0; i < products.Count; i++)
            {
                var prod = new { products[i].Id, Nom = products[i].Name, Cat = products[i].Category[0], Prix = products[i].Price };
                Console.WriteLine($"{prod.Id} : {prod.Nom} - {prod.Cat} : {prod.Prix} €");
                Console.WriteLine(prod.GetType());
            }
        }
    }
}
