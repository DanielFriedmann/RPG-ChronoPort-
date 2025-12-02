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
                MonsterRoomFactory.A3()
            };

            roomList = roomList.OrderBy(x => random.Next()).ToList();

            return roomList.Take(diff).ToList();
        }
    }
}