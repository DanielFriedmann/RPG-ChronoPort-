namespace RPG
{
    public static class Menu
    {

        public static void ShowMenu()
        {
            bool taskDone = false;
            do
            {

                Console.Clear();
                Console.WriteLine("=========================================");
                Console.Write("------ "); ColorSwitch("Willkommen zu Chrono Port!", ConsoleColor.DarkYellow); Console.WriteLine("------");
                Console.WriteLine("=========================================");
                Console.WriteLine("----- 1. Neues Spiel -----");
                Console.WriteLine("----- 2. Spiel laden -----");
                Console.WriteLine("----- 3. Hall of Fame -----");
                Console.WriteLine("----- 4. Infos -----");
                Console.WriteLine("----- 5. Beenden -----");
                Console.WriteLine("==========================================");

                int choice = InputHelper.GetInt("----- Treffen sie eine Auswahl. -----", 4);

                switch (choice)
                {
                    case 1:
                        BasePlayer held = HeroFactory.CreatePlayer();
                        DungeonGenerator.GenerateDungeonW1(held);
                        DungeonGenerator2.GenerateDungeonW2(held);
                        DungeonGenerator3.GenerateDungeonW3(held);
                        break;

                    case 2:
                        if (DungeonHelper.CheckSave())
                        {
                            BasePlayer hero = DungeonHelper.LoadPlayer();
                            if (hero.Progress == 2)
                            {
                                DungeonGenerator2.GenerateDungeonW2(hero);
                            }
                            else
                            {
                                DungeonGenerator3.GenerateDungeonW3(hero);
                            }
                        }

                        else
                        {
                            Console.WriteLine("Es wurde kein Spielstand gefunden...");
                            Console.WriteLine("Kehre zurück zum Menü...");
                            DungeonHelper.Pause();                            
                        }
                        break;

                    case 3:
                        DungeonHelper.HallofFameLoad();
                        DungeonHelper.HofShow();
                        break;

                    case 4:
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine("Vielen Dank fürs Spielen!");
                        Console.WriteLine("Programm wird heruntergefahren...");
                        DungeonHelper.PauseTime(2000);
                        taskDone = true;
                        break;
                }
            } while(!taskDone);

        }

        public static void TitleScreen()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("===================================");
            Console.WriteLine("-----------------------------------");
            Console.Write("-----------");ColorSwitch("CHRONO-PORT", ConsoleColor.DarkYellow); Console.WriteLine("-------------");
            Console.WriteLine("===================================");
            Console.WriteLine("===== Press any key to start ======");
            Console.WriteLine("===================================");
            Console.WriteLine("===================================");
            Console.ReadKey(); //evtll Titel Melodie
        }

        public static void ColorSwitch(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}