namespace Demo_Lambda01
{
    delegate int del(int x);
    internal class Program
    {
        static void Main(string[] args)
        {
            del MyLambda = x => x * x;
            del MyDelegate = delegate (int x) { return x * x; };

            Console.WriteLine($"Ma lambda sur 5 retourne {MyLambda(5)}");
            Console.WriteLine($"Mon délégué sur 5 retourne {MyDelegate(5)}");
        }
    }
}
