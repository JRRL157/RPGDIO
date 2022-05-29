namespace RPG.src.Entities
{
    public class White_Wizard : Wizard
    {
        public White_Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.name = base.name;
            this.level = base.level;
            this.heroType = base.heroType;
        }

        public string LightVortex(){
            return this.name +" usou um Light Vortex com 1200 de dano";
        }
    }
}