namespace RPG
{
    public static class BattleSystem
    {

        public static void Kampf(BasePlayer player, Monster monster)
        {
            Console.WriteLine($"Kampf gestartet: {player.Name} VS {monster.Name}");

            while (player.Health > 0 && monster.Health > 0)
            {
                PlayerTurn(player, monster);

                if (monster.Health <= 0)
                    break;

                MonsterTurn(player, monster);
            }

            if (player.Health > 0)
            {
                ClearPlayerStatus(player);
                Console.WriteLine($"Du hast  {monster.Name} besiegt!");
                Console.WriteLine($"Du erhältst {monster.Drop.DropXP} Erfahrung und {monster.Drop.Gold} Gold.");
                player.Xp += monster.Drop.DropXP;
                player.Money += monster.Drop.Gold;
                Console.WriteLine($"Du hast jetzt {player.Xp} XP und {player.Money} Gold");

                if (LootChance(monster.Drop))
                {
                    Console.WriteLine($"{monster.Name} hat Loot gedroppt!");
                    Console.WriteLine($"Du erhältst {monster.Drop.DropItem}!");
                }

                Level.LvlUpCheck(player);

            }

            else
                Console.WriteLine("Spieler wurde besiegt..."); // GameOver
        }

        public static void MonsterTurn(BasePlayer player, Monster monster)
        {
            AttackMonster monsterAttack = AttackRandomizer(monster);
            Console.WriteLine($"{monster.Name} greift mit {monsterAttack.AttackName} an.");

            if (DoesHit(monsterAttack.AttackAccuracy, player))
            {
                int damage = 0;

                if (player.Status == "block")
                {
                    damage = monsterAttack.AttackDamage - (player.Defense * 2);
                    player.Status = "normal";
                }

                else
                {
                    damage = monsterAttack.AttackDamage - player.Defense;
                }


                if (damage > 0)
                {
                    player.Health -= damage;
                    Console.WriteLine($"Du hast {damage} Schaden erlitten. HP: {player.Health}");
                }
                else
                {
                    Console.WriteLine("Der Schaden wurde komplett von der Rüstung negiert!");
                }

            }
            else
            {
                Console.WriteLine($"Das Monster hat {monsterAttack.AttackName} verfehlt!");
            }
        }

