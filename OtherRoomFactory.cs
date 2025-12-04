namespace RPG
{
    public class Shopping
    {
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



    }

    public static class Camping
    {
        public static List<string> randosW1 = new List<string>{
            "Reisender aus Tamriel",
            "Wanderer aus einem fernen Land",
            "Barde aus Westeros"};

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

        public static List<string> randosW2 = new List<string>{
            "Tinker Nova",
            "Schmied Gearlo",
            "Ingenieur Pixel"};

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

        public static List<string> randosW3 = new List<string>{
            "Aethra die Kristallkundige",
            "Krynn der Schattenwanderer",
            "Shadowveil der Runenmeister"
            };

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
}