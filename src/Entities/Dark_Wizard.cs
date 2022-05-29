namespace RPG.src.Entities
{
    public class Dark_Wizard : Wizard
    {
        public Dark_Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.name = base.name;
            this.level = base.level;
            this.heroType = base.heroType;
        }

        public string DarkVortex(){
            return this.name +" usou um Dark Vortex com 1200 de dano";
        }
        public string Heal(){
            return this.name + "curou 50% da hp do alvo";
        }
    }
}