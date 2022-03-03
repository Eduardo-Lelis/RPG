using System;

namespace RPG.src.Entities
{
    public class Wizard : Hero //classe-filha herda da classe-mae Hero
    {
        
       public Wizard(string Name,int Level,string HeroType)
       {
            this.Name=Name;
            this.Level=Level;
            this.HeroType=HeroType;
            
        }
        
    public Wizard(){

    }


    public override string ToString(){
        return this.Name + " " + this.HeroType + " " + this.Level +" has been created";
    }

    public string Attack(int power){
        return this.Name + " has used your magic power" + power;
    }
  



    }
}