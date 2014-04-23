using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherPrototype
{

    public class Weapon: Item
    {
    
        private String weaponName;
        private int weaponAttack;
        private static readonly byte weaponCode = 1;
    
        public Weapon(String wName, int wAtt): base(weaponCode)
        {
       
            this.weaponName = wName;
            this.weaponAttack = wAtt;
        
        }
    
        public Weapon(): base(weaponCode)
        {
        
            this.weaponName = null;
            this.weaponAttack = 0;
        
        }
    
        public void setItemName(String wName)
        {
        
            this.weaponName = wName;
        
        }
    
        public void setItemAttack(int att)
        {
        
            this.weaponAttack = att;
        
        }
    
        public String getItemName()
        {
        
            return this.weaponName;
        
        }
    
        public int getItemAttack()
        {
        
            return this.weaponAttack;
    
        }   

    }

}
