namespace RPG
{
    public class MonsterRoomFactory
    {
        // Klasse für Monsterraum erstellung inkl Jahr, Raumbeschreibung, Encountertexte
        
        // Welt 1
        public static MonsterRoom A1()
        {
            return new MonsterRoom(MonsterFactory.Feuerkobold(), "157 BC",
                "Du betrittst eine glühende Höhle, in der Funken von der Decke fallen.",
                "Ein leises Knistern wird lauter.",
                "Ein Feuerkobold springt aus dem Schatten!");
        }

        public static MonsterRoom A2()
        {
            return new MonsterRoom(MonsterFactory.Nanoinsekt(), "2134",
                "Du findest dich in einem schimmernden Labor voller Nanomaschinen wieder.",
                "Elektrisches Summen erfüllt die Luft.",
                "Ein Nanoinsekt erscheint!");
        }

        public static MonsterRoom A3()
        {
            return new MonsterRoom(MonsterFactory.Waldgeist(), "1023",
                "Du gehst durch einen alten Hain, die Bäume flüstern im Wind.",
                "Ein unheimliches Säuseln erklingt.",
                "Ein Waldgeist materialisiert sich!");
        }

        public static MonsterRoom A4()
        {
            return new MonsterRoom(MonsterFactory.Schattenkatze(), "198",
                "Du bewegst dich vorsichtig über einen nebligen Waldpfad.",
                "Etwas bewegt sich lautlos.",
                "Eine Schattenkatze springt hervor!");
        }

        public static MonsterRoom A5()
        {
            return new MonsterRoom(MonsterFactory.Plasmaelementar(), "2765",
                "Du betrittst einen futuristischen Energiereaktor mit flackernden Plasmaströmen.",
                "Leuchtende Plasmaströme flackern.",
                "Ein Plasmaelementar tritt hervor!");
        }

        public static MonsterRoom A6()
        {
            return new MonsterRoom(MonsterFactory.Höhlenlöwe(), "312 BC",
                "Du findest dich in einer prähistorischen Höhle wieder.",
                "Das Echo von Schritten hallt.",
                "Ein Höhlenlöwe kommt auf dich zu!");
        }

        public static MonsterRoom A7()
        {
            return new MonsterRoom(MonsterFactory.Riesenhummel(), "1445",
                "Du gehst durch einen blühenden Wald voller Summen und Düfte.",
                "Ein Summen nähert sich.",
                "Eine riesige Hummel erscheint!");
        }

        public static MonsterRoom A8()
        {
            return new MonsterRoom(MonsterFactory.Cyberwolf(), "2352",
                "Du betrittst eine neonbeleuchtete Metropole bei Nacht.",
                "Metallisches Knurren erfüllt die Straßen.",
                "Ein Cyberwolf taucht auf!");
        }

        public static MonsterRoom A9()
        {
            return new MonsterRoom(MonsterFactory.Eisdämon(), "329 BC",
                "Du stehst auf einer gefrorenen Gebirgsspitze.",
                "Eis knirscht unter deinen Füßen.",
                "Ein Eisdämon erhebt sich!");
        }

        public static MonsterRoom A10()
        {
            return new MonsterRoom(MonsterFactory.Mammut(), "3523 BC",
                "Du wanderst über eine eisige Steppe.",
                "Schritte hallen im Schnee.",
                "Ein Mammut erscheint!");
        }

        public static MonsterRoom A11()
        {
            return new MonsterRoom(MonsterFactory.Urvogel(), "1456 BC",
                "Du stehst auf einer Klippe über einem dichten Dschungel.",
                "Flügelschläge hallen laut.",
                "Ein Urvogel stürzt herab!");
        }

        // Welt 2
        public static MonsterRoom B1()
        {
            return new MonsterRoom(MonsterFactory.Zeitdrache(), "3202",
                "Du befindest dich auf einem Plateau voller seltsamer Zeitanomalien.",
                "Ein leises Ticken durchdringt die Luft.",
                "Ein Zeitdrache erscheint!");
        }

        public static MonsterRoom B2()
        {
            return new MonsterRoom(MonsterFactory.Drohnenwächter(), "2085",
                "Du betrittst eine futuristische Fabrikhalle voller Drohnen.",
                "Summen und Lichtblitze überall.",
                "Ein Drohnenwächter greift an!");
        }

        public static MonsterRoom B3()
        {
            return new MonsterRoom(MonsterFactory.Berserkerkrokodil(), "905",
                "Du stehst an einem sumpfigen Flusslauf.",
                "Platschen und knurrende Laute.",
                "Ein Berserkerkrokodil taucht auf!");
        }

        public static MonsterRoom B4()
        {
            return new MonsterRoom(MonsterFactory.Walddryade(), "1865",
                "Du gehst durch einen dichten, uralten Wald.",
                "Leises Rascheln erklingt.",
                "Eine Walddryade erscheint!");
        }

        public static MonsterRoom B5()
        {
            return new MonsterRoom(MonsterFactory.Schockdrone(), "2099",
                "Du findest dich in einer Laborebene voller schwebender Drohnen wieder.",
                "Leise elektrische Impulse knistern.",
                "Eine Schockdrone greift an!");
        }

