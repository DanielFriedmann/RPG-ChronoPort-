namespace RPG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.TestEncounter();
        }

        public void TestEncounter()
        {
            BasePlayer held = HeroFactory.CreatePlayer();
            Encounter(held);


        }

        public void Encounter(BasePlayer held)
        {
            List<MonsterRoom> world1 = DungeonGenerator.RandomWorld1(2);

            foreach (MonsterRoom room in world1)
            {
                Console.WriteLine("\nDu schreitest durch das Portal.");
                Console.WriteLine(room.Description);
                Console.WriteLine(room.EncounterDescription1);
                Console.WriteLine(room.EncounterDescription2);
                Thread.Sleep(2000);
                Kampf(room.Monster, held);
                Thread.Sleep(5000);
            }
        }

        public void Kampf(Monster monster, BasePlayer held)
        {

            bool monsterDefeat = false;
            bool heroDefeat = false;

            Console.WriteLine($"{monster.Name} greift {held.Name} an!");

            do
            {
                Thread.Sleep(1000);

                Console.WriteLine($"\n{held.Name} setzt Attacke XY ein! Sie trifft und macht {held.Attack} Schaden");

                if (DoesCrit(held.Crit))
                {
                    int damage = (held.Attack - monster.Defense) * 2;
                    monster.Health -= damage;
                    Console.WriteLine($"Kritischer Treffer! Du machst {damage} Schaden! {monster.Name} HP: {monster.Health}");
                }

                else
                {
                    int damage = held.Attack - monster.Defense;
                    monster.Health -= damage;
                    Console.WriteLine($"Du machst {monster.Name} {damage} Schaden! {monster.Name} HP: {monster.Health}");

                }

                Thread.Sleep(500);

                if (monster.Health > 0)
                {
                    AttackMonster monsterAttack = AttackRandomizer(monster);
                    Console.WriteLine($"{monster.Name} greift mit {monsterAttack.AttackName} an.");

                    if (DoesHit(monsterAttack.AttackAccuracy))
                    {
                        int damage = monsterAttack.AttackDamage - held.Defense;
                        if (damage > 0)
                        {
                            held.Health -= damage;

                            if (held.Health > 0)
                            {
                                Console.WriteLine($"Der Held erleidet {damage} Schaden. Held HP: {held.Health}");
                            }

                            else
                            {
                                Console.WriteLine($"Das {monster.Name} macht {damage} Schaden. Der Held wurde besiegt.");
                                heroDefeat = true;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Der Held blockt den Schaden komplett.");
                        }

                    }

                    else
                    {
                        Console.WriteLine($"Das {monster.Name} hat verfehlt!");
                    }
                }

                else if (monster.Health <= 0)
                {
                    Console.WriteLine($"Du hast das {monster.Name} besiegt!");
                    Console.WriteLine($"Du erhältst {monster.Drop.DropXP} Erfahrung.");
                    if (LootChance(monster.Drop))
                    {
                        Console.WriteLine($"{monster.Name} hat Loot gedroppt!");
                        Console.WriteLine($"Du erhältst {monster.Drop.DropItem}!");
                    }
                    monsterDefeat = true;
                }

            } while (!monsterDefeat && !heroDefeat);

            if (heroDefeat)
            {
                Console.WriteLine("Du bist TOT! GAME OVER!");
            }

        }

        public bool LootChance(MonsterDrop drop)
        {
            Random random = new Random();
            int hit = random.Next(0, 101);

            if (drop.DropChance >= hit)
            {
                return true;
            }

            else
            {
                return false;
            }

        }
        public bool DoesCrit(int crit)
        {
            Random random = new Random();
            int hit = random.Next(0, 101);

            if (hit > crit)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public bool DoesHit(int acc)
        {
            Random random = new Random();
            int hit = random.Next(0, 101);

            if (hit >= acc)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public AttackMonster AttackRandomizer(Monster monster)
        {
            Random random = new Random();
            int index = random.Next(0, monster.AttackNames.Count);
            string attackName = monster.AttackNames[index];

            return MonsterAttackLibrary.MonsterAttacks[attackName];

        }



    }

    public static class InputHelper
    {
        public static string GetValidString(string question)
        {
            string input;

            do
            {
                Console.WriteLine(question);
                input = Console.ReadLine()?.Trim() ?? "";

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Ungültige Eingabe, bitte versuche es erneut!");
                }
            } while (string.IsNullOrEmpty(input));

            return input;
        }
    }





}