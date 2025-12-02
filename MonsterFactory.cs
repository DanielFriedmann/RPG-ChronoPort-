using System.Diagnostics.Contracts;

namespace RPG
{

    public static class MonsterFactory
    {
        public static Monster Keiler()
        {
            return new Monster(
                "Keiler des Totwaldes",
                 4, 10, 15, 50,
                 new List<string> { "Raserei", "Sturmangriff" },
                 MonsterDropsLibrary.MonsterDrops["Keiler"]
                 );
        }

        public static Monster UntoterRitter()
        {
            return new Monster(
                "Untoter Ritter der Tafel",
                 4, 10, 15, 55,
                 new List<string> { "Dolchstoß", "Sturmangriff" },
                 MonsterDropsLibrary.MonsterDrops["UntoterRitter"]
                 );
        }

        public static Monster MadScientist()
        {
            return new Monster(
                "Verrückter Wissenschaftler",
                 4, 10, 15, 55,
                 new List<string> { "Feueratem", "Giftbiss" },
                 MonsterDropsLibrary.MonsterDrops["MadScientist"]
                 );
        }
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
            {"Keiler", new MonsterDrop(50, "Hauer des Keilers", 100 )},
            {"UntoterRitter", new MonsterDrop(150, "Amulett der Untoten", 20)},
            {"MadScientist", new MonsterDrop(80, "Phiole des ewigen Lebens", 15)}
        };
    }
}