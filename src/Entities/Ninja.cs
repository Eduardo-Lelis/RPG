namespace RPG.src.Entities
{
    public class Ninja : Hero
    {

        public Ninja(string Name,int Level,string HeroType)
        {
            this.Name=Name;
            this.Level=Level;
            this.HeroType=HeroType;
            
        }

            public override string ToString(){
            return this.Name + " " + this.HeroType + " " + this.Level +" has been created";
        }
    }
}