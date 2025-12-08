using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

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
            List<MonsterRoom> monsterRooms = RandomWorld1();
            List<Campfire> campfires = RandomCampfireW1();
            List<Shop> shops = RandomShopW1();

            int world = 1;
            int campIndex = 0;
            int shopIndex = 0;

            List<(DungeonEvent, DungeonEvent)> plan = CreateDungeonPlanW1();

            Console.WriteLine("Willkommen in Welt 1!");

            for (int round = 0; round < plan.Count; round++)
            {
                var (left, right) = plan[round];

                Console.WriteLine($"Runde {round + 1}");

                int leftIndex = round * 2;
                int rightIndex = round * 2 + 1;
                
                PrintPortal(left, leftIndex);
               
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
                        DungeonHelper.CampfireEvent(campfires[campIndex], held, 10, campIndex);
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
                        DungeonHelper.CampfireEvent(campfires[campIndex], held, 10, campIndex);
                }

            }

            BossMonster boss = RandomBossWorld1()[0];
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

        public static List<MonsterRoom> RandomWorld1()
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

            return roomList;
        }

        public static List<BossMonster> RandomBossWorld1()
        {
            List<BossMonster> roomList = new List<BossMonster>()
            {
                BossFactory.ChronoRex(),
                BossFactory.RiftMammut(),
                BossFactory.PrimalHydra(),
            };

            roomList = roomList.OrderBy(x => random.Next()).ToList();

            return roomList;
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