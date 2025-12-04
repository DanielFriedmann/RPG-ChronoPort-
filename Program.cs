namespace RPG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.TestEncounter();
        }

        public void TestEncounter()
        {
            BasePlayer held = HeroFactory.CreatePlayer();
            DungeonGenerator.GenerateDungeonW1(held);
            DungeonGenerator2.GenerateDungeonW2(held);
            DungeonGenerator3.GenerateDungeonW3(held);
            
        }
    }
}