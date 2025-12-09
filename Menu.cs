namespace RPG
{
    //MENÜ KLASSE mit Methoden für Lore, Info und Title Screen
    public static class Menu
    {

        public static void ShowMenu()
        {
            bool taskDone = false;
            do
            {
                Console.WriteLine("=========================================");
                Console.Write("------ "); ColorSwitch("Willkommen zu Chrono-Port!", ConsoleColor.DarkYellow); Console.WriteLine("------");
                Console.WriteLine("=========================================");
                Console.WriteLine("----- 1. Neues Spiel -----");
                Console.WriteLine("----- 2. Spiel laden -----");
                Console.WriteLine("----- 3. Hall of Fame -----");
                Console.WriteLine("----- 4. Infos -----");
                Console.WriteLine("----- 5. Beenden -----");
                Console.WriteLine("==========================================");

                int choice = InputHelper.GetInt("----- Treffen sie eine Auswahl. -----", 5);

                switch (choice)
                {
                    case 1:
                        Lore();
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
                                DungeonGenerator3.GenerateDungeonW3(hero);
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
                        Info();
                        break;

                    case 5:
                        Console.WriteLine("Vielen Dank fürs Spielen!");
                        Console.WriteLine("Programm wird heruntergefahren...");
                        DungeonHelper.PauseTime(2000);
                        taskDone = true;
                        break;
                }


            } while (!taskDone);

        }

        public static void Info()
        {
            Console.Clear();
            Console.WriteLine("============================= INFO ========================================");
            Console.WriteLine(" ▼ <= Das ist das WeiterSymbol. Drücke beliebige Taste um Weiterzumachen.");
            DungeonHelper.Pause();
            Console.WriteLine("Wunderbar, das funktioniert ja schonmal!");
            Console.WriteLine("Möchtest du die Lore erneut lesen? y/n");
            if (InputHelper.AskYesNo("Möchtest du die Lore erneut lesen?"))
            {
                Lore();
            }
        }

        public static void Lore()
        {
            Console.Clear();
            Console.WriteLine("Einst war die Welt im Gleichgewicht.");
            Console.WriteLine("Vergangenheit, Gegenwart und Zukunft flossen in geordneten Bahnen nebeneinander her.");
            Console.WriteLine("Doch dann… kam die Zersplitterung.");
            DungeonHelper.Pause();
            Console.WriteLine("Eine uralte, namenlose Macht durchbrach die Grenzen der Zeit.");
            Console.WriteLine("Zeitlinien kollidierten, Realitäten verschmolzen -");
            Console.WriteLine("und überall auf der Welt öffneten sich Portale in fremde Epochen und Universen.");
            DungeonHelper.Pause();
            Console.WriteLine("Ritter kämpfen neben Maschinen.");
            Console.WriteLine("Magie trifft auf Technologie.");
            Console.WriteLine("Vergangene Imperien erwachen während die Zukunft zerfällt");
            DungeonHelper.Pause();
            Console.WriteLine("Doch es gibt Hoffnung.");
            Console.WriteLine("Drei uralte Artefakte der Ordnung, verloren in den zerrissenen Welten,");
            Console.WriteLine("sind der einzige Schlüssel, um die Zeit wieder zu heilen.");
            DungeonHelper.Pause();
            Console.WriteLine("Du bist der letzte Wanderer zwischen den Welten.");
            Console.WriteLine("Der Einzige, der die Portale betreten kann, ohne darin zu zerbrechen.");
            Console.WriteLine("Das Abenteuer beginnt.....");
            DungeonHelper.Pause();
        }
        public static void TitleScreen()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("===================================");
            Console.WriteLine("-----------------------------------");
            Console.Write("-----------"); ColorSwitch("CHRONO-PORT", ConsoleColor.DarkYellow); Console.WriteLine("-------------");
            Console.WriteLine("===================================");
            Console.WriteLine("===== Press any key to start ======");
            Console.WriteLine("===================================");
            Console.WriteLine("===================================");            
            Console.ReadKey();                                          //evtll Titel Melodie
            Console.Clear();
        }
        public static void ColorSwitch(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}