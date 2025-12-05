namespace RPG
{
    public class DungeonHelper
    {
        public static void ShopEvent(Shop shop)
        {
            foreach (string item in shop.ShopInv)
            {
                int price = Shopping.prices[item];
                Console.Write($"{item}: {price} $");
            }
        }

        public static void CampfireEvent(Campfire campfire, BasePlayer player, int value, int campindex)
        {
            Random random = new Random();

            Console.WriteLine(campfire.RoomName);
            Console.WriteLine(campfire.Description);
            Console.WriteLine($"Du setzt dich eine Weile ans Lagerfeuer. HP {player.Health}");
            if (player.Health + value <= player.MaxHP)
            {
                player.Health += value;
            }
            else
            {
                player.Health = player.MaxHP;
            }
            Console.WriteLine($"Du hast dich um {value} HP geheilt. Neue HP:{player.Health} ");

            List<string> npcList = campfire.Encounter;
            npcList = npcList.OrderBy(x => random.Next()).ToList();
            NPC npc = NPCLibrary.NPCs[npcList[campindex]]();

            Console.WriteLine($"Plötzlich taucht {npc.Name} auf!");
            Console.WriteLine(npc.WelcomeText);
            npc.Encounter(player);
            Console.WriteLine(npc.ByeText);

            Console.WriteLine("Du packst deine Sachen und machst dich wieder auf den Weg.");

        }

        public static void AddBuff(BasePlayer player, string attribute, int value, string eventtext)
        {
            if (attribute == "Health")
            {
                player.MaxHP += value;
                player.Health += value;
                Console.WriteLine(eventtext);
                Console.WriteLine($"{player.Name} Max HP wurden um {value} erhöht! {player.Health}/{player.MaxHP} HP.");
            }
            else if (attribute == "Attack")
            {
                player.Attack += value;
                Console.WriteLine(eventtext);
                Console.WriteLine($"Der Angriff von {player.Name} ist gestiegen! {player.Attack - value} => {player.Attack}");
            }
            else if (attribute == "Defense")
            {
                player.Defense += value;
                Console.WriteLine(eventtext);
                Console.WriteLine($"Die Verteidigung von {player.Name} ist gestiegen! {player.Defense - value} => {player.Defense}");
            }
            else if (attribute == "Crit")
            {
                player.Crit += value;
                Console.WriteLine(eventtext);
                Console.WriteLine($"Die Krit-Chance von {player.Name} ist gestiegen! {player.Crit - value}% => {player.Crit}%");
            }
            else if (attribute == "SpecialPoints")
            {
                player.MaxSP += value;
                player.SpecialPoints += value;
                Console.WriteLine(eventtext);
                Console.WriteLine($"{player.Name} Max Special Points wurden um {value} erhöht! {player.SpecialPoints}/{player.MaxSP} SP.");
            }
            else if (attribute == "Gold")
            {
                player.Money += value;
                Console.WriteLine(eventtext);
                Console.WriteLine($"{player.Name} hat {value} Gold bekommen! Aktuelles Gold: {player.Money}");
            }
            else if (attribute == "XP")
            {
                player.Xp += value;
                Console.WriteLine(eventtext);
                Console.WriteLine($"{player.Name} hat {value} XP bekommen! Aktuelle XP: {player.Xp}");
            }
        }


        public static void AddDebuff(BasePlayer player, string attribute, int value, string eventtext)
        {
            if (attribute == "Attack")
            {
                player.Attack -= value;
                Console.WriteLine(eventtext);
                Console.WriteLine($"Der Angriff von {player.Name} ist gesunken! {player.Attack + value} => {player.Attack}");
            }
            else if (attribute == "Defense")
            {
                player.Defense -= value;
                Console.WriteLine(eventtext);
                Console.WriteLine($"Die Verteidigung von {player.Name} ist gesunken! {player.Defense + value} => {player.Defense}");
            }
            else if (attribute == "Crit")
            {
                player.Crit -= value;
                Console.WriteLine(eventtext);
                Console.WriteLine($"Die Krit-Chance von {player.Name} ist gesunken! {player.Crit + value}% => {player.Crit}%");
            }
            else if (attribute == "Gold")
            {
                if (player.Money - value < 0)
                {
                    value = player.Money;
                }
                
                player.Money -= value;
                Console.WriteLine(eventtext);
                Console.WriteLine($"{player.Name} hat {value} Gold verloren! Aktuelles Gold: {player.Money}");
            }
        }

        //dungeon print screen - save etc
        //dungeon final screen

    }
}