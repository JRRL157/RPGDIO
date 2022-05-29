namespace RPG.src.Entities
{
    public class Hunter : Rogue
    {
        public Hunter(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.name = base.name;
            this.level = base.level;
            this.heroType = base.heroType;
        }

        public string Stab(int chance){
            return chance > 0.95 ? "Deadly stab" : chance < 0.95 && chance > 0.90 ? "Normal stab" : "Fail!";
        }
    }
}