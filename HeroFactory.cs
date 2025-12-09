namespace RPG
{
    public static class HeroFactory
    {
        // Klasse für Heldenerstellung
        public static BasePlayer CreatePlayer()
        {
            string rasse;
            bool taskDone = false;            
            string name = InputHelper.GetValidString("Wie lautet dein Name?");
            do
            {
                rasse = InputHelper.GetValidString("Möchtest du Krieger, Magier oder Schurke sein?");

                if (rasse.ToLower() == "krieger" || rasse.ToLower() == "magier" || rasse.ToLower() == "schurke")
                {
                    taskDone = true;
                }
            }while(!taskDone);

            string playerRasse;

            if (rasse.ToLower() == "krieger")
            {
                playerRasse = "Krieger";
            }

            else if (rasse.ToLower() == "magier")
            {
                playerRasse = "Magier";
            }

            else
            {
                playerRasse = "Schurke";
            }

            var stats = RaceLibrary.raceStats[playerRasse];

            Inventory inventory= new Inventory(new List<string>());

            int health = stats.Health;
            int level = stats.Level;
            int xp = stats.XP;
            int maxHP = stats.MaxHP;
            int attack = stats.Attack;
            int defense = stats.Defense;
            int crit = stats.Crit;
            int special = stats.SpecialPoints;
            int maxSP = stats.MaxSP;
            string ability = stats.HeroAbility;
                       

            return new BasePlayer(name, level, xp, maxHP, attack, defense, health, crit, special, maxSP, inventory, playerRasse, ability);      
        }
    }

    public static class RaceLibrary
    {
        public static Dictionary<string, (int Health,int Level, int XP, int MaxHP, int Attack, int Defense,  int Crit, int SpecialPoints, int MaxSP, string HeroAbility)> raceStats= new()
        {
            {"Krieger", (250, 1, 0, 250, 25, 9, 7, 3, 3, "")},
            {"Magier", (220, 1, 0 , 220, 26, 8, 9, 4, 4, "")},
            {"Schurke", (215, 1, 0, 215, 28, 7, 11, 5, 5, "Verstohlener Dolchstoß")}
        };
    }

    public static class RaceAbility
    {
        public static Dictionary<string, PlayerSpAtt> specialMoves = new()
        {
            //Rogue
            {"Sprung der Assassinen", new PlayerSpAtt("Sprung der Assassinen", 25, 20,  "stealth")},
            {"Verstohlener Dolchstoß", new PlayerSpAtt("Verstohlener Dolchstoß", 15, 25, "stealth")},
            //Krieger
            {"Ansturm der 300 Krieger", new PlayerSpAtt("Ansturm der 300 Krieger", 40, 0, "focus")},
            {"Genkidama", new PlayerSpAtt("Genkidama", 55, 50, "stunned")},
            //Magier
            {"Schwarze Magie", new PlayerSpAtt("Schwarze Magie", 30, 5, "focus")},
            {"Avatarstrahl", new PlayerSpAtt("Avatarstrahl", 42, 25, "")},
        };
    }


}