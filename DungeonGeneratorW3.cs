namespace RPG
{
    public class DungeonGenerator3
    {
        private static Random random = new Random();

        public enum DungeonEvent
        {
            Monster,
            Campfire,
            Shop,
            Boss
        }

        public static List<(DungeonEvent, DungeonEvent)> CreateDungeonPlanW3()
        {
            List<(DungeonEvent, DungeonEvent)> plan = new List<(DungeonEvent, DungeonEvent)>();

            plan.Add((DungeonEvent.Monster, DungeonEvent.Campfire));    // Runde 1 - zusätzliche Heilungsmöglichkeit
            plan.Add((DungeonEvent.Monster, DungeonEvent.Monster));     // Runde 2
            plan.Add((DungeonEvent.Monster, DungeonEvent.Monster));    // Runde 3
            plan.Add((DungeonEvent.Monster, DungeonEvent.Shop));        //Runde 4
            plan.Add((DungeonEvent.Monster, DungeonEvent.Campfire));    //Runde 5

            return plan;
        }

        public static void GenerateDungeonW3(BasePlayer held)
        {
            List<MonsterRoom> monsterRooms = RandomWorld3();
            List<Campfire> campfires = RandomCampfireW3();
            List<Shop> shops = RandomShopW3();

            int campIndex = 0;
            int shopIndex = 0;

            List<(DungeonEvent, DungeonEvent)> plan = CreateDungeonPlanW3();
            Console.WriteLine("Willkommen in Welt 3!");

            for (int round = 0; round < plan.Count; round++)
            {
                var (left, right) = plan[round];

                Console.WriteLine($"Runde {round + 1}");

                int leftIndex = round * 2;
                int rightIndex = round * 2 + 1;

                Console.Write("Linkes Portal ->");
                PrintEvent(left, leftIndex);

                Console.Write("Rechtes Portal ->");
                PrintEvent(right, rightIndex);

                Console.WriteLine();

                int choice = InputHelper.GetInt("Wählen sie links (1) oder rechts (2)", 2);
                if (choice == 1)
                {
                    if (left == DungeonEvent.Monster)
                        BattleSystem.Kampf(held, monsterRooms[leftIndex].Monster);
                    else if (left == DungeonEvent.Shop)
                        DungeonHelper.ShopEvent(shops[shopIndex]);
                    else if (left == DungeonEvent.Campfire)
                        DungeonHelper.CampfireEvent(campfires[campIndex], held, 18, campIndex);
                }
                else
                {
                    if (right == DungeonEvent.Monster)
                        BattleSystem.Kampf(held, monsterRooms[rightIndex].Monster);
                    else if (right == DungeonEvent.Shop)
                        DungeonHelper.ShopEvent(shops[shopIndex]);
                    else if (right == DungeonEvent.Campfire)
                        DungeonHelper.CampfireEvent(campfires[campIndex], held, 18, campIndex);
                }

            }

            Console.WriteLine("Du bist nun beim Boss....");
            BossMonster boss = RandomBossWorld3()[0];
            BossBattle.BossKampf(held, boss);
            Console.WriteLine("Du hast Welt 3 gecleart!");
            Console.WriteLine("GAME END");

            void PrintEvent(DungeonEvent evt, int index)
            {
                switch (evt)
                {
                    case DungeonEvent.Monster:
                        Console.WriteLine(monsterRooms[index].RoomName);
                        break;

                    case DungeonEvent.Campfire:
                        Console.WriteLine(campfires[campIndex++].RoomName);
                        break;

                    case DungeonEvent.Shop:
                        Console.WriteLine(shops[shopIndex++].RoomName);
                        break;
                }
            }
        }






        public static List<MonsterRoom> RandomWorld3()
        {
            List<MonsterRoom> roomList = new List<MonsterRoom>()
            {
                MonsterRoomFactory.C1(),
                MonsterRoomFactory.C2(),
                MonsterRoomFactory.C3(),
                MonsterRoomFactory.C4(),
                MonsterRoomFactory.C5(),
                MonsterRoomFactory.C6(),
                MonsterRoomFactory.C7(),
                MonsterRoomFactory.C8(),
                MonsterRoomFactory.C9(),
                MonsterRoomFactory.C10(),
                MonsterRoomFactory.C11()
            };

            roomList = roomList.OrderBy(x => random.Next()).ToList();

            return roomList;
        }

        public static List<BossMonster> RandomBossWorld3()
        {
            List<BossMonster> roomList = new List<BossMonster>()
            {
                BossFactory.Aethernox(),
                BossFactory.Solaryth(),
                BossFactory.Nihilgron(),
            };

            roomList = roomList.OrderBy(x => random.Next()).ToList();

            return roomList;
        }

        public static List<Campfire> RandomCampfireW3()
        {
            List<Campfire> campList = new List<Campfire>()
            {
                Camping.CreateCampfireW3A(),
                Camping.CreateCampfireW3B(),
                Camping.CreateCampfireW3C()
            };

            campList = campList.OrderBy(x => random.Next()).ToList();

            return campList;
        }

        public static List<Shop> RandomShopW3()
        {
            List<Shop> shopList = new List<Shop>()
            {
               Shopping.CreateShopW3A(),
               Shopping.CreateShopW3B(),
            };

            shopList = shopList.OrderBy(x => random.Next()).ToList();

            return shopList;
        }

    }
}
