namespace Demo_MethodeExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "hello, World";
            Console.WriteLine(MethodeExtension.AddUpperAndPoint(message));
            Console.WriteLine(message.AddUpperAndPoint());
            Console.WriteLine(4.Multiple2());
        }
    }
}
