namespace pr9_Bartova
{
    public class LightArmorWarrior : Warrior
    {
        public LightArmorWarrior(string name, int health) : base(name, health) { }

        public override void TakeDamage(int damage)
        {
            int reducedDamage = damage * 70 / 100;
            Health -= reducedDamage;
            if (Health < 0) Health = 0;
        }
    }
}