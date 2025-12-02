namespace RPG
{
    public class MonsterRoomFactory
    {
        public static MonsterRoom A1()
        {
            return new MonsterRoom(MonsterFactory.Keiler(),"Welt1", "Ein Keller der etwas verwuchert ist.", 
            "Du hörst ein lautes Trampeln", "Ein wildes Geräusch ertönt hinter dir, du drehst dich um!");
        }

        public static MonsterRoom A2()
        {
            return new MonsterRoom(MonsterFactory.UntoterRitter(),"Welt1", "Vor dir gibt sich ein leerer Thronsaal zu erkennen."
            , "Ein metallisches Klackern nähert sich", "Du siehst im Mondschein eine Rüstung aufblitzen!");
        }

        public static MonsterRoom A3()
        {
            return new MonsterRoom(MonsterFactory.MadScientist(),"Welt1", "Du findest dich in einem leeren Labor wieder",
            "Du hörst ein Schrilles Kichern.", "Ein Reagenzglas fliegt dir entgegen!");
        }
    }
}