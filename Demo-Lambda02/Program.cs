namespace Demo_Lambda02
{
    /*Délégués pré-enregistrés*/
    /*Action : Tout délégué qui ne retourne pas de valeur (void)*/
    /*Func<TResult> : Tout délégué qui retourne une valeur (TResult)*/

    delegate bool FiltreAction<T>(T valeurAVerifier);
    /*Peut être remplacer par un Func<T,bool> */
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tab = ["Riri","Fifi","Loulou","Zaza"];
            //string[] result = Filtrer(tab, delegate (string x) { return x.Length < 5; });
            string[] result = MethodesExtensions.Filtrer(tab, (x) => x.Length < 5);

            foreach (string value in result)
            {
                Console.WriteLine(value);
            }

            Product[] products = [
                new Product(){Name = "Souris Gaming", Price = 99.99M},
                new Product(){Name = "Clavier Gaming", Price = 129.99M},
                new Product(){Name = "Ecran incurvé", Price = 149.99M},
                new Product(){Name = "Ventilateur USB", Price = 9.99M}
                ];
            //Product[] filteredProducts = Filtrer<Product>(products, (p) => p.Price > 25M && p.Price < 130M);
            Product[] filteredProducts = products.Filtrer((p) => p.Price > 25M && p.Price < 150M).Filtrer((p) => p.Name.Contains("Gaming"));

            foreach (Product prod in filteredProducts)
            {
                Console.WriteLine(prod.Name);
            }
        }

        //static int[] FiltrerLesValeursPaires(int[] tableauComplet)
        //{
        //    List<int> result = new List<int>();
        //    foreach (int value in tableauComplet)
        //    {
        //        if (value % 2 == 0) result.Add(value);
        //    }
        //    return result.ToArray();
        //}

        //static int[] FiltrerLesValeursDivisiblePar3(int[] tableauComplet)
        //{
        //    List<int> result = new List<int>();
        //    foreach (int value in tableauComplet)
        //    {
        //        if (value % 3 == 0) result.Add(value);
        //    }
        //    return result.ToArray();
        //}

        //static int[] Filtrer(int[] tableauComplet, Func<int, bool> predicate)
        //{
        //    List<int> result = new List<int>();
        //    foreach (int value in tableauComplet)
        //    {
        //        if (predicate(value)) result.Add(value);
        //    }
        //    return result.ToArray();
        //}
        
    }

    public static class MethodesExtensions
    {
        public static T[] Filtrer<T>(this T[] tableauComplet, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();
            foreach (T value in tableauComplet)
            {
                if (predicate(value)) result.Add(value);
            }
            return result.ToArray();
        }
    }
}
