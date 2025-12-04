using System.Diagnostics.Contracts;

namespace RPG
{
    public static class BossFactory
    {
        //Welt 1 Bosse
        public static BossMonster ChronoRex()
        {
            return new BossMonster("Chrono-Rex, der Fossilienkaiser",
            7, 24, 12, 42,
            new List<string> { "Primal Rage", "Temporal Stampede", "Fossil Barrage" },
            MonsterDropsLibrary.MonsterDrops["Boss 1"],
            MonsterDropsLibrary.MonsterDrops["Chrono-Rex"],
            "Der Boden zittert. Aus einem Riss in der Zeit bricht ein T-Rex, von glühenden Leitungen überzogen. Sein Metallmaul öffnet sich und die Welt um dich läuft eine Sekunde rückwärts.",
            "Der Chrono-Rex brüllt ein letztes Mal. Seine Panzerung knackt, Licht entweicht. Die Zeit um ihn herum wirbelt und beruhigt sich."
            );
        }

        public static BossMonster RiftMammut()
        {
            return new BossMonster("Rift-Mammut, Wächter der Ersten Strömung",
            6, 28, 10, 40,
            new List<string> { "Glacial Timeburst", "Stomp of Ages", "Chrono-Ice Wall" },
            MonsterDropsLibrary.MonsterDrops["Boss 1"],
            MonsterDropsLibrary.MonsterDrops["Rift-Mammut"],
            "Eisziger Nebel rollt heran, als ein Mammut mit stoßzähnen aus gefrorener Zeit hervorstapft.",
            "Das Mammut sinkt zu Boden, seine Stoßzähne zerbrechen im kalten Licht."
            );
        }

        public static BossMonster PrimalHydra()
        {
            return new BossMonster("Primal-Hydra, die Vielzeitige",
            8, 22, 14, 44,
            new List<string> { "Multi-Epoch Bite", "Regrow from Another Timeline", "Ancestral Lash" },
            MonsterDropsLibrary.MonsterDrops["Boss 1"],
            MonsterDropsLibrary.MonsterDrops["Primal-Hydra"],
            "Aus einem zeitlosen Sumpf erhebt sich eine Hydra, deren Köpfe aus verschiedenen Zeitaltern schimmern.",
            "Die Hydra zerfällt, während ihre Zeitlinien ineinander zusammenbrechen."
            );
        }
        //Welt 2 Bosse
        public static BossMonster MotherboardMatriarchin()
        {
            return new BossMonster("Motherboard-Matriarchin, Königin des Datenbrutschwarmes",
            7, 26, 11, 38,
            new List<string> { "Neural Overwrite", "Nanite Flood", "Reverse Protocol" },
            MonsterDropsLibrary.MonsterDrops["Boss 2"],
            MonsterDropsLibrary.MonsterDrops["Motherboard-Matriarchin"],
            "Eine Silhouette aus Kabeln und Fleisch tritt hervor, umgeben von schwirrenden Drohnen.",
            "Die Drohnen fallen zu Boden, während ihr Körper wie ein leerer Kabelbaum zusammensackt."
            );
        }

        public static BossMonster OmegaForge()
        {
            return new BossMonster("Omega-Forge, der Schmied der Unendlichen Fabrik",
            9, 30, 13, 50,
            new List<string> { "Molten Gearstorm", "Auto-Forge Cycle", "Industrial Grasp" },
            MonsterDropsLibrary.MonsterDrops["Boss 2"],
            MonsterDropsLibrary.MonsterDrops["Omega-Forge"],
            "Ein gigantischer Schmiedetitan ragt vor dir auf, Funken tanzen wie glühender Regen.",
            "Seine Schmiedefeuer erlöschen und der Titan erstarrt reglos im Metallstaub."
            );
        }

        public static BossMonster OracleUnitZ3()
        {
            return new BossMonster("Oracle-Unit Z3, die Zukunfts-KI",
            6, 20, 16, 36,
            new List<string> { "Predictive Laser", "Quantum Distortion", "Timeline Shield" },
            MonsterDropsLibrary.MonsterDrops["Boss 2"],
            MonsterDropsLibrary.MonsterDrops["Oracle-Unit Z3"],
            "Eine schwebende Sphäre scannt dich mit zuckenden Lichtlinien.",
            "Das Licht der Sphäre flackert kurz auf und verlischt im digitalen Zischen."
            );
        }
        //Welt 3 Bosse
        public static BossMonster Aethernox()
        {
            return new BossMonster("Aethernox, Drache der Letzten Stunde",
            10, 34, 18, 60,
            new List<string> { "Hourfall Blaze", "Era Shift", "Clockworld Crush" },
            MonsterDropsLibrary.MonsterDrops["Boss 3"],
            MonsterDropsLibrary.MonsterDrops["Aethernox"],
            "Die Zeit friert ein, als Aethernox aus schimmernden Zeitsplittern hervorbricht.",
            "Der Drache zerfällt in tickende Splitter, die lautlos in alle Epochen verwehen."
            );
        }

