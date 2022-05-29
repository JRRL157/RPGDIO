using RPG.src.Entities;

namespace RPG{
    class Program{
        public static void Main(string[] args){          
            Knight a = new Knight("Arus",23,"Knight");            
            Wizard jenica = new Wizard("Jen",23,"White Wizard");
            White_Wizard gandolf = new White_Wizard("Gandolf",99999,"The white one!");
            Archer legolas = new Archer("Legolas",200,"Overpower!");

            Console.WriteLine(a.ToString());
            System.Console.WriteLine(jenica.ToString());
            System.Console.WriteLine(jenica.Attack(7));
            System.Console.WriteLine(legolas.Shot(1));
            System.Console.WriteLine(gandolf.LightVortex());
            
        }
    }
}