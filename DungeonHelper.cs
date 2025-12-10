using System.Collections.Concurrent;
using System.Text.Json;
using System.IO;


namespace RPG
{
    public class DungeonHelper
    {
        //Klasse für Methoden von Dungeon 1 bis 3
        public static List<BasePlayer> hoflist { get; set; } = new List<BasePlayer>();

        public static void EncounterMonster(MonsterRoom room)
        {
            Console.Clear();
            Console.WriteLine($"Du findest dich im Jahr {room.RoomName} wieder!");
            Console.WriteLine(room.Description);
            Console.WriteLine(room.EncounterDescription1);
            Console.WriteLine(room.EncounterDescription2);
            Console.WriteLine($"Ein wildes {room.Monster.Name} erscheint!");
        }

        public static void MonsterDefeat(BasePlayer player, Monster monster)
        {
            Console.WriteLine($"Du hast  {monster.Name} besiegt!");
            Console.WriteLine($"Du erhältst {monster.Drop.DropXP} Erfahrung und {monster.Drop.Gold} Gold.");
            player.Xp += monster.Drop.DropXP;
            player.Money += monster.Drop.Gold;
            Console.WriteLine($"Du hast jetzt {player.Xp} XP und {player.Money} Gold");

            if (BattleSystem.LootChance(monster.Drop))
            {
                Console.WriteLine($"{monster.Name} hat Loot gedroppt!");
                Console.WriteLine($"Du erhältst {monster.Drop.DropItem}!");
            }
            Pause();
            Level.LvlUpCheck(player);
        }

        public static void BossDefeat(BasePlayer player, BossMonster monster, int world)
        {
            Console.WriteLine(monster.Defeattext);
            Console.WriteLine($"Du hast {monster.Name} besiegt!");
            Console.WriteLine($"Du erhältst {monster.Drop2.DropXP} Erfahrung und {monster.Drop2.Gold} Gold.");
            player.Xp += monster.Drop2.DropXP;
            player.Money += monster.Drop2.Gold;
            Console.WriteLine($"Du hast jetzt {player.Xp} XP und {player.Money} Gold");
            Console.WriteLine($"{monster.Name} hat Loot gedroppt!");
            Console.WriteLine($"Du erhältst {monster.Drop1.DropItem} und hast damit {world} von 3 Artefakten um die Welt wieder ins Lot zu bringen!");
            Console.WriteLine($"Du erhältst {monster.Drop2.DropItem}!");
            player.Progress = world + 1;   //Alternative zu World Artefakten um den Progress zu überprüfen.
            Pause();
            Level.LvlUpCheck(player);
        }

        public static void ShopEvent(Shop shop)
        {
            Console.Clear();
            Menu.ColorSwitch(shop.RoomName, ConsoleColor.DarkYellow);
            Console.WriteLine();

            foreach (string item in shop.ShopInv)
            {
                int price = Shopping.prices[item];
                Console.Write($"{item}: {price} $");
            }
            Pause();
        }