        public static void PlayerTurn(BasePlayer player, Monster monster)
        {
            string special = "Spezialangriff";
            if (player.HeroAbility != "")
            {
                special = player.HeroAbility;
            }
            if (CheckStatusPlayer(player) == 1) // Stun Check
            {
                Console.WriteLine("Du bist noch stunned! Du kannst diese Runde nicht angreifen!");
                player.Status = "";
            }
            else
            {

                Console.WriteLine($"\n1.Angriff\t\t2.{special}");
                Console.WriteLine("3.Blocken\t\t4.Inventar öffnen");

                int userchoice = InputHelper.GetInt("Wähle eine Aktion aus:", 4);

                switch (userchoice)
                {
                    case 1:
                        NormalAttack(player, monster);
                        break;

                    case 2:
                        if (player.HeroAbility != "")
                        {
                            if (player.SpecialPoints > 0)
                            {
                                SpecialAbility(player, monster);
                            }
                            else
                            {
                                Console.WriteLine($"Du hast keine SpecialPoints mehr! {player.SpecialPoints}/{player.MaxSP} ");
                                Console.WriteLine("Es wird stattdessen ein normaler Angrif ausgeführt!");
                                NormalAttack(player, monster);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Du hast noch keine Special Ability! Stattdessen normaler Angriff.");
                            NormalAttack(player, monster);
                        }
                        break;

                    case 3:
                        PlayerBlock(player);
                        break;

                    case 4:
                        break;

                }
            }
        }

        public static void SpecialAbility(BasePlayer player, Monster monster)
        {

            PlayerSpAtt special = RaceAbility.specialMoves[player.HeroAbility];
            Console.WriteLine($"{player.Name} setzt {player.HeroAbility} ein!");
            if (DoesCrit(special.Crit, player))
            {
                int damage = special.Damage * 2;
                monster.Health -= damage;
                Console.WriteLine("Kritischer Treffer!");
                Console.WriteLine($"{monster.Name} erleidet {damage} Schaden. HP: {monster.Health}");
            }
            else
            {
                int damage = special.Damage;
                monster.Health -= damage;
                Console.WriteLine($"{monster.Name} erleidet {damage} Schaden. HP: {monster.Health}");
            }
            player.Status = special.Status;
            player.SpecialPoints -= 1;
        }


        public static int CheckStatusPlayer(BasePlayer player)
        {
            int status = 0;
            switch (player.Status)
            {
                case "stunned":
                    status = 1;
                    break;
                case "stealth":
                    status = 2;
                    break;
                case "focus":
                    status = 3;
                    break;
                case "":
                    status = 4;
                    break;
            }
            return status;
        }


        public static void PlayerBlock(BasePlayer player)
        {
            Console.WriteLine("Du bist auf den nächsten Angriff gefasst und versuchst zu blocken.");
            player.Status = "block";
        }

        public static void ClearPlayerStatus(BasePlayer player)
        {
            player.Status = "";
        }
        public static void NormalAttack(BasePlayer player, Monster monster)
        {
            Console.WriteLine($"{player.Name} greift {monster.Name} an!");

            if (DoesCrit(player.Crit, player))
            {
                int damage = (player.Attack - monster.Defense) * 2;
                monster.Health -= damage;
                Console.WriteLine($"Kritischer Treffer! Du machst {damage} Schaden! {monster.Name} HP: {monster.Health}");
            }

            else
            {
                int damage = player.Attack - monster.Defense;
                monster.Health -= damage;
                Console.WriteLine($"Du machst {monster.Name} {damage} Schaden! {monster.Name} HP: {monster.Health}");
            }
        }

        public static bool LootChance(MonsterDrop drop)
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
        public static bool DoesCrit(int crit, BasePlayer player)
        {
            Random random = new Random();
            int hit = random.Next(0, 101);

            if (CheckStatusPlayer(player) == 3) //focus check
            {
                crit *= 2;
                player.Status = "";

                if (hit > crit)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (hit > crit)
                {
                    return false;
                }

                else
                {
                    return true;
                }
            }
        }

        public static bool DoesHit(int acc, BasePlayer player)
        {
            Random random = new Random();
            int hit = random.Next(0, 101);

            if (CheckStatusPlayer(player) == 2) //stealth check
            {
                acc -= 20;
                player.Status = "";
                if (hit >= acc)
                {
                    return false;
                }

                else
                {
                    return true;
                }

            }

            else
            {
                if (hit >= acc)
                {
                    return false;
                }

                else
                {
                    return true;
                }
            }

        }

        public static AttackMonster AttackRandomizer(Monster monster)
        {
            Random random = new Random();
            int index = random.Next(0, monster.AttackNames.Count);
            string attackName = monster.AttackNames[index];

            return MonsterAttackLibrary.MonsterAttacks[attackName];
        }
    }

    public static class BossBattle
    {
        public static void BossKampf(BasePlayer player, BossMonster monster)
        {
            Console.WriteLine($"Kampf gestartet: {player.Name} VS {monster.Name}");

            while (player.Health > 0 && monster.Health > 0)
            {
                BossPlayerTurn(player, monster);

                if (monster.Health <= 0)
                    break;

                BossMonsterTurn(player, monster);
            }

            if (player.Health > 0)
            {
                BattleSystem.ClearPlayerStatus(player);
                Console.WriteLine($"Du hast {monster.Name} besiegt!");
                Console.WriteLine($"Du erhältst {monster.Drop2.DropXP} Erfahrung und {monster.Drop2.Gold} Gold.");
                player.Xp += monster.Drop2.DropXP;
                player.Money += monster.Drop2.Gold;
                Console.WriteLine($"Du hast jetzt {player.Xp} XP und {player.Money} Gold");
                Console.WriteLine($"{monster.Name} hat Loot gedroppt!");
                Console.WriteLine($"Du erhältst {monster.Drop1.DropItem} und hast damit 1 von 3 Artefakten um die Welt wieder ins Lot zu bringen!");
                Console.WriteLine($"Du erhältst {monster.Drop2.DropItem}!");
                Level.LvlUpCheck(player);
            }
            else
            {
                Console.WriteLine("Spieler wurde besiegt..."); // GameOver
            }
        }

