namespace RPG
{
    public class Shopping
    {
        // Klasse zur Shoperstellung. Inkl Beschreibung und String der Items
        public static Shop CreateShopW1A()
        {
            return new Shop("Händler der fernen Oase",
                "Du findest dich in einer kargen Wüstenlandschaft wieder. Vor dir befindet sich eine Oase. Ein Händler winkt dir auf seinem Kamel zu.",
                new List<string> { "Wüstentinktur", "Sanduhr der Zeit", "Dünenkristall" });
        }

        public static Shop CreateShopW1B()
        {
            return new Shop("Elfenbasar in Trixinia",
                "Du bist in einem wunderschönen Tal mit einem großen Fluss. Nebendran ist ein Marktplatz. Ein Händler ruft dich zu sich!",
                new List<string> { "Elfentrank", "Magischer Ring der Hochelfen", "Feenstaub" });
        }

        public static Shop CreateShopW2A()
        {
            return new Shop("Mechanische Werkstatt von Nova-City",
                "Du betrittst eine metallische Halle voller Maschinen und blinkender Anzeigen. Ein Händler bietet seine technischen Waren an.",
                new List<string> { "Nanoöl", "Plasmabatterie", "Schaltkreis der Zukunft" });
        }

        public static Shop CreateShopW2B()
        {
            return new Shop("Alchemist in den Nebelbergen",
                "Du stehst in einer kleinen Hütte in den Bergen, Rauch und Kräuterduft liegen in der Luft.",
                new List<string> { "Bergkrauttrank", "Elixier der Sicht", "Kristallampulle" });
        }

        public static Shop CreateShopW3A()
        {
            return new Shop("Drachenmarkt von Aetheria",
                "Du gehst durch ein Tal voller glühender Kristalle, in dessen Mitte Händler ihre Schätze präsentieren.",
                new List<string> { "Drachenblut-Elixier", "Funkenkristall", "Schuppenring" });
        }

        public static Shop CreateShopW3B()
        {
            return new Shop("Unterirdischer Basar der Schatten",
                "Du befindest dich in einer riesigen Höhle, deren Wände mit magischen Glyphen leuchten. Händler rufen aus dunklen Ecken.",
                new List<string> { "Schattenumhang", "Nebeltrank", "Runenamulet" });
        }

        public static Dictionary<string, int> prices = new()
            {
                {"Wüstentinktur", 10},
                {"Sanduhr der Zeit", 25},
                {"Dünenkristall", 30},
                {"Elfentrank", 40},
                {"Magischer Ring der Hochelfen", 35},
                {"Feenstaub", 15},
                {"Nanoöl", 20},
                {"Plasmabatterie", 50},
                {"Schaltkreis der Zukunft", 70},
                {"Bergkrauttrank", 25},
                {"Elixier der Sicht", 45},
                {"Kristallampulle", 30},
                {"Drachenblut-Elixier", 60},
                {"Funkenkristall", 40},
                {"Schuppenring", 35},
                {"Schattenumhang", 55},
                {"Nebeltrank", 30},
                {"Runenamulet", 50}
            };

        //shop methode für kaufen und info



    }

    public static class Camping
    {
        // Klasse zur Campfire Erstellung. Inkl Beschreibung, Liste NPCS und Methoden
        public static Random random = new Random();

        public static List<string> randosW1u = new List<string>{
            "Reisender aus Tamriel",
            "Wanderer aus einem fernen Land",
            "Barde aus Westeros"};

        public static List<string> randosW1 = randosW1u.OrderBy(x => random.Next()).ToList();

        //Welt 1 Campfires
        public static Campfire CreateCampfireW1A()
        {
            return new Campfire("Lager der verbannten Hochelfen",
            "Du bist an einem düsteren Ort, in der Ferne brennt ein Lagerfeuer. Du trittst näher.",
            randosW1);
        }

