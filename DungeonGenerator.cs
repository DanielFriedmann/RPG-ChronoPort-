using System.Runtime.CompilerServices;

namespace RPG
{

    public class DungeonGenerator
    {
        private static Random random = new Random();

        public enum DungeonEvent
        {
            Monster,
            Campfire,
            Shop,
            Boss
        }

        public static List<(DungeonEvent, DungeonEvent)> CreateDungeonPlanW1()
        {
            List<(DungeonEvent, DungeonEvent)> plan = new List<(DungeonEvent, DungeonEvent)>();

            plan.Add((DungeonEvent.Monster, DungeonEvent.Monster)); // Runde 1
            plan.Add((DungeonEvent.Monster, DungeonEvent.Monster)); // Runde 2
            plan.Add((DungeonEvent.Monster, DungeonEvent.Campfire)); // Runde 3

            bool variantA = random.Next(0, 2) == 0;

            if (variantA)
            {
                plan.Add((DungeonEvent.Monster, DungeonEvent.Shop));
                plan.Add((DungeonEvent.Monster, DungeonEvent.Monster));
            }
            else
            {
                plan.Add((DungeonEvent.Monster, DungeonEvent.Monster));
                plan.Add((DungeonEvent.Shop, DungeonEvent.Monster));
            }
            return plan;
        }

        public static void GenerateDungeonW1(BasePlayer held)
        {
            List<MonsterRoom> monsterRooms = RandomWorld1(11);
            List<Campfire> campfires = RandomCampfireW1();
            List<Shop> shops = RandomShopW1();

            int monsterIndex = 0;
            int campIndex = 0;
            int shopIndex = 0;

            List<(DungeonEvent, DungeonEvent)> plan = CreateDungeonPlanW1();

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
                if (player.Health + 10 <= player.MaxHP)
                {
                    player.Health += 10;
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

        public static List<MonsterRoom> RandomWorld1(int diff)
        {
            List<MonsterRoom> roomList = new List<MonsterRoom>()
            {
                MonsterRoomFactory.A1(),
                MonsterRoomFactory.A2(),
                MonsterRoomFactory.A3(),
                MonsterRoomFactory.A4(),
                MonsterRoomFactory.A5(),
                MonsterRoomFactory.A6(),
                MonsterRoomFactory.A7(),
                MonsterRoomFactory.A8(),
                MonsterRoomFactory.A9(),
                MonsterRoomFactory.A10(),
                MonsterRoomFactory.A11()
            };

            roomList = roomList.OrderBy(x => random.Next()).ToList();

            return roomList.Take(diff).ToList();
        }

        public static List<Campfire> RandomCampfireW1()
        {
            List<Campfire> campList = new List<Campfire>()
            {
                Camping.CreateCampfireW1A(),
                Camping.CreateCampfireW1B(),
                Camping.CreateCampfireW1C()
            };

            campList = campList.OrderBy(x => random.Next()).ToList();

            return campList;
        }

        public static List<Shop> RandomShopW1()
        {
            List<Shop> shopList = new List<Shop>()
            {
               Shopping.CreateShopW1A(),
               Shopping.CreateShopW1B(),
            };

            shopList = shopList.OrderBy(x => random.Next()).ToList();

            return shopList;
        }


    }
}