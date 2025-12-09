namespace RPG
{

    // Klasse für Räume -> Campfire, Shop und Monster
    public class Room
    {
        public string RoomName { get; set; }

        public string Description { get; set; }

        public Room(string roomname, string description)
        {
            RoomName = roomname;
            Description = description;
            
        }
    }

    public class MonsterRoom : Room
    {
        public Monster Monster { get; set; }

        public string EncounterDescription1 { get; set; }

        public string EncounterDescription2 { get; set; }

        public MonsterRoom(Monster monster, string roomname, string description, string encounter1, string encounter2) : base(roomname, description)
        {
            Monster = monster;
            EncounterDescription1 = encounter1;
            EncounterDescription2 = encounter2;
        }

    }

    public class Shop : Room
    {
        public List<string> ShopInv { get; set; }

        
        public Shop(string roomname, string description, List<string> inv) : base(roomname, description)
        {
            ShopInv = inv;
        }
    }

    

    public class Campfire : Room
    {
        public List<string> Encounter {get; set;}

        public Campfire(string roomname,string description, List<string> encounter) : base(roomname,description)
        {
            Encounter = encounter ?? new List<string>();
        }
    }       

}