namespace RPG
{
    public static class HeroFactory
    {
        public static BasePlayer CreatePlayer()
        {
            string rasse;
            bool taskDone = false;
            string name = InputHelper.GetValidString("Wie lautet der Name des Heldes?");
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
            int attack = stats.Attack;
            int defense = stats.Defense;
            int crit = stats.Crit;
            int special = stats.SpecialPoints;

            return new BasePlayer(name, level, attack, defense, health, crit, special, inventory);      
        }
    }

    public static class RaceLibrary
    {
        public static Dictionary<string, (int Health,int Level, int Attack, int Defense,  int Crit, int SpecialPoints)> raceStats= new()
        {
            {"Krieger", (50, 1, 25, 18, 10, 3)},
            {"Magier", (50, 1, 26, 18, 15, 5)},
            {"Schurke", (50, 1, 28, 15, 18, 5)}
        };
    }
}