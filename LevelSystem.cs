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