        public static void BossMonsterTurn(BasePlayer player, BossMonster monster)
        {
            AttackMonster monsterAttack = BossAttackRandomizer(monster);
            Console.WriteLine($"{monster.Name} greift mit {monsterAttack.AttackName} an.");

            if (BattleSystem.DoesHit(monsterAttack.AttackAccuracy, player)) //inkl. stealth check
            {
                int damage = 0;

                if (player.Status == "block")
                {
                    damage = monsterAttack.AttackDamage - (player.Defense * 2);
                    player.Status = "normal";
                }
                else
                {
                    damage = monsterAttack.AttackDamage - player.Defense;
                }

                if (damage > 0)
                {
                    player.Health -= damage;
                    Console.WriteLine($"Du hast {damage} Schaden erlitten. HP: {player.Health}");
                }
                else
                {
                    Console.WriteLine("Der Schaden wurde komplett von der Rüstung negiert!");
                }
            }
            else
            {
                Console.WriteLine($"Das Monster hat {monsterAttack.AttackName} verfehlt!");
            }
        }


        public static void BossPlayerTurn(BasePlayer player, BossMonster monster)
        {
            string special = "Spezialangriff";
            if (!string.IsNullOrEmpty(player.HeroAbility))
            {
                special = player.HeroAbility;
            }
            if (BattleSystem.CheckStatusPlayer(player) == 1) // Stun Check inkludiert
            {
                Console.WriteLine("Du bist noch stunned! Du kannst diese Runde nicht angreifen!");
                player.Status = "";
            }

            else
            {

                Console.WriteLine($"\n1. Angriff\t\t2. {special}");
                Console.WriteLine("3. Blocken\t\t4. Inventar öffnen");

                int userchoice = InputHelper.GetInt("Wähle eine Aktion aus:", 4);

                switch (userchoice)
                {
                    case 1:
                        BossNormalAttack(player, monster);
                        break;
                    case 2:
                        if (player.HeroAbility != "")
                        {
                            if (player.SpecialPoints > 0)
                            {
                                SpecialAbility(player, monster);
                            }
                            else
                            {
                                Console.WriteLine($"Du hast keine SpecialPoints mehr! {player.SpecialPoints}/{player.MaxSP} ");
                                Console.WriteLine("Es wird stattdessen ein normaler Angrif ausgeführt!");
                                BossNormalAttack(player, monster);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Du hast noch keine Special Ability! Stattdessen normaler Angriff.");
                            BossNormalAttack(player, monster);
                        }
                        break;
                    case 3:
                        BattleSystem.PlayerBlock(player);
                        break;
                    case 4:
                        // Inventar öffnen
                        Console.WriteLine("Inventar TBD");
                        break;
                }
            }
        }

        public static void SpecialAbility(BasePlayer player, BossMonster monster)
        {
            PlayerSpAtt special = RaceAbility.specialMoves[player.HeroAbility];
            Console.WriteLine($"{player.Name} setzt {player.HeroAbility} ein!");
            if (BattleSystem.DoesCrit(special.Crit, player))
            {
                int damage = special.Damage * 2;
                monster.Health -= damage;
                Console.WriteLine("Kritischer Treffer!");
                Console.WriteLine($"{monster.Name} erleidet {damage} Schaden. HP: {monster.Health}");
            }
            else
            {
                int damage = special.Damage;
                monster.Health -= damage;
                Console.WriteLine($"{monster.Name} erleidet {damage} Schaden. HP: {monster.Health}");
            }
            player.Status = special.Status;
            player.SpecialPoints -= 1;
        }

        public static void BossNormalAttack(BasePlayer player, BossMonster monster)
        {
            Console.WriteLine($"{player.Name} greift {monster.Name} an!");

            if (BattleSystem.DoesCrit(player.Crit, player)) // focus check inkludiert
            {
                int damage = (player.Attack - monster.Defense) * 2;
                monster.Health -= damage;
                Console.WriteLine($"Kritischer Treffer! Du machst {damage} Schaden! {monster.Name} HP: {monster.Health}");
            }
            else
            {
                int damage = player.Attack - monster.Defense;
                monster.Health -= damage;
                Console.WriteLine($"Du machst {monster.Name} {damage} Schaden! {monster.Name} HP: {monster.Health}");
            }
        }

        public static AttackMonster BossAttackRandomizer(BossMonster boss)
        {
            Random random = new Random();
            int index = random.Next(0, boss.AttackNames.Count);
            string attackName = boss.AttackNames[index];

            return MonsterAttackLibrary.MonsterAttacks[attackName];
        }
    }
}
