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

    public class MonsterDrop
    {
        public int DropXP { get; set; }

        public string DropItem { get; set; }

        public int DropChance { get; set; }

        public MonsterDrop(int xp, string item, int chance)
        {
            DropXP = xp;
            DropItem = item;
            DropChance = chance;
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

        public Inventory Inventory { get; set; }

        public BasePlayer(string name, int level, int attack, int defense, int health, int crit, int special, Inventory inv) : base(name, level, attack, defense, health)
        {
            Crit = crit;
            SpecialPoints = special;
            Inventory = inv;
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
}