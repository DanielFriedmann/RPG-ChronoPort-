using System.Runtime.CompilerServices;

namespace RPG
{
    public class DungeonGenerator
    {
        private static Random random = new Random();
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
                MonsterRoomFactory.A10()
            };

            roomList = roomList.OrderBy(x => random.Next()).ToList();

            return roomList.Take(diff).ToList();
        }

        public static List<Campfire> RandomCampfire()
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
    }
}