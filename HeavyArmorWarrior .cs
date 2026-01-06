namespace pr9_Bartova
{
    public class HeavyArmorWarrior : Warrior
    {
        public HeavyArmorWarrior(string name, int health) : base(name, health) { }

        public override void TakeDamage(int damage)
        {
            int reducedDamage = damage * 50 / 100;
            Health -= reducedDamage;
            if (Health < 0) Health = 0;
        }
    }
}