        public static Campfire CreateCampfireW1B()
        {
            return new Campfire("Festung am eisernen Berg",
            "Du bist auf einem hohen Berg, du riechst den Geruch von Kohle und verbranntem Fleisch. Du trittst näher.",
            randosW1);
        }

        public static Campfire CreateCampfireW1C()
        {
            return new Campfire("Dorfplatz im alten Ägypten",
            "Du befindest dich an einem trockenen, sandigen Ort, im Hintergrund siehst du Pyramiden. Du gehst zum Lagerfeuer",
            randosW1);
        }

        public static List<string> randosW2u = new List<string>{
            "Aethra Nova, die Sternenbastlerin",
            "Gearlos, der Flammenrufer-Schmied",
            "Pixelveil, der Maschinensänger"};

        public static List<string> randosW2 = randosW2u.OrderBy(x => random.Next()).ToList();

        // Welt 2 Campfires
        public static Campfire CreateCampfireW2A()
        {
            return new Campfire("Verlassene Fabrikhalle",
                "Du betrittst eine alte Fabrikhalle, metallische Trümmer liegen verstreut. Ein kleines Feuer knistert.",
                randosW2);
        }

        public static Campfire CreateCampfireW2B()
        {
            return new Campfire("Neonlicht-Lichtung",
                "Du findest eine Lichtung, in der futuristische Neonlichter glimmen. Ein Feuer spendet Wärme.",
                randosW2);
        }

        public static Campfire CreateCampfireW2C()
        {
            return new Campfire("Technikschuppen im Wald",
                "Du trittst in einen verlassenen Schuppen voller blinkender Geräte. Ein kleines Feuer brennt in der Mitte.",
                randosW2);
        }

        public static List<string> randosW3u = new List<string>{
            "Cyrilla die Kristallkundige",
            "Krynn der Schattenwanderer",
            "Shadowveil der Runenmeister"
            };

        public static List<string> randosW3 = randosW3u.OrderBy(x => random.Next()).ToList();


        // Welt 3 Campfires
        public static Campfire CreateCampfireW3A()
        {
            return new Campfire("Kristallberge",
                "Mitten in den schimmernden Kristallbergen brennt ein Feuer, das magische Funken in die Luft wirbelt.",
                randosW3);
        }

        public static Campfire CreateCampfireW3B()
        {
            return new Campfire("Runenhöhle",
                "Du befindest dich in einer dunklen Höhle, deren Wände von Runen erleuchtet werden. Ein Feuer brennt in der Mitte.",
                randosW3);
        }

        public static Campfire CreateCampfireW3C()
        {
            return new Campfire("Verlassene Ruine",
                "Du findest eine alte Ruine mit einem kleinen Feuer, das zwischen den Steinen warm glimmt.",
                randosW3);
        }
    }

    public static class NPCLibrary
    {
        public static Dictionary<string, Func<NPC>> NPCs = new Dictionary<string, Func<NPC>>()
             {
                // Welt 1
                { "Reisender aus Tamriel", ReisenderAusTamriel },
                { "Wanderer aus einem fernen Land", WandererAusFernenLand },
                { "Barde aus Westeros", GoldspendenderBarde },
         
                // Welt 2
                { "Aethra Nova, die Sternenbastlerin", AethraNova },
                { "Gearlos, der Flammenrufer-Schmied", Gearlos },
                { "Pixelveil, der Maschinensänger", Pixelveil },

                // Welt 3
                { "Cyrilla die Kristallkundige", Cyrilla },
                { "Krynn der Schattenwanderer", Krynn },
                { "Shadowveil der Runenmeister", Shadowveil }
            };


