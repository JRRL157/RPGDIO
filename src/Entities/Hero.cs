namespace RPG.src.Entities
{
    public abstract class Hero
    {        
        public string name;
        public int level;
        public string heroType;

        public override string ToString()
        {
            return this.name + " " + this.level + " " + this.heroType;
        }
        public abstract string Attack(int Bonus);
    }
}