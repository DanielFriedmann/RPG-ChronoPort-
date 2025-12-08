namespace RPG
{
    public class DungeonGenerator2
    {
        private static Random random = new Random();

        public enum DungeonEvent
        {
            Monster,
            Campfire,
            Shop,
            Boss
        }

        public static List<(DungeonEvent, DungeonEvent)> CreateDungeonPlanW2()
        {
            List<(DungeonEvent, DungeonEvent)> plan = new List<(DungeonEvent, DungeonEvent)>();

            plan.Add((DungeonEvent.Monster, DungeonEvent.Campfire)); // Runde 1 - Heilungsmöglichkeit
            plan.Add((DungeonEvent.Monster, DungeonEvent.Monster)); // Runde 2
            plan.Add((DungeonEvent.Monster, DungeonEvent.Campfire)); // Runde 3

            bool variantA = random.Next(0, 2) == 0;

            if (variantA)
            {
                plan.Add((DungeonEvent.Monster, DungeonEvent.Shop)); //Runde 4
                plan.Add((DungeonEvent.Monster, DungeonEvent.Monster)); //Runde 5
            }
            else
            {
                plan.Add((DungeonEvent.Monster, DungeonEvent.Monster)); //Runde 4
                plan.Add((DungeonEvent.Shop, DungeonEvent.Monster)); //Runde 5
            }
            return plan;
        }

        public static void GenerateDungeonW2(BasePlayer held)
        {
            List<MonsterRoom> monsterRooms = RandomWorld2();
            List<Campfire> campfires = RandomCampfireW2();
            List<Shop> shops = RandomShopW2();
            
            int world = 2;
            int campIndex = 0;
            int shopIndex = 0;

            List<(DungeonEvent, DungeonEvent)> plan = CreateDungeonPlanW2();
            Console.WriteLine("Willkommen in Welt 2!");

            for (int round = 0; round < plan.Count; round++)
            {
                var (left, right) = plan[round];

                Console.WriteLine($"Runde {round + 1}");

                int leftIndex = round * 2;
                int rightIndex = round * 2 + 1;

                Console.Write("Linkes Portal ->");
                PrintPortal(left, leftIndex);

                Console.Write("Rechtes Portal ->");
                PrintPortal(right, rightIndex);

                Console.WriteLine();

                int choice = InputHelper.GetInt("Wähle oberes Portal (1) oder unteres Portal (2)", 2);
                if (choice == 1)
                {
                    if (left == DungeonEvent.Monster)
                    {
                        DungeonHelper.EncounterMonster(monsterRooms[leftIndex]);
                        BattleSystem.Kampf(held, monsterRooms[leftIndex].Monster);
                    }
                    else if (left == DungeonEvent.Shop)
                        DungeonHelper.ShopEvent(shops[shopIndex]);
                    else if (left == DungeonEvent.Campfire)
                        DungeonHelper.CampfireEvent(campfires[campIndex], held, 14, campIndex);
                }
                else
                {
                    if (right == DungeonEvent.Monster)
                    {
                        DungeonHelper.EncounterMonster(monsterRooms[rightIndex]);
                        BattleSystem.Kampf(held, monsterRooms[rightIndex].Monster);
                    }
                    else if (right == DungeonEvent.Shop)
                        DungeonHelper.ShopEvent(shops[shopIndex]);
                    else if (right == DungeonEvent.Campfire)
                        DungeonHelper.CampfireEvent(campfires[campIndex], held, 14, campIndex);
                }

            }

            
            BossMonster boss = RandomBossWorld2()[0];
            BossBattle.BossKampf(held, boss, world);
            DungeonHelper.WorldEndScreen(held, world);   
            
          
              void PrintPortal(DungeonEvent evt, int index)
            {
                switch (evt)
                {
                    case DungeonEvent.Monster:
                        string text = monsterRooms[index].RoomName;

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("    _____     ");
                        Console.WriteLine("   /     \\");
                        Console.WriteLine("  /       \\");
                        Console.WriteLine(" /         \\");
                        Console.WriteLine($"|  {text}    |");
                        Console.WriteLine("\\           /");
                        Console.WriteLine(" \\         /");
                        Console.WriteLine("  \\       /");
                        Console.WriteLine("   \\_____/");
                        Console.WriteLine();
                        Console.ResetColor();
                        break;

                    case DungeonEvent.Campfire:
                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("    _____     ");
                        Console.WriteLine("   /     \\");
                        Console.WriteLine("  /       \\");
                        Console.WriteLine(" /         \\");
                        Console.WriteLine("|  Campfire   |");
                        Console.WriteLine("\\           /");
                        Console.WriteLine(" \\         /");
                        Console.WriteLine("  \\       /");
                        Console.WriteLine("   \\_____/");
                        Console.WriteLine(campfires[campIndex++].RoomName);
                        Console.WriteLine();
                        Console.ResetColor();
                        break;

                    case DungeonEvent.Shop:

                       Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("    _____     ");
                        Console.WriteLine("   /     \\");
                        Console.WriteLine("  /       \\");
                        Console.WriteLine(" /         \\");
                        Console.WriteLine("|    Shop    |");
                        Console.WriteLine("\\           /");
                        Console.WriteLine(" \\         /");
                        Console.WriteLine("  \\       /");
                        Console.WriteLine("   \\_____/");
                        Console.WriteLine(campfires[campIndex++].RoomName);
                        Console.WriteLine();
                        Console.ResetColor();
                        Console.WriteLine(shops[shopIndex++].RoomName);
                        break;
                }
            }
        }

        public static List<MonsterRoom> RandomWorld2()
        {
            List<MonsterRoom> roomList = new List<MonsterRoom>()
            {
                MonsterRoomFactory.B1(),
                MonsterRoomFactory.B2(),
                MonsterRoomFactory.B3(),
                MonsterRoomFactory.B4(),
                MonsterRoomFactory.B5(),
                MonsterRoomFactory.B6(),
                MonsterRoomFactory.B7(),
                MonsterRoomFactory.B8(),
                MonsterRoomFactory.B9(),
                MonsterRoomFactory.B10(),
                MonsterRoomFactory.B11()
            };

            roomList = roomList.OrderBy(x => random.Next()).ToList();

            return roomList;
        }

        public static List<BossMonster> RandomBossWorld2()
        {
            List<BossMonster> roomList = new List<BossMonster>()
            {
                BossFactory.MotherboardMatriarchin(),
                BossFactory.OracleUnitZ3(),
                BossFactory.OmegaForge(),
            };

            roomList = roomList.OrderBy(x => random.Next()).ToList();

            return roomList;
        }

        public static List<Campfire> RandomCampfireW2()
        {
            List<Campfire> campList = new List<Campfire>()
            {
                Camping.CreateCampfireW2A(),
                Camping.CreateCampfireW2B(),
                Camping.CreateCampfireW2C()
            };

            campList = campList.OrderBy(x => random.Next()).ToList();

            return campList;
        }

        public static List<Shop> RandomShopW2()
        {
            List<Shop> shopList = new List<Shop>()
            {
               Shopping.CreateShopW2A(),
               Shopping.CreateShopW2B(),
            };

            shopList = shopList.OrderBy(x => random.Next()).ToList();

            return shopList;
        }

    }
}