        public static MonsterRoom B6()
        {
            return new MonsterRoom(MonsterFactory.Riesenhandkrabbe(), "401",
                "Du stehst auf einer felsigen Küste voller Wasserpools.",
                "Wellen schlagen gegen die Felsen.",
                "Eine riesige Handkrabbe kommt hervor!");
        }

        public static MonsterRoom B7()
        {
            return new MonsterRoom(MonsterFactory.Feuersprite(), "1278",
                "Du betrittst einen magischen Wald voller flackernder Lichter.",
                "Ein warmes Knistern liegt in der Luft.",
                "Ein Feuersprite erscheint!");
        }

        public static MonsterRoom B8()
        {
            return new MonsterRoom(MonsterFactory.Steingolem(), "976",
                "Du stehst in einer Steinruine in den Bergen.",
                "Rascheln von Steinen hallt.",
                "Ein Steingolem erhebt sich!");
        }

        public static MonsterRoom B9()
        {
            return new MonsterRoom(MonsterFactory.Cyberkrabbe(), "2187",
                "Du befindest dich in einem futuristischen Hafen mit mechanischen Krabben.",
                "Metallisches Klappern und Surren.",
                "Eine Cyberkrabbe greift an!");
        }

        public static MonsterRoom B10()
        {
            return new MonsterRoom(MonsterFactory.Phönixjunges(), "1256",
                "Du gehst durch einen verzauberten Wald bei Sonnenaufgang.",
                "Das Knistern von Flammen liegt in der Luft.",
                "Ein Phönixjunges erscheint!");
        }

        public static MonsterRoom B11()
        {
            return new MonsterRoom(MonsterFactory.Gnommechaniker(), "2075",
                "Du betrittst eine mechanische Werkstatt voller kleiner Geräte.",
                "Zischende Dampfgeräusche erfüllen den Raum.",
                "Ein Gnommechaniker tritt hervor!");
        }

        // Welt 3
        public static MonsterRoom C1()
        {
            return new MonsterRoom(MonsterFactory.Kristalldrache(), "1526 BC",
                "Du stehst auf einem Kristallberg voller schimmernder Kanten.",
                "Licht reflektiert in alle Richtungen.",
                "Ein Kristalldrache erhebt sich!");
        }

        public static MonsterRoom C2()
        {
            return new MonsterRoom(MonsterFactory.Eisnymphe(), "1995",
                "Du gehst an einem vereisten Wasserfall vorbei.",
                "Leises Knacken von Eis erfüllt die Luft.",
                "Eine Eisnymphe erscheint!");
        }

        public static MonsterRoom C3()
        {
            return new MonsterRoom(MonsterFactory.Trollkrieger(), "765",
                "Du stehst in einem felsigen Tal.",
                "Donnernde Schritte hallen.",
                "Ein Trollkrieger greift an!");
        }

        public static MonsterRoom C4()
        {
            return new MonsterRoom(MonsterFactory.Schattenkobold(), "1788",
                "Du gehst durch einen dunklen Wald voller Schatten.",
                "Kichern ertönt aus allen Richtungen.",
                "Ein Schattenkobold springt hervor!");
        }

        public static MonsterRoom C5()
        {
            return new MonsterRoom(MonsterFactory.Wassergeist(), "1492",
                "Du stehst an einem stillen Teich im Morgendunst.",
                "Sanftes Plätschern umgibt dich.",
                "Ein Wassergeist erscheint!");
        }

        public static MonsterRoom C6()
        {
            return new MonsterRoom(MonsterFactory.Drohnenjäger(), "2278",
                "Du befindest dich über einer Stadt in einer Drohnenzone.",
                "Surrende Geräusche überall.",
                "Ein Drohnenjäger greift an!");
        }

        public static MonsterRoom C7()
        {
            return new MonsterRoom(MonsterFactory.Lavakriecher(), "330 BC",
                "Du betrittst eine prähistorische Höhle.",
                "Das Echo von Schritten hallt.",
                "Ein Lavakriecher kommt auf dich zu!");
        }

        public static MonsterRoom C8()
        {
            return new MonsterRoom(MonsterFactory.Schattenwurm(), "2114 BC",
                "Du wanderst über eine eisige Steppe.",
                "Schritte hallen im Schnee.",
                "Ein Schattenwurm erscheint!");
        }

        public static MonsterRoom C9()
        {
            return new MonsterRoom(MonsterFactory.Kristallameise(), "1124 BC",
                "Du stehst auf einer Klippe über einem dichten Dschungel.",
                "Flügelschläge hallen laut.",
                "Eine Kristallameise stürzt herab!");
        }

        public static MonsterRoom C10()
        {
            return new MonsterRoom(MonsterFactory.Frostgolem(), "2381",
                "Du betrittst eine neonbeleuchtete Metropole bei Nacht.",
                "Metallisches Knurren erfüllt die Straßen.",
                "Ein Frostgolem taucht auf!");
        }

        public static MonsterRoom C11()
        {
            return new MonsterRoom(MonsterFactory.Pyrosprite(), "1301",
                "Du gehst durch einen blühenden Wald voller Summen und Düfte.",
                "Ein Summen nähert sich.",
                "Ein Pyrosprite erscheint!");
        }
    }
}