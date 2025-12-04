namespace RPG
{
    public static class Level
    {
        public static void LvlUpCheck(BasePlayer player)
        {
            switch (player.Level)
            {
                case 1:
                    if (player.Xp > 50)
                    {
                        player.Level += 1;
                        Console.WriteLine($"Herzlichen Glückwunsch! Du hast Level {player.Level} erreicht!");
                        LvlUpScreen(player);
                    }
                    break;
                case 2:
                    if (player.Xp > 100)
                    {
                        player.Level += 1;
                        Console.WriteLine($"Herzlichen Glückwunsch! Du hast Level {player.Level} erreicht!");
                        LvlUpScreen(player);
                    }
                    break;
                case 3:
                    if (player.Xp > 300)
                    {
                        player.Level += 1;
                        Console.WriteLine($"Herzlichen Glückwunsch! Du hast Level {player.Level} erreicht!");
                        LvlUpScreen(player);
                        ChooseSub(player);
                    }
                    break;
                case 4:
                    if (player.Xp > 400)
                    {
                        player.Level += 1;
                        Console.WriteLine($"Herzlichen Glückwunsch! Du hast Level {player.Level} erreicht!");
                        LvlUpScreen(player);
                    }
                    break;
                case 5:
                    if (player.Xp > 500)
                    {
                        player.Level += 1;
                        Console.WriteLine($"Herzlichen Glückwunsch! Du hast Level {player.Level} erreicht!");
                        LvlUpScreen(player);
                    }
                    break;

            }
        }

        public static void ChooseSub(BasePlayer player)
        {
            Console.WriteLine("Glückwunsch! Du hast eine Subklasse freigeschaltet!");
            Console.WriteLine("==================================================================================");            
            if(player.Race == "Krieger")
            {
                Console.WriteLine("1. Sayajin. Gibt dir eine Fähigkeit die nur wahre Sayajin entfesseln können");
                Console.WriteLine("2. Titan. Werde zum Fels in der Brandung für alle die dir wichtig sind.");
                int choice = InputHelper.GetInt("Wähle eine Option", 2);
                if (choice == 1)
                {
                    Console.WriteLine("Du bist jetzt ein Sayajin! Spezialfähigkeit ist nun Genkidama!");
                    player.Race = "Sayajin";
                    player.HeroAbility = "Genkidama";
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Du bist jetzt ein Titan! Spezialfähigkeit ist nun Ansturm der 300 Krieger!");
                    player.Race = "Titan";
                    player.HeroAbility = "Ansturm der 300 Krieger";
                }
            }

            else if(player.Race == "Magier")
            {
                Console.WriteLine("1. Dunkler Magier. Gefürchtet vorallem von Drachen mit eiskaltem Blick.");
                Console.WriteLine("2. Astral Magier. Du wirst zum Herr der vier Elemente.");
                 int choice = InputHelper.GetInt("Wähle eine Option", 2);
                if (choice == 1)
                {
                    Console.WriteLine("Du bist jetzt ein Dunkler Magier! Spezialfähigkeit ist nun Schwarze Magie!");
                    player.Race = "Dunkler Magier";
                    player.HeroAbility = "Schwarze Magie";
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Du bist jetzt ein Astral Magier! Spezialfähigkeit ist nun Avatarstrahl!");
                    player.Race = "Astral Magier";
                    player.HeroAbility = "Avatarstrahl";
                }
            }

            else if(player.Race == "Schurke")
            {
                Console.WriteLine("1. Assassine. Aus dem Verborgenen kommt tödliche Mordlust.");
                Console.WriteLine("2. Gieriger Schurke. Du behältst deine bisherige Ability und bekommst 100 Gold");
                 int choice = InputHelper.GetInt("Wähle eine Option", 2);
                if (choice == 1)
                {
                    Console.WriteLine("Du bist jetzt ein Assassine! Spezialfähigkeit ist nun Sprung der Assassinen!");
                    player.Race = "Assassine";
                    player.HeroAbility = "Sprung der Assassinen";
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Du bist jetzt ein Gieriger Schurke! Spezialfähigkeit bleibt verstohlener Dolchstoß");
                    player.Race = "Gieriger Schurke";                    
                }
            }
        }

        public static void LvlUpScreen(BasePlayer player)
        {
            Console.WriteLine("Du hast einen Skillpunkt erhalten!");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"1. Attack: {player.Attack}");
            Console.WriteLine($"2. Defense: {player.Defense}");
            Console.WriteLine($"3. Health: {player.Health}/{player.MaxHP} HP");
            Console.WriteLine($"4. SpecialPoints: {player.SpecialPoints}/{player.MaxSP} SP");
            Console.WriteLine("---------------------------------------------------------------");
            int choice = InputHelper.GetInt("Welchen Wert möchtest du erhöhen?", 4);

            switch (choice)
            {
                case 1:
                    player.Attack += 2;
                    Console.WriteLine($"Angriff wurde erhöht. {player.Attack - 2} => {player.Attack}");
                    break;

                case 2:
                    player.Defense += 2;
                    Console.WriteLine($"Verteidigung wurde erhöht. {player.Defense - 2} => {player.Defense}");
                    break;

                case 3:
                    player.MaxHP += 5;
                    Console.WriteLine($"Max HP wurde erhöht. {player.MaxHP - 5} => {player.MaxHP}");
                    if(player.Health + 5 >= player.MaxHP)
                    {
                        player.Health = player.MaxHP;
                        Console.WriteLine($"HP: {player.Health}/{player.MaxHP}");
                    }
                    else
                    {
                        player.Health += 5;
                        Console.WriteLine($"HP: {player.Health}/{player.MaxHP}");
                    }
                    break;

                case 4:
                    player.MaxSP += 1;
                    Console.WriteLine($"Max SP wurden erhöht. {player.MaxSP - 1} => {player.MaxSP}");
                    if(player.SpecialPoints + 1 >= player.MaxSP)
                    {
                        player.SpecialPoints = player.MaxSP;
                        Console.WriteLine($"SP: {player.SpecialPoints}/{player.MaxSP}");
                    }
                    else
                    {
                        player.SpecialPoints += 1;
                        Console.WriteLine($"SP: {player.SpecialPoints}/{player.MaxSP}");
                    }
                    break;
            }
        }
    }
}