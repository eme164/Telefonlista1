namespace Telefonlista1
{
    internal class Program
    {
        static void Lycka()
        {
            Console.WriteLine("Skriv ett nummer:");
            int nr = int.Parse(Console.ReadLine());
            if (nr % 2 == 0)
            {
                Console.WriteLine("Du är lycklig idag!");
            }
            else
            {
                Console.WriteLine("Du måste jobba på din lycka idag!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till frågesport. Nu ska vi testa ditt kunnande!");
            Lycka();
        }
    }
}