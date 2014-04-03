using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherPrototype
{

    public class Item
    {
    
        private byte itemTypeCode;
    
    
        public Item(byte typeCode)
        {
        
            this.itemTypeCode = typeCode;
        
        }
    
        public Item()
        {
        
            this.itemTypeCode = 0;
        
        }
    
        public void setTypeCode(byte typeCode)
        {
        
            this.itemTypeCode = typeCode;
        
        }
    
        public byte getTypeCode()
        {
        
            return this.itemTypeCode;
        
        }

    }

}