        public static void CampfireEvent(Campfire campfire, BasePlayer player, int value, int campindex)
        {
            Random random = new Random();
            Console.Clear();
            Menu.ColorSwitch(campfire.RoomName, ConsoleColor.DarkGreen);
            Console.WriteLine();
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
            Pause();

            List<string> npcList = campfire.Encounter;
            npcList = npcList.OrderBy(x => random.Next()).ToList();
            NPC npc = NPCLibrary.NPCs[npcList[campindex]]();

            Console.WriteLine($"Plötzlich taucht {npc.Name} auf!");
            Pause();
            Console.WriteLine(npc.WelcomeText);
            Pause();
            npc.Encounter(player);
            Pause();
            Console.WriteLine(npc.ByeText);

            Console.WriteLine("Du packst deine Sachen und machst dich wieder auf den Weg.");
            Pause();

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

        public static void WorldEndScreen(BasePlayer player, int world)
        {
            Console.WriteLine($"Glückwunsch, {player.Name} du hast Welt {world} geschafft!");
            int choice = InputHelper.GetInt("Was möchtest du tun?\n1.Nächste Welt\n2.Speichern und Beenden", 2);
            if (choice == 1)
            {
                Console.WriteLine($"Weiter gehts mit Welt {world + 1}!");
                return;
            }
            else
            {
                Console.WriteLine("Spiel wird gespeichert...");
                Pause();
                SaveGame(player);
                Console.WriteLine("Spiel wurde erfolgreich gespeichert!");
                Pause();
                Console.WriteLine("Beenden...");
                PauseTime(2000);
                Environment.Exit(0);
            }


        }

        public static void EndLore()
        {
            Console.WriteLine("Du bringst alle 3 Artefakte zum Chrono Portal.");
            Console.WriteLine("Die Artefakte beginnen heftig zu vibrieren...");
            Console.WriteLine("Die zersplitterten Zeitlinien reagieren auf ihre Macht.");
            Pause();

            Console.WriteLine("Portale kollabieren, Welten verschmelzen wieder.");
            Console.WriteLine("Die chaotischen Echos der Zeit werden langsam still.");
            Console.WriteLine("Das Chrono Portal entfesselt seine wahre Kraft.");
            Pause();

            Console.WriteLine("Ein grelles Licht durchflutet alle Dimensionen.");
            Console.WriteLine("Die Welt findet zurück in ihre ursprüngliche Ordnung.");
            Console.WriteLine("Du hast das Gleichgewicht der Zeit wiederhergestellt.");
            Pause();

        }

        public static void Credits()
        {
            Console.Clear();
            Console.WriteLine("Das war CHRONO-PORT");
            Console.WriteLine();
            CreditHelper("Entwickler");
            CreditHelper("Worldbuilding");
            CreditHelper("Characterdesign");
            CreditHelper("Sound und Animation");
            Console.WriteLine("==========================");
            Console.WriteLine("Drücke Enter um ins Hauptmenü zu kommen.");
            Pause();
            Console.Clear();           

        }

        public static void CreditHelper(string credit)
        {
            Console.WriteLine($"{credit}: Daniel Friedmann");
            Thread.Sleep(1000);
            Console.WriteLine();
        }

        public static void FinalScreen(BasePlayer player)
        {
            EndLore();
            Console.Clear();
            Console.WriteLine("Herzlichen Glückwunsch! Du hast das Spiel beendet!");
            Console.WriteLine("====================================================");
            Console.WriteLine($"Spieler: {player.Name}");
            Console.WriteLine($"Rasse: {player.Race}");
            Console.WriteLine($"Ability: {player.HeroAbility}");
            Console.WriteLine($"===================================================");
            Console.WriteLine($"Health: {player.Health}/{player.MaxHP} HP");
            Console.WriteLine($"Attack: {player.Attack}");
            Console.WriteLine($"Defense: {player.Defense}");
            Console.WriteLine($"Crit: {player.Crit}%");
            Console.WriteLine($"Specialpoints: {player.SpecialPoints}/{player.MaxSP} SP");
            Console.WriteLine("====================================================");
            Console.WriteLine($"Der Held {player.Name} wurde der Hall of Fame hinzugefügt!");
            HallofFameLoad();
            HallofFameAdd(player);
            HofSave(hoflist);            //HoF methode
            DeleteSave();               //monster counter
            Console.WriteLine("Drücken Sie Enter um fortzufahren.");
            Console.ReadLine();
            Credits();
        }

        public static void SaveGame(BasePlayer player)
        {
            string json = JsonSerializer.Serialize(player, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText("savegame.json", json);
        }

        public static void DeleteSave()
        {
            if (File.Exists("savegame.json"))
            {
                File.Delete("savegame.json");
                Console.WriteLine("Save File wurde zurückgesetzt.");
            }
        }
        public static bool CheckSave()
        {
            if (!File.Exists("savegame.json"))
                return false;
            else
                return true;
        }

        public static BasePlayer LoadPlayer()
        {
            string json = File.ReadAllText("savegame.json");
            BasePlayer? player = JsonSerializer.Deserialize<BasePlayer>(json);

            if (player == null)
            {
                Console.WriteLine("Fehler, es wurde kein Spieler gefunden.");
                Pause();
                player = HeroFactory.CreatePlayer();
            }

            return player;
        }

        public static void HallofFameLoad()
        {
            if (File.Exists("hof.json"))
            {
                string json = File.ReadAllText("hof.json");
                hoflist = JsonSerializer.Deserialize<List<BasePlayer>>(json) ?? new List<BasePlayer>();
            }

            else
            {
                Console.WriteLine("Es gibt noch keine Einträge in der Hall of Fame!");
                Pause();
                hoflist = new List<BasePlayer>();
            }
        }

        public static void HallofFameAdd(BasePlayer player)
        {
            hoflist.Add(player);
        }

        public static void HofSave(List<BasePlayer> hoflist)
        {
            string json = JsonSerializer.Serialize(hoflist, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText("hof.json", json);
        }

        public static void HofShow()
        {
            for (int i = 0; i < hoflist.Count; i++)
            {
                BasePlayer player = hoflist[i];
                Console.Clear();
                Console.WriteLine($"================ {i + 1}. =============================");
                Console.WriteLine($"Spieler: {player.Name}");
                Console.WriteLine($"Rasse: {player.Race}");
                Console.WriteLine($"Ability: {player.HeroAbility}");
                Console.WriteLine($"===================================================");
                Console.WriteLine($"Health: {player.Health}/{player.MaxHP} HP");
                Console.WriteLine($"Attack: {player.Attack}");
                Console.WriteLine($"Defense: {player.Defense}");
                Console.WriteLine($"Crit: {player.Crit}%");
                Console.WriteLine($"Specialpoints: {player.SpecialPoints}/{player.MaxSP} SP");
                Console.WriteLine("=====================================================");
                Console.WriteLine($"================= {i + 1}/{hoflist.Count} ==================");
                Console.WriteLine("======== Fortfahren mit beliebiger Taste... ");
                Pause();
            }
            Console.Clear();
        }

        public static void Pause()
        {
            Console.WriteLine(" ▼ Weiter ▼ ");
            Console.ReadKey(true);
        }

        public static void PauseTime(int time)
        {
            Thread.Sleep(time);
        }

        public static void GameOverScreen(BasePlayer player)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("======================================");
            Console.WriteLine($"======== {player.Name} ist gefallen =========");
            Console.WriteLine("======================================");
            Console.WriteLine("Das RaumZeit Loch breitet sich immer weiter aus");
            Console.WriteLine("Totales Chaos verschlingt die Welten");
            Console.WriteLine("======================================");
            Pause();
            Console.WriteLine("Die Welt und auch dieses Spiel wurden zerstört.");
            Console.WriteLine("In fernen Äonen wird womöglich jemand erneut geboren.");
            Pause();
            Environment.Exit(0);
        }

    }
}