namespace RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public override string Attack(int Bonus)
        {
            if(Bonus > 6)
                return this.name + "Magia forte com "+Bonus;
            else
                return this.name + "Magina fraca com "+Bonus;
        }
    }
}