        public static NPC GoldspendenderBarde()
        {
            return new NPC(
                "Barde aus Westeros",
                "Ein fröhlicher Barde winkt dir zu: 'Willst du ein kleines Opfer für die Musik geben?'",
                "Der Barde nickt dir zu: 'Möge dein Weg mit Melodien gesegnet sein!'",
                (player) =>
                {
                    Console.WriteLine("Wie viele Münzen möchtest du spenden?");
                    int coins = InputHelper.GetCoins($"Du hast {player.Money} Gold. Gib die Anzahl der Münzen ein:", player.Money);

                    if (coins == 0)
                    {
                        Console.WriteLine("Der Barde schaut enttäuscht: 'Keine Münzen, keine Musik für dich.");
                    }
                    else if (coins <= 20)
                    {
                        DungeonHelper.AddBuff(player, "XP", 5, "Der Barde lächelt und spielt ein kleines Lied für dich.");
                        Level.LvlUpCheck(player);
                    }
                    else
                    {
                        DungeonHelper.AddBuff(player, "XP", 25, "Der Barde ist überwältigt! Er spielt ein episches Meisterstück für dich.");
                        Level.LvlUpCheck(player);
                    }

                    player.Money -= coins;
                }
            );
        }

        public static NPC ReisenderAusTamriel()
        {
            return new NPC(
                "Reisender aus Tamriel",
                "Ein wettergegerbter Wanderer wärmt sich am Feuer: 'Hast du Zeit für Geschichten aus fernen Landen?'",
                "Der Reisende zieht weiter, die Geschichten hallen nach.",
                (player) =>
                {
                    if (InputHelper.AskYesNo("Willst du den Geschichten lauschen?"))
                    {
                        DungeonHelper.AddBuff(player, "XP", 20, "Du hast den Geschichten aufmerksam zugehört und wertvolle Erfahrung gewonnen!");
                        Level.LvlUpCheck(player);
                    }
                    else
                    {
                        Console.WriteLine("Du ignorierst den Reisenden. Keine XP erhalten.");
                    }
                }
            );
        }

        public static NPC WandererAusFernenLand()
        {
            return new NPC(
                "Wanderer aus einem fernen Land",
                "Ein Wanderer trägt vergilbte Karten und riecht nach Wüstensand: 'Gold gegen Geheimnisse?'",
                "Der Wanderer zieht weiter, das Sandkorn im Schuh noch spürbar.",
                (player) =>
                {
                    Console.WriteLine("Wie viele Münzen möchtest du spenden?");
                    int coins = InputHelper.GetCoins($"Du hast {player.Money} Gold. Gib die Anzahl der Münzen ein:", player.Money);

                    if (coins == 0)
                    {
                        DungeonHelper.AddDebuff(player, "Gold", 15, "Der Wanderer ist enttäuscht und klaut dir etwas Gold.");
                    }
                    else if (coins <= 20)
                    {
                        DungeonHelper.AddBuff(player, "Attack", 2, "Der Wanderer zeigt dir seinen Popcorntrick!");
                    }
                    else
                    {
                        DungeonHelper.AddBuff(player, "XP", 25, "Der Wanderer ist beeindruckt! Du erhältst eine große Menge XP.");
                        Level.LvlUpCheck(player);
                    }

                    player.Money -= coins;
                }
            );
        }

        public static NPC AethraNova()
        {
            return new NPC(
                "Aethra Nova, die Sternenbastlerin",
                "Aethra streicht mit den Fingern durch die Luft, drei Sternsplitter schweben vor dir.",
                "Aethra nickt dir zu und verschwindet in den funkelnden Sternen.",
                (player) =>
                {
                    int roll = Random.Shared.Next(3);
                    if (roll == 0)
                        DungeonHelper.AddBuff(player, "Attack", 3, "Du berührst den Nova-Splitter und fühlst kosmische Kraft!");
                    else if (roll == 1)
                        Console.WriteLine("Der Umbra-Splitter zeigt nichts von Bedeutung.");
                    else
                        DungeonHelper.AddDebuff(player, "Attack", 3, "Der Void-Splitter entzieht dir Kraft!");
                }
            );
        }

