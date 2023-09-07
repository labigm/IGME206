namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your first pokemon game");
            Console.WriteLine("This is your first pokemon");
            Monster m1 = new Monster("M1", 1);
            m1.Print();
            Monster m2 = new Monster("M2", 2);
            m2.Print();

            Console.WriteLine(m1.Nickname + " gets in a fight with monster " + m2.Nickname);
            m1.Fight(m2);
            m1.Print();

        }
    }
}