        public static BossMonster Solaryth()
        {
            return new BossMonster("Solaryth, der Sonnenwende-Wyrm",
            9, 32, 14, 54,
            new List<string> { "Cycle Flare", "Solstice Divide", "Eclipse Wings" },
            MonsterDropsLibrary.MonsterDrops["Boss 3"],
            MonsterDropsLibrary.MonsterDrops["Solaryth"],
            "Ein goldener Lichtstoß formt sich zu einem gewaltigen Drachen aus glühenden Schuppen.",
            "Sein Licht verblasst und ein leiser Klang begleitet sein Vergehen."
            );
        }

        public static BossMonster Nihilgron()
        {
            return new BossMonster("Nihilgron, der Schwarze Entwerfer",
            11, 30, 20, 58,
            new List<string> { "Void Erasure", "Null Flare", "Anti-Chron Pulse" },
            MonsterDropsLibrary.MonsterDrops["Boss 3"],
            MonsterDropsLibrary.MonsterDrops["Nihilgron"],
            "Stille breitet sich aus, als ein schwarzer Drache aus reinem Nichts Gestalt annimmt.",
            "Der Drache löst sich spurlos auf, als wäre er nie existiert."
            );
        }

    }
    public static class MonsterFactory
    {
        //World 1 Monster
        public static Monster Keiler()
        {
            return new Monster(
                "Keiler des Totwaldes",
                 4, 10, 15, 40,
                 new List<string> { "Raserei", "Sturmangriff" },
                 MonsterDropsLibrary.MonsterDrops["Keiler"]
                 );
        }

        public static Monster UntoterRitter()
        {
            return new Monster(
                "Untoter Ritter der Tafel",
                 4, 10, 15, 40,
                 new List<string> { "Dolchstoß", "Sturmangriff" },
                 MonsterDropsLibrary.MonsterDrops["UntoterRitter"]
                 );
        }

        public static Monster MadScientist()
        {
            return new Monster(
                "Verrückter Wissenschaftler",
                 4, 10, 15, 40,
                 new List<string> { "Feueratem", "Giftbiss" },
                 MonsterDropsLibrary.MonsterDrops["MadScientist"]
                 );
        }

        public static Monster LanzenRitter()
        {
            return new Monster(
                "Ritter der aufgehenden Sonne",
                5, 15, 15, 40,
                new List<string> { "Zornhieb", "Verwüster" },
                MonsterDropsLibrary.MonsterDrops["LanzenRitter"]
            );
        }

        public static Monster Waldkobold()
        {
            return new Monster(
                "Waldkobold",
                3, 8, 10, 35,
                new List<string> { "Klauenwirbel", "Nebelgriff" },
                MonsterDropsLibrary.MonsterDrops["Waldkobold"]
            );
        }

        public static Monster Steinkaefer()
        {
            return new Monster(
                "Steinkäfer",
                5, 5, 20, 40,
                new List<string> { "Splitterfaust", "Erdspalter" },
                MonsterDropsLibrary.MonsterDrops["Steinkaefer"]
            );
        }

        public static Monster Dorfschlaeger()
        {
            return new Monster(
                "Dorfschläger",
                4, 9, 12, 30,
                new List<string> { "Magenbrecher", "Knochenhieb" },
                MonsterDropsLibrary.MonsterDrops["Dorfschlaeger"]
            );
        }

        public static Monster Schleimling()
        {
            return new Monster(
                "Schleimling",
                2, 6, 12, 25,
                new List<string> { "Giftwolke", "Seuchenbiss" },
                MonsterDropsLibrary.MonsterDrops["Schleimling"]
            );
        }

        public static Monster Kraehenschwarm()
        {
            return new Monster(
                "Krähenschwarm",
                3, 7, 8, 30,
                new List<string> { "Schallkreischer", "Schattenstoß" },
                MonsterDropsLibrary.MonsterDrops["Kraehenschwarm"]
            );
        }

