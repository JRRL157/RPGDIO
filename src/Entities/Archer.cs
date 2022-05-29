namespace RPG.src.Entities
{
    public class Archer : Rogue
    {
        public Archer(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.name = base.name;
            this.level = base.level;
            this.heroType = base.heroType;
        }

        public string Shot(int chance){
            string x  = chance > 0.95 ? "Headshot" : chance < 0.95 && chance > 0.5 ? "Normal shot" : "Weak shot";
            return this.name + "Atacou com um "+x;
        }

    }
}