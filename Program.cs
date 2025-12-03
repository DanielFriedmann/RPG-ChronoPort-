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
            //Encounter(held);


        }

        /* public void Encounter(BasePlayer held)
         {
             List<MonsterRoom> world1 = DungeonGenerator.RandomWorld1(3);

             foreach (MonsterRoom room in world1)
             {
                 Console.WriteLine("\nDu schreitest durch das Portal.");
                 Console.WriteLine(room.Description);
                 Console.WriteLine(room.EncounterDescription1);
                 Console.WriteLine(room.EncounterDescription2);
                 Thread.Sleep(2000);
                 Kampf(room.Monster, held);
                 Thread.Sleep(5000);
             }
         } */

      
    }
}