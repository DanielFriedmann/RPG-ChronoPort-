using System.Diagnostics.Contracts;

namespace RPG
{
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
                new List<string> {"Zornhieb", "Verwüster"},
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
            {"Waldgeist", new MonsterDrop(45, "Flüstern der Bäume", 22, 6)}

            // World 2 Drops

            // World 3 Drops

            // Bossdrops
        };
    }
}
