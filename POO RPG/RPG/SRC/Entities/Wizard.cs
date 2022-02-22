namespace RPG.SRC.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
        }
       public override string Attack()
       {
       return this.Name + " Liberou Magia";
       }
       public string Attack (int Bonus)
       {
           if (Bonus > 6)
           {
           return this.Name + " Liberou Magia super efetiva com bonus de ataque " + Bonus;
           }
           else
           {
           return this.Name + " Liberou Magia fraca com bonus " + Bonus;
           }
       }
    }
} 

       
        
        
