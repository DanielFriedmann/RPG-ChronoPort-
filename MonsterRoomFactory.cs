namespace RPG
{
    public class MonsterRoomFactory
    {
        public static MonsterRoom A1()
        {
            return new MonsterRoom(MonsterFactory.Keiler(), "Welt1", 
            "Du findest dich wieder in einem Keller der etwas verwuchert ist.",
            "Du hörst ein lautes Trampeln", 
            "Ein wildes Geräusch ertönt hinter dir, du drehst dich um!");
        }

        public static MonsterRoom A2()
        {
            return new MonsterRoom(MonsterFactory.UntoterRitter(), "Welt1", 
            "Vor dir gibt sich ein leerer Thronsaal zu erkennen.", 
            "Ein metallisches Klackern nähert sich", 
            "Du siehst im Mondschein eine Rüstung aufblitzen!");
        }

        public static MonsterRoom A3()
        {
            return new MonsterRoom(MonsterFactory.MadScientist(), "Welt1",
            "Du findest dich in einem leeren Labor wieder",
            "Du hörst ein Schrilles Kichern.", 
            "Ein Reagenzglas fliegt dir entgegen!");
        }

        public static MonsterRoom A4()
        {
            return new MonsterRoom(MonsterFactory.Waldkobold(), "Welt1",
            "Du stolperst in einen dichten Waldpfad, das Moos ist weich unter deinen Füßen.",
            "Ein leises Kichern ertönt aus den Büschen.",
            "Ein kleiner Waldkobold springt heraus und fletscht die Zähne!");
        }


        public static MonsterRoom A5()
        {
            return new MonsterRoom(MonsterFactory.Steinkaefer(), "Welt1",
            "Du landest in einer felsigen Lichtung, überall liegen Steinsplitter herum.",
            "Ein tiefes Knirschen ist zu hören.",
            "Ein massiger Steinkäfer rollt aus einer Felsspalte heraus!");
        }


        public static MonsterRoom A6()
        {
            return new MonsterRoom(MonsterFactory.Dorfschlaeger(), "Welt1",
            "Du findest dich in einem verfallenen Dorfplatz wieder, alte Hütten stehen windschief.",
            "Ein wütendes Grölen ertönt.",
            "Ein betrunkener Dorfschläger schleppt sich auf dich zu!");
        }


        public static MonsterRoom A7()
        {
            return new MonsterRoom(MonsterFactory.Schleimling(), "Welt1",
            "Der Boden unter dir ist weich und glitschig – eine sumpfige Senke.",
            "Ein nasses Platschen ertönt.",
            "Ein blubbernder Schleimling kriecht aus dem Morast!");
        }


        public static MonsterRoom A8()
        {
            return new MonsterRoom(MonsterFactory.Kraehenschwarm(), "Welt1",
            "Du trittst in einen düsteren Feldweg, überall liegen schwarze Federn.",
            "Lautes Krächzen erfüllt die Luft.",
            "Ein ganzer Schwarm Krähen schießt aus den Bäumen hervor!");
        }


        public static MonsterRoom A9()
        {
            return new MonsterRoom(MonsterFactory.Waldgeist(), "Welt1",
            "Du stehst in einem uralten Hain, die Luft ist kühl und voller Flüstern.",
            "Ein sanftes, aber unheimliches Säuseln erklingt.",
            "Ein geisterhafter Waldgeist materialisiert sich vor dir!");
        }

          public static MonsterRoom A10()
        {
            return new MonsterRoom(MonsterFactory.LanzenRitter(), "Welt1",
            "Du stehst in einer belebten Arena, die Stimmung ist aufgeheizt und die Leute schreien.",
            "Du hörst ein immer lauter werdendes Gallopieren.",
            "Plötzlich siehst du ein Ritter mit einer Lanze auf dich zu kommen!");
        }
    }
}