        public static Monster Waldgeist()
        {
            return new Monster(
                "Waldgeist",
                3, 6, 10, 32,
                new List<string> { "Geisterklinge", "Nebelgriff" },
                MonsterDropsLibrary.MonsterDrops["Waldgeist"]
            );
        }

        //World 2 Monster
    }

    public static class MonsterAttackLibrary
    {
        public static Dictionary<string, AttackMonster> MonsterAttacks = new()
            {
                {"Dolchstoß", new AttackMonster("Dolchstoß", 20, 95 )},
                {"Raserei", new AttackMonster("Raserei", 25, 80)},
                {"Sturmangriff", new AttackMonster("Sturmangriff", 28, 90)},
                {"Feueratem", new AttackMonster("Feueratem", 25, 95)},
                {"Giftbiss" , new AttackMonster("Giftbiss", 20, 90)},

                {"Knochenhieb", new AttackMonster("Knochenhieb", 12, 90)},
                {"Klauenwirbel", new AttackMonster("Klauenwirbel", 10, 95)},
                {"Schattenstoß", new AttackMonster("Schattenstoß", 15, 85)},
                {"Zornhieb", new AttackMonster("Zornhieb", 18, 80)},
                {"Erdspalter", new AttackMonster("Erdspalter", 22, 70)},
                {"Blutklinge", new AttackMonster("Blutklinge", 14, 90)},
                {"Berserkeransturm", new AttackMonster("Berserkeransturm", 20, 75)},
                {"Donnertritt", new AttackMonster("Donnertritt", 16, 85)},
                {"Splitterfaust", new AttackMonster("Splitterfaust", 13, 92)},
                {"Verwüster", new AttackMonster("Verwüster", 25, 65)},

                {"Frostlanze", new AttackMonster("Frostlanze", 17, 90)},
                {"Glutwelle", new AttackMonster("Glutwelle", 18, 85)},
                {"Kettenblitz", new AttackMonster("Kettenblitz", 20, 80)},
                {"Säureregen", new AttackMonster("Säureregen", 12, 95)},
                {"Arkaneruption", new AttackMonster("Arkaneruption", 23, 75)},
                {"Schattenflamme", new AttackMonster("Schattenflamme", 19, 85)},
                {"Nebelgriff", new AttackMonster("Nebelgriff", 10, 98)},
                {"Seelenbrand", new AttackMonster("Seelenbrand", 22, 70)},
                {"Astralschlag", new AttackMonster("Astralschlag", 16, 90)},
                {"Geisterklinge", new AttackMonster("Geisterklinge", 14, 93)},

                {"Tentakelpeitsche", new AttackMonster("Tentakelpeitsche", 11, 95)},
                {"Giftwolke", new AttackMonster("Giftwolke", 13, 90)},
                {"Schallkreischer", new AttackMonster("Schallkreischer", 18, 80)},
                {"Zehrende Berührung", new AttackMonster("Zehrende Berührung", 16, 88)},
                {"Knochensplitter", new AttackMonster("Knochensplitter", 15, 90)},
                {"Schuppenschlag", new AttackMonster("Schuppenschlag", 14, 94)},
                {"Rasender Sprung", new AttackMonster("Rasender Sprung", 17, 82)},
                {"Verderbnisstoß", new AttackMonster("Verderbnisstoß", 21, 75)},
                {"Magenbrecher", new AttackMonster("Magenbrecher", 19, 85)},
                {"Seuchenbiss", new AttackMonster("Seuchenbiss", 12, 92)},

                //Boss Attacken
                // Welt 1 Boss Attacken
                {"Primal Rage", new AttackMonster("Primal Rage", 20, 85)},
                {"Temporal Stampede", new AttackMonster("Temporal Stampede", 22, 80)},
                {"Fossil Barrage", new AttackMonster("Fossil Barrage", 18, 90)},

                {"Glacial Timeburst", new AttackMonster("Glacial Timeburst", 17, 88)},
                {"Stomp of Ages", new AttackMonster("Stomp of Ages", 19, 82)},
                {"Chrono-Ice Wall", new AttackMonster("Chrono-Ice Wall", 16, 90)},

                {"Multi-Epoch Bite", new AttackMonster("Multi-Epoch Bite", 21, 83)},
                {"Regrow from Another Timeline", new AttackMonster("Regrow from Another Timeline", 18, 85)},
                {"Ancestral Lash", new AttackMonster("Ancestral Lash", 20, 80)},

                // Welt 2 Boss-Attacken
                {"Neural Overwrite", new AttackMonster("Neural Overwrite", 19, 88)},
                {"Nanite Flood", new AttackMonster("Nanite Flood", 17, 90)},
                {"Reverse Protocol", new AttackMonster("Reverse Protocol", 18, 85)},

                {"Molten Gearstorm", new AttackMonster("Molten Gearstorm", 22, 78)},
                {"Auto-Forge Cycle", new AttackMonster("Auto-Forge Cycle", 20, 82)},
                {"Industrial Grasp", new AttackMonster("Industrial Grasp", 21, 80)},

                {"Predictive Laser", new AttackMonster("Predictive Laser", 16, 92)},
                {"Quantum Distortion", new AttackMonster("Quantum Distortion", 18, 88)},
                {"Timeline Shield", new AttackMonster("Timeline Shield", 0, 100)}, // Defensive/Shield Attack

                // Welt 3 Boss-Attacken
                {"Hourfall Blaze", new AttackMonster("Hourfall Blaze", 25, 80)},
                {"Era Shift", new AttackMonster("Era Shift", 0, 100)}, // Buff/Debuff Attack
                {"Clockworld Crush", new AttackMonster("Clockworld Crush", 23, 75)},

                {"Cycle Flare", new AttackMonster("Cycle Flare", 22, 78)},
                {"Solstice Divide", new AttackMonster("Solstice Divide", 0, 100)}, // Debuff
                {"Eclipse Wings", new AttackMonster("Eclipse Wings", 20, 82)},

                {"Void Erasure", new AttackMonster("Void Erasure", 0, 100)}, // Debuff/Status Attack
                {"Null Flare", new AttackMonster("Null Flare", 24, 75)},
                {"Anti-Chron Pulse", new AttackMonster("Anti-Chron Pulse", 23, 78)},
            };
    }

