namespace RPG.src.Entities
{
    public class Rogue : Hero
    {
        public Rogue(string name, int level, string heroType){
            this.name = name;
            this.level =level;
            this.heroType = heroType;
        }
        
        public override string Attack(int Bonus)
        {
            int atk = Bonus > 0.9 ? 10000 : Bonus < 0.9 && Bonus > 0.7 ? 2000 : 0;
            return this.name + "Esfaqueou o oponte com "+atk+" de dado";
        }
    }
}