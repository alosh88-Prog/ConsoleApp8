internal class Program
{
    static void Main(string[] args)
    {
        int pages = 464;
        bool isAvailable = true;

        if (pages > 300 && isAvailable == true)
        {
            Console.WriteLine("You can borrow this book");
        }
    }
}