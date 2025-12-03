namespace RPG
{
    public class Shopping
    {
        public static Shop CreateShopW1A()
        {
            return new Shop("Händler der fernen Oase",
            "Du findest dich in einer kargen Wüstenlandschaft wieder. Vor dir befindet sich eine Oase. Ein Händler winkt dir auf seinem Kamel zu.",
            new List<string> { "Wüstentinktur", "Sanduhr der Zeit" });
        }

        public static Shop CreateShopW1B()
        {
            return new Shop("Elfenbasar in Trixinia",
            "Du bist in einem wunderschönen Tal mit einem großen Fluss. Nebendran ist ein Marktplatz. Ein Händler ruft dich zu sich!",
            new List<string> { "Elfentrank", "Magischer Ring der Hochelfen" });
        }


        public static Dictionary<string, int> prices = new()
        {
            {"Wüstentinktur", 10},
            {"Sanduhr der Zeit", 25},
            {"Elfentrank", 40},
            {"Magischer Ring der Hochelfen", 35}
        };



    }

    public static class Camping
    {
        public static List<string> randosW1 = new List<string>{
            "Reisender aus Tamriel",
            "Wanderer aus einem fernen Land",
            "Barde aus Westeros"};
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
    }
}