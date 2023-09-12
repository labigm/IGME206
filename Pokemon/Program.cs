namespace Pokemon
{
    //Something
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your first Pokemon game\n");
            
            Monster m1 = new Monster("M1", 1);
            Monster m2 = new Monster("M2", 2);
            m1.Fight(m2);
            
            Bulbasaur m3 = new Bulbasaur("B1", 1);
            Bulbasaur m4 = new Bulbasaur("B2", 2);
            m3.Fight(m4);

            Monster[] monsterArray = new Monster[10];
            monsterArray[0] = new Monster("M3");
            //wont compile as its an array of a child class
            //Bulbasaur[] bulbasaurArray = new Bulbasaur[3];
            //bulbasaurArray[0] = new Monster("Alberto"); 
            foreach (Monster monster in monsterArray)
            {
                if (monster != null)
                    monster.Print();
            }
            monsterArray[1] = new Bulbasaur("B4");
            foreach (Monster monster in monsterArray)
            {
                if (monster != null)
                    monster.Print();
            }

            List<Monster> monsterList = new List<Monster>();
            monsterList.Add(new Bulbasaur("B5"));
            monsterList.Add(new Charmander("C1"));
            monsterList.Add(new Monster("M7"));
            foreach (Monster monster in monsterList)
            {
                monster.Print();
            }
        }
    }
}