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

            int monsterIndex = 0;
            int campIndex = 0;
            int shopIndex = 0;

            List<(DungeonEvent, DungeonEvent)> plan = CreateDungeonPlanW2();
            Console.WriteLine("Willkommen in Welt 2!");

            for (int round = 0; round < plan.Count; round++)
            {
                var (left, right) = plan[round];

                Console.WriteLine($"Runde {round + 1}");

                Console.Write("Linkes Portal ->");
                PrintEvent(left);

                Console.Write("Rechtes Portal ->");
                PrintEvent(right);

                Console.WriteLine();

                int choice = InputHelper.GetInt("Wählen sie links (1) oder rechts (2)", 2);
                if (choice == 1)
                {
                    if (left == DungeonEvent.Monster)
                        BattleSystem.Kampf(held, monsterRooms[0 + round * 2].Monster);
                    else if (left == DungeonEvent.Shop)
                        ShopEvent(shops[0]);
                    else if (left == DungeonEvent.Campfire)
                        CampfireEvent(campfires[0], held);
                }
                else
                {
                    if (right == DungeonEvent.Monster)
                        BattleSystem.Kampf(held, monsterRooms[1 + round * 2].Monster);
                    else if (right == DungeonEvent.Shop)
                        ShopEvent(shops[0]);
                    else if (right == DungeonEvent.Campfire)
                        CampfireEvent(campfires[0], held);
                }

            }

            Console.WriteLine("Du bist nun beim Boss....");
            BossMonster boss = RandomBossWorld2()[0];
            BossBattle.BossKampf(held, boss);
            Console.WriteLine("Du hast Welt 2 gecleart!");
            Console.WriteLine("Welt 3 -TBD");

            void ShopEvent(Shop shop)
            {
                foreach (string item in shop.ShopInv)
                {
                    int price = Shopping.prices[item];
                    Console.Write($"{item}: {price} $");
                }
            }

            void CampfireEvent(Campfire campfire, BasePlayer player)
            {
                Console.WriteLine(campfire.RoomName);
                Console.WriteLine(campfire.Description);
                Console.WriteLine($"Du setzt dich eine Weile ans Lagerfeuer. HP {player.Health}");
                if (player.Health + 15 <= player.MaxHP)
                {
                    player.Health += 15;
                }
                else
                {
                    player.Health = player.MaxHP;
                }
                Console.WriteLine($"Du hast dich um 10 HP geheilt. Neue HP:{player.Health} ");
            }

            void PrintEvent(DungeonEvent evt)
            {
                switch (evt)
                {
                    case DungeonEvent.Monster:
                        Console.WriteLine(monsterRooms[monsterIndex++].RoomName);
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
