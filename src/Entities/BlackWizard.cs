using System;

namespace RPG.src.Entities
{
    public class BlackWizard : Hero //classe-filha herda da classe-mae Hero
    {
       public BlackWizard(string Name,int Level,string HeroType)
       {
            this.Name=Name;
            this.Level=Level;
            this.HeroType=HeroType;
            
        }
    public BlackWizard()
    {

    }

    public override string ToString(){
        return this.Name + " " + this.HeroType + " " + this.Level +" has been created";
    }
  



    }
}