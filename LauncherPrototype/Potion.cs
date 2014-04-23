using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherPrototype
{

    public class Potion: Item
    {

        private String potionName;
        private int potionHeal;
        private static readonly byte potionCode = 2;
    
        public Potion(String pName, int heal): base(potionCode)
        {
        
            this.potionName = pName;
            this.potionHeal = heal;
        
        }
    
        public Potion(): base(potionCode)
        {
        
            this.potionName = null;
            this.potionHeal = 0;
        
        }
    
        public void setPotionName(String pName)
        {
        
            this.potionName = pName;
        
        }
    
        public void setPotionHeal(int heal)
        {
        
            this.potionHeal = heal;
        
        }
    
        public String getPotionName()
        {
        
            return this.potionName;
        
        }
    
        public int getPotionHeal()
        {
        
            return this.potionHeal;
        
        }   

    }

}