    public static class MonsterDropsLibrary
    {
        public static Dictionary<string, MonsterDrop> MonsterDrops = new()
        {
            // World 1 Drops 

            {"Keiler", new MonsterDrop(50, "Hauer des Keilers", 100, 10 )},
            {"UntoterRitter", new MonsterDrop(150, "Amulett der Untoten", 20, 15)},
            {"MadScientist", new MonsterDrop(80, "Phiole des ewigen Lebens", 15, 12)},
            {"LanzenRitter", new MonsterDrop(80, "Talisman des Ritterordens", 15, 15)},
            {"Waldkobold", new MonsterDrop(40, "Splitter der Koboldmaske", 25, 17)},
            {"Steinkaefer", new MonsterDrop(50, "Panzerfragment des Steinkäfers", 20, 14)},
            {"Dorfschlaeger", new MonsterDrop(30, "Abgenutzter Knüppel", 40, 12)},
            {"Schleimling", new MonsterDrop(25, "Glitschige Essenz", 35, 8)},
            {"Kraehenschwarm", new MonsterDrop(35, "Rabenschwinge", 30, 7)},
            {"Waldgeist", new MonsterDrop(45, "Flüstern der Bäume", 22, 6)},

            // World 2 Drops

            // World 3 Drops

            // Bossdrops

            {"Boss 1", new MonsterDrop(0, "Boss Item Welt 1", 100, 0)},
            {"Boss 2", new MonsterDrop(0, "Boss Item Welt 2", 100, 0)},
            {"Boss 3", new MonsterDrop(0, "Boss Item Welt 3", 100, 0)},
            //Bosse Welt 1
            {"Chrono-Rex", new MonsterDrop(180, "Zerschmetterter Zeitknochen", 100, 90)},
            {"Rift-Mammut", new MonsterDrop(160, "Eiszeitkernsplitter", 100, 120)},
            {"Primal-Hydra", new MonsterDrop(200, "Hydra-Zeitdrüse", 100, 140)},
            //Bosse Welt 2
            {"Motherboard-Matriarchin", new MonsterDrop(220, "Korruptes Nanitenpaket", 100, 110)},
            {"Omega-Forge", new MonsterDrop(240, "Geschmiedeter Kernsplitter", 100, 150)},
            {"Oracle-Unit Z3", new MonsterDrop(210, "Vorhersage-Linsenfragment", 100, 130)},
            //Bosse Welt 3
            {"Aethernox", new MonsterDrop(300, "Splitter der Endlosen Stunde", 100, 200)},
            {"Solaryth", new MonsterDrop(280, "Glühender Sonnenrest", 100, 180)},
            {"Nihilgron", new MonsterDrop(320, "Staub der Nichtzeit", 100, 220)},

        };
    }
}
