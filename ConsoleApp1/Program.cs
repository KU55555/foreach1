namespace Foreach1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nimed = { "Antont Tammsaare", "Lydia Koidula", "August Gailit", "Betti Alver" };

            foreach (string i in nimed)
            {
                Console.WriteLine(i);
            }
        }
    }
}
