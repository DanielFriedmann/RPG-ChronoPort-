namespace RPG
{
    public class Creature
    {
        public string Name { get; set; }

        public int Level { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public int Health { get; set; }

        public Creature(string name, int level, int attack, int defense, int health)
        {
            Name = name;
            Level = level;
            Attack = attack;
            Defense = defense;
            Health = health;
        }


    }

    public class Monster : Creature
    {
        public List<string> AttackNames { get; set; }

        public MonsterDrop Drop { get; set; }

        public Monster(string name, int level, int attack, int defense, int health, List<string> attacks, MonsterDrop drop) : base(name, level, attack, defense, health)
        {
            AttackNames = attacks;
            Drop = drop;
        }

    }

    public class BossMonster : Creature
    {
        public List<string> AttackNames { get; set; }

        public MonsterDrop Drop1 { get; set; }

        public MonsterDrop Drop2 { get; set; }

        public string Encountertext {get; set;}

        public string Defeattext {get; set;}

        public BossMonster(string name, int level, int attack, int defense, int health, List<string> attackname, MonsterDrop drop1, MonsterDrop drop2, string encounter, string defeat) 
        : base(name, level, attack, defense, health)
        {
            AttackNames = attackname;
            Drop1 = drop1;
            Drop2 = drop2;
            Encountertext = encounter;
            Defeattext = defeat;            
        }
    }

    public class MonsterDrop
    {
        public int DropXP { get; set; }

        public string DropItem { get; set; }

        public int DropChance { get; set; }

        public int Gold { get; set; }

        public MonsterDrop(int xp, string item, int chance, int gold)
        {
            DropXP = xp;
            DropItem = item;
            DropChance = chance;
            Gold = gold;
        }

    }

    public class Items
    {
        public string Name { get; set; }

        public int ID { get; set; }

        public int Value { get; set; }

        public Items(string name, int id, int value)
        {
            Name = name;
            ID = id;
            Value = value;
        }


    }

    public class AttackMonster
    {
        public string AttackName { get; set; }

        public int AttackDamage { get; set; }

        public int AttackAccuracy { get; set; }


        public AttackMonster(string name, int damage, int accuracy)
        {
            AttackName = name;
            AttackDamage = damage;
            AttackAccuracy = accuracy;
        }
    }

    public class BasePlayer : Creature
    {
        public int Crit { get; set; }

        public int SpecialPoints { get; set; }

        public int Xp { get; set; }

        public int MaxHP { get; set; }

        public int MaxSP { get; set; }

        public string HeroAbility { get; set; }

        public string Status { get; set; }

        public int Money { get; set; }

        public string Race { get; set; }

        public Inventory Inventory { get; set; }

        public BasePlayer(string name, int level, int xp, int maxhp, int attack, int defense,
                             int health, int crit, int special, int maxsp,
                              Inventory inv, string race, string heroability, int money = 0, string status = "normal")
                             : base(name, level, attack, defense, health)
        {
            Xp = xp;
            MaxHP = maxhp;
            Crit = crit;
            SpecialPoints = special;
            MaxSP = maxsp;
            Inventory = inv;
            Money = money;
            Race = race;
            HeroAbility = heroability;
            Status = status;
        }
    }

    public class Inventory
    {
        public List<string> ItemsInventory { get; set; } = new List<string>();

        public Inventory(List<string> items)
        {
            ItemsInventory = items;
        }
    }

    public class PlayerSpAtt
    {
        public string Name { get; set; }

        public int Damage { get; set; }

        public int Crit { get; set; }

        public string Status { get; set; }

        public PlayerSpAtt(string name, int damage, int crit, string status = "")
        {
            Name = name;
            Damage = damage;
            Crit = crit;
            Status = status;
        }

    }

    public class NPC
    {
        public string Name { get; set; }

        public string WelcomeText { get; set; }
        
        public string ByeText { get; set; }

        public Action<BasePlayer> Encounter { get; set; }

        public NPC(string name,  string welcome, string bye, Action<BasePlayer> encounter)
        {
            Name = name;
            WelcomeText = welcome;
            ByeText = bye;
            Encounter = encounter;
        }
        
    }
}