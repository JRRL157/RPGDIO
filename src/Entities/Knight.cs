namespace RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public override string Attack(int Bonus)
        {
            if(Bonus > 6)
                return this.name + "Ataque forte com "+Bonus;
            else
                return this.name + "Ataqie fraca com "+Bonus;
        }

        public string UltimateDefense(int chance){
            int defesa = chance > 0.6 ? 2000 : chance > 0.2 && chance <= 0.6 ? 1000 : 0;
            return this.name + "Defendeu o ataque com uma defesa de "+defesa;
        }
    }
}