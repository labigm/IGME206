namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your first pokemon game\n");
            
            Monster m1 = new Monster("M1", 1);
            Monster m2 = new Monster("M2", 2);
            m1.Fight(m2);
            
            Bulbasaur m3 = new Bulbasaur("B1");
            Bulbasaur m4 = new Bulbasaur("B2");
            m3.Fight(m4);
        }
    }
}