        public static NPC Gearlos()
        {
            return new NPC(
                "Gearlos, der Flammenrufer-Schmied",
                "Gearlos schlägt mit wuchtigem Klang auf seinen Amboss: 'Tribut an die Feuergeister!'",
                "Gearlos nickt kurz, die Funken tanzen weiter.",
                (player) =>
                {
                    Console.WriteLine("Wie viele Münzen möchtest du dem Schmied spenden?");
                    int coins = InputHelper.GetInt($"Du hast {player.Money} Gold. Gib die Anzahl der Münzen ein:", player.Money);

                    if (coins == 0)
                        DungeonHelper.AddDebuff(player, "Attack", 2, "Die Feuergeister sind beleidigt! Angriff gesunken.");
                    else if (coins <= 20)
                        DungeonHelper.AddBuff(player, "Attack", 2, "Die Feuergeister sind zufrieden. Angriff leicht erhöht.");
                    else
                        DungeonHelper.AddBuff(player, "Attack", 3, "Die Feuergeister sind beeindruckt! Angriff stark erhöht.");

                    player.Money -= coins;
                }
            );
        }

        public static NPC Pixelveil()
        {
            return new NPC(
                "Pixelveil, der Maschinensänger",
                "Pixelveil summt eine komplexe Maschinenmelodie.",
                "Die Zahnräder verstummen langsam.",
                (player) =>
                {

                    if (InputHelper.AskYesNo("Willst du der Maschinenmelodie zuhören?"))
                    {
                        DungeonHelper.AddBuff(player, "XP", 10, "Du hast der Melodie gelauscht und Erfahrung gewonnen!");
                        Level.LvlUpCheck(player);
                    }
                    else
                    {
                        DungeonHelper.AddDebuff(player, "Crit", 2, "Die dissonante Melodie stört dich, Krit-Chance gesunken.");
                    }
                }
            );
        }

        public static NPC Cyrilla()
        {
            return new NPC(
                "Cyrilla die Kristallkundige",
                "Sie führt dich zu einem schimmernden Kristallkreis: 'Berühre einen Kristall, wenn du dich traust.'",
                "Aethra verlässt dich mit einem rätselhaften Lächeln.",
                (player) =>
                {
                    int roll = Random.Shared.Next(3);
                    if (roll == 0)
                        DungeonHelper.AddBuff(player, "Defense", 4, "Der Kristall leuchtet! Verteidigung erhöht.");
                    else if (roll == 1)
                        Console.WriteLine("Der Kristall bleibt still, du spürst nichts.");
                    else
                        DungeonHelper.AddDebuff(player, "Defense", 3, "Ein dunkler Kristall entzieht dir Kraft!");
                }
            );
        }

        public static NPC Krynn()
        {
            return new NPC(
                "Krynn der Schattenwanderer",
                "Ein Schatten löst sich von der Wand: 'Ich beobachte dich…'",
                "Krynn verschwindet wieder in den Schatten.",
                (player) =>
                {
                    int roll = Random.Shared.Next(3);
                    if (roll == 0)
                        DungeonHelper.AddBuff(player, "Crit", 5, "Die Schatten geben dir Stärke! Krit-Chance gestiegen.");
                    else if (roll == 1)
                        Console.WriteLine("Die Schatten bleiben unauffällig.");
                    else
                        DungeonHelper.AddDebuff(player, "Attack", 2, "Die Schatten schwächen dich! Angriff gesunken.");
                }
            );
        }

        public static NPC Shadowveil()
        {
            return new NPC(
                "Shadowveil der Runenmeister",
                "Shadowveil zeichnet glühende Runen in die Luft: 'Hilf mir, die Rune zu stabilisieren.'",
                "Die Runen erlöschen langsam.",
                (player) =>
                {
                    if (InputHelper.AskYesNo("Willst du beim Stabilisieren der Rune helfen?"))
                        DungeonHelper.AddBuff(player, "SpecialPoints", 1, "Die Rune reagiert positiv! SP erhöht.");
                    else
                        DungeonHelper.AddDebuff(player, "Defense", 3, "Die Rune flackert unruhig. Verteidigung gesunken.");
                }
            );
        }
    }


}
