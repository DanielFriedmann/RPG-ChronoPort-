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
        public static Monster Feuerkobold()
        {
            return new Monster(
                "Feuerkobold",
                4, 8, 12, 28,
                new List<string> { "Feueratem", "Flammenhieb" },
                MonsterDropsLibrary.MonsterDrops["Feuerkobold"]
            );
        }

        public static Monster Nanoinsekt()
        {
            return new Monster(
                "Nanoinsekt",
                3, 6, 10, 28,
                new List<string> { "Giftbiss", "Nanopeitsche" },
                MonsterDropsLibrary.MonsterDrops["Nanoinsekt"]
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

        public static Monster Schattenkatze()
        {
            return new Monster(
                "Schattenkatze",
                4, 8, 10, 35,
                new List<string> { "Schattenstoß", "Schattensprung" },
                MonsterDropsLibrary.MonsterDrops["Schattenkatze"]
            );
        }

        public static Monster Plasmaelementar()
        {
            return new Monster(
                "Plasmaelementar",
                6, 12, 10, 44,
                new List<string> { "Sternenfeuer", "Feuerexplosion" },
                MonsterDropsLibrary.MonsterDrops["Plasmaelementar"]
            );
        }

        public static Monster Höhlenlöwe()
        {
            return new Monster(
                "Höhlenlöwe",
                4, 8, 10, 36,
                new List<string> { "Zornhieb", "Klauenwirbel" },
                MonsterDropsLibrary.MonsterDrops["Höhlenlöwe"]
            );
        }

        public static Monster Riesenhummel()
        {
            return new Monster(
                "Riesenhummel",
                3, 6, 12, 28,
                new List<string> { "Giftbiss", "Stachelstich" },
                MonsterDropsLibrary.MonsterDrops["Riesenhummel"]
            );
        }

        public static Monster Cyberwolf()
        {
            return new Monster(
                "Cyberwolf",
                5, 10, 9, 36,
                new List<string> { "Griff der Ätherwölfe", "Biss" },
                MonsterDropsLibrary.MonsterDrops["Cyberwolf"]
            );
        }

        public static Monster Eisdämon()
        {
            return new Monster(
                "Eisdämon",
                5, 10, 12, 40,
                new List<string> { "Frostlanze", "Kryostachel" },
                MonsterDropsLibrary.MonsterDrops["Eisdämon"]
            );
        }

        public static Monster Mammut()
        {
            return new Monster(
                "Mammut",
                5, 10, 8, 40,
                new List<string> { "Raserei", "Sturmangriff" },
                MonsterDropsLibrary.MonsterDrops["Mammut"]
            );
        }

        public static Monster Urvogel()
        {
            return new Monster(
                "Urvogel",
                4, 8, 10, 36,
                new List<string> { "Sturmangriff", "Flügelstoß" },
                MonsterDropsLibrary.MonsterDrops["Urvogel"]
            );
        }

        public static Monster Zeitdrache()
        {
            return new Monster(
                "Zeitdrache",
                7, 14, 12, 50,
                new List<string> { "Zeitschlag", "Zeitenbiss" },
                MonsterDropsLibrary.MonsterDrops["Zeitdrache"]
            );
        }

        public static Monster Drohnenwächter()
        {
            return new Monster(
                "Drohnenwächter",
                5, 10, 8, 38,
                new List<string> { "Photonstrahl", "Nanopeitsche" },
                MonsterDropsLibrary.MonsterDrops["Drohnenwächter"]
            );
        }

        public static Monster Berserkerkrokodil()
        {
            return new Monster(
                "Berserkerkrokodil",
                6, 12, 10, 42,
                new List<string> { "Berserkeransturm", "Magenbrecher" },
                MonsterDropsLibrary.MonsterDrops["Berserkerkrokodil"]
            );
        }

        public static Monster Walddryade()
        {
            return new Monster(
                "Walddryade",
                3, 6, 10, 30,
                new List<string> { "Wurzelgriff", "Magisches Zischen" },
                MonsterDropsLibrary.MonsterDrops["Walddryade"]
            );
        }

        public static Monster Schockdrone()
        {
            return new Monster(
                "Schockdrone",
                3, 6, 12, 30,
                new List<string> { "Gravitationsstoß", "Kettenblitz" },
                MonsterDropsLibrary.MonsterDrops["Schockdrone"]
            );
        }

        public static Monster Riesenhandkrabbe()
        {
            return new Monster(
                "Riesenhandkrabbe",
                5, 10, 12, 36,
                new List<string> { "Schockscheren", "Kettenblitz" },
                MonsterDropsLibrary.MonsterDrops["Riesenhandkrabbe"]
            );
        }

        public static Monster Feuersprite()
        {
            return new Monster(
                "Feuersprite",
                4, 8, 12, 32,
                new List<string> { "Flammenhieb", "Feuerexplosion" },
                MonsterDropsLibrary.MonsterDrops["Feuersprite"]
            );
        }

        public static Monster Steingolem()
        {
            return new Monster(
                "Steingolem",
                6, 12, 8, 45,
                new List<string> { "Erdspalter", "Steinschmetter" },
                MonsterDropsLibrary.MonsterDrops["Steingolem"]
            );
        }

        public static Monster Cyberkrabbe()
        {
            return new Monster(
                "Cyberkrabbe",
                5, 10, 12, 36,
                new List<string> { "Schockscheren", "Kettenblitz" },
                MonsterDropsLibrary.MonsterDrops["Cyberkrabbe"]
            );
        }

        public static Monster Phönixjunges()
        {
            return new Monster(
                "Phönixjunges",
                6, 12, 10, 40,
                new List<string> { "Feuerexplosion", "Flammenhieb" },
                MonsterDropsLibrary.MonsterDrops["Phönixjunges"]
            );
        }

        public static Monster Gnommechaniker()
        {
            return new Monster(
                "Gnommechaniker",
                3, 6, 12, 28,
                new List<string> { "Kettenblitz", "Nanopeitsche" },
                MonsterDropsLibrary.MonsterDrops["Gnommechaniker"]
            );
        }

        public static Monster Kristalldrache()
        {
            return new Monster(
                "Kristalldrache",
                7, 14, 12, 48,
                new List<string> { "Arkaneruption", "Sternenfeuer" },
                MonsterDropsLibrary.MonsterDrops["Kristalldrache"]
            );
        }

        public static Monster Eisnymphe()
        {
            return new Monster(
                "Eisnymphe",
                5, 10, 12, 36,
                new List<string> { "Frostlanze", "Kryostachel" },
                MonsterDropsLibrary.MonsterDrops["Eisnymphe"]
            );
        }

        public static Monster Trollkrieger()
        {
            return new Monster(
                "Trollkrieger",
                6, 12, 14, 44,
                new List<string> { "Zornhieb", "Erdspalter" },
                MonsterDropsLibrary.MonsterDrops["Trollkrieger"]
            );
        }

        public static Monster Schattenkobold()
        {
            return new Monster(
                "Schattenkobold",
                4, 8, 10, 30,
                new List<string> { "Schattenstoß", "Schattensprung" },
                MonsterDropsLibrary.MonsterDrops["Schattenkobold"]
            );
        }

        public static Monster Wassergeist()
        {
            return new Monster(
                "Wassergeist",
                5, 10, 12, 36,
                new List<string> { "Seelenbrand", "Astralschlag" },
                MonsterDropsLibrary.MonsterDrops["Wassergeist"]
            );
        }

        public static Monster Drohnenjäger()
        {
            return new Monster(
                "Drohnenjäger",
                4, 8, 10, 34,
                new List<string> { "Photonstrahl", "Laserpeitsche" },
                MonsterDropsLibrary.MonsterDrops["Drohnenjäger"]
            );
        }
        public static Monster Lavakriecher()
        {
            return new Monster(
                "Lavakriecher",
                6, 12, 10, 42,
                new List<string> { "Glutwelle", "Blitzkette" },
                MonsterDropsLibrary.MonsterDrops["Lavakriecher"]
            );
        }

        public static Monster Schattenwurm()
        {
            return new Monster(
                "Schattenwurm",
                7, 14, 12, 50,
                new List<string> { "Verderbnisstoß", "Tentakelpeitsche" },
                MonsterDropsLibrary.MonsterDrops["Schattenwurm"]
            );
        }

        public static Monster Kristallameise()
        {
            return new Monster(
                "Kristallameise",
                3, 6, 10, 30,
                new List<string> { "Knochensplitter", "Giftwolke" },
                MonsterDropsLibrary.MonsterDrops["Kristallameise"]
            );
        }

        public static Monster Frostgolem()
        {
            return new Monster(
                "Frostgolem",
                6, 12, 8, 45,
                new List<string> { "Eislanze", "Frostlanze" },
                MonsterDropsLibrary.MonsterDrops["Frostgolem"]
            );
        }

        public static Monster Pyrosprite()
        {
            return new Monster(
                "Pyrosprite",
                4, 8, 12, 32,
                new List<string> { "Schattenflamme", "Feuerexplosion" },
                MonsterDropsLibrary.MonsterDrops["Pyrosprite"]
            );
        }


    }

    public static class MonsterAttackLibrary
    {
        public static Dictionary<string, AttackMonster> MonsterAttacks = new()
            {
                {"Raserei", new AttackMonster("Raserei", 25, 80)},
                {"Sturmangriff", new AttackMonster("Sturmangriff", 28, 90)},
                {"Feueratem", new AttackMonster("Feueratem", 25, 95)},
                {"Giftbiss", new AttackMonster("Giftbiss", 20, 90)},
                {"Klauenwirbel", new AttackMonster("Klauenwirbel", 10, 95)},
                {"Schattenstoß", new AttackMonster("Schattenstoß", 15, 85)},
                {"Zornhieb", new AttackMonster("Zornhieb", 18, 80)},
                {"Erdspalter", new AttackMonster("Erdspalter", 22, 70)},
                {"Frostlanze", new AttackMonster("Frostlanze", 17, 90)},
                {"Glutwelle", new AttackMonster("Glutwelle", 18, 85)},
                {"Kettenblitz", new AttackMonster("Kettenblitz", 20, 80)},
                {"Arkaneruption", new AttackMonster("Arkaneruption", 23, 75)},
                {"Nebelgriff", new AttackMonster("Nebelgriff", 10, 98)},
                {"Seelenbrand", new AttackMonster("Seelenbrand", 22, 70)},
                {"Astralschlag", new AttackMonster("Astralschlag", 16, 90)},
                {"Geisterklinge", new AttackMonster("Geisterklinge", 14, 93)},
                {"Tentakelpeitsche", new AttackMonster("Tentakelpeitsche", 11, 95)},
                {"Giftwolke", new AttackMonster("Giftwolke", 13, 90)},
                {"Schattenflamme", new AttackMonster("Schattenflamme", 19, 85)},
                {"Knochensplitter", new AttackMonster("Knochensplitter", 15, 90)},
                {"Eislanze", new AttackMonster("Eislanze", 20, 88)},
                {"Photonstrahl", new AttackMonster("Photonstrahl", 25, 80)},
                {"Nanopeitsche", new AttackMonster("Nanopeitsche", 18, 90)},
                {"Griff der Ätherwölfe", new AttackMonster("Griff der Ätherwölfe", 22, 85)},
                {"Flammenhieb", new AttackMonster("Flammenhieb", 20, 87)},
                {"Steinschmetter", new AttackMonster("Steinschmetter", 23, 78)},
                {"Sternenfeuer", new AttackMonster("Sternenfeuer", 24, 75)},
                {"Kryostachel", new AttackMonster("Kryostachel", 18, 85)},
                {"Feuerexplosion", new AttackMonster("Feuerexplosion", 21, 80)},
                {"Schattensprung", new AttackMonster("Schattensprung", 14, 95)},
                {"Gravitationsstoß", new AttackMonster("Gravitationsstoß", 20, 77)},
                {"Zeitschlag", new AttackMonster("Zeitschlag", 22, 80)},
                {"Stachelstich", new AttackMonster("Stachelstich", 16, 85)},
                {"Biss", new AttackMonster("Biss", 18, 90)},
                {"Flügelstoß", new AttackMonster("Flügelstoß", 20, 85)},
                {"Zeitenbiss", new AttackMonster("Zeitenbiss", 25, 80)},
                {"Schockscheren", new AttackMonster("Schockscheren", 22, 80)},
                {"Laserpeitsche", new AttackMonster("Laserpeitsche", 20, 88)},
                {"Berserkeransturm", new AttackMonster("Berserkeransturm", 20, 75)},
                {"Magenbrecher", new AttackMonster("Magenbrecher", 19, 85)},
                {"Wurzelgriff", new AttackMonster("Wurzelgriff", 16, 88)},
                {"Magisches Zischen", new AttackMonster("Magisches Zischen", 17, 90)},
                {"Blitzkette", new AttackMonster("Blitzkette", 19, 82)},
                {"Verderbnisstoß", new AttackMonster("Verderbnisstoß", 21, 75)},  

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
            // Monster Drops
            {"Feuerkobold", new MonsterDrop(40, "Glühende Kohle", 25, 8)},
            {"Nanoinsekt", new MonsterDrop(30, "Nano-Splitter", 20, 5)},
            {"Waldgeist", new MonsterDrop(45, "Flüstern der Bäume", 22, 6)},
            {"Schattenkatze", new MonsterDrop(35, "Schattenschnurrhaare", 18, 7)},
            {"Plasmaelementar", new MonsterDrop(60, "Plasmakristall", 30, 15)},
            {"Höhlenlöwe", new MonsterDrop(50, "Reißzahn", 20, 12)},
            {"Riesenhummel", new MonsterDrop(25, "Giftstachel", 15, 4)},
            {"Cyberwolf", new MonsterDrop(55, "Cyberfaser", 22, 14)},
            {"Eisdämon", new MonsterDrop(50, "Eiskristall", 25, 12)},
            {"Mammut", new MonsterDrop(60, "Froststoß-Stoßzahn", 28, 18)},
            {"Urvogel", new MonsterDrop(40, "Gefieder des Urvogels", 20, 10)},
            {"Zeitdrache", new MonsterDrop(70, "Zeitsplitter", 35, 25)},
            {"Drohnenwächter", new MonsterDrop(45, "Drohnenkern", 22, 9)},
            {"Berserkerkrokodil", new MonsterDrop(55, "Krokodilschuppe", 25, 14)},
            {"Walddryade", new MonsterDrop(35, "Tropfen der Natur", 18, 8)},
            {"Schockdrone", new MonsterDrop(30, "Stromkern", 20, 6)},
            {"Riesenhandkrabbe", new MonsterDrop(50, "Panzerplatte", 25, 12)},
            {"Feuersprite", new MonsterDrop(40, "Funkenstaub", 20, 10)},
            {"Steingolem", new MonsterDrop(60, "Golemstein", 28, 18)},
            {"Cyberkrabbe", new MonsterDrop(50, "Schockschere", 25, 12)},
            {"Phönixjunges", new MonsterDrop(65, "Asche des Phönix", 30, 20)},
            {"Gnommechaniker", new MonsterDrop(35, "Zahnradsplitter", 18, 7)},
            {"Kristalldrache", new MonsterDrop(70, "Kristallherz", 32, 25)},
            {"Eisnymphe", new MonsterDrop(50, "Frostblüte", 25, 14)},
            {"Trollkrieger", new MonsterDrop(60, "Trollhaut", 28, 18)},
            {"Schattenkobold", new MonsterDrop(40, "Dunkelzahn", 20, 10)},
            {"Wassergeist", new MonsterDrop(50, "Wassertropfen-Amulett", 25, 12)},
            {"Drohnenjäger", new MonsterDrop(45, "Laserlinse", 22, 9)},
            {"Nanomech-Golem", new MonsterDrop(55, "Nano-Armatur", 28, 15)},
            {"Glutwyrm", new MonsterDrop(60, "Feuerherz-Schuppe", 30, 18)},
            {"Erdklopper", new MonsterDrop(50, "Steinfaust", 25, 14)},
            {"Schattenläufer", new MonsterDrop(35, "Dunkelfeder", 20, 8)},
            {"Lichtgeist", new MonsterDrop(45, "Aurakristall", 22, 12)},
            {"Lavakriecher", new MonsterDrop(50, "Lavakralle", 10, 14)},
            {"Schattenwurm", new MonsterDrop(70, "Dunkelheitskern", 15, 25)},
            {"Kristallameise", new MonsterDrop(30, "Kristalline Klinge", 20, 6)},
            {"Frostgolem", new MonsterDrop(60, "Eisblock", 28, 18)},
            {"Pyrosprite", new MonsterDrop(40, "Flammenfunken", 20, 10)},
           
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
