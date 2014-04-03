using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherPrototype
{

    class KeyItem: Item
    {

        private String keyItemName;
        private String keyItemPurpose;
        private static readonly byte keyItemCode = 3;
    
        public KeyItem(String kName, String purpose): base(keyItemCode)
        {
        
            this.keyItemName = kName;
            this.keyItemPurpose = purpose;
        
        }
    
        public KeyItem(): base(keyItemCode)
        {
        
            this.keyItemName = null;
            this.keyItemPurpose = null;
        
        }
    
        public void setKeyItemName(String kName)
        {
        
            this.keyItemName = kName;
        
        }
    
        public void setKeyItemPurpose(String purpose)
        {
        
            this.keyItemPurpose = purpose;
        
        }
    
        public String getKeyItemName()
        {
        
            return this.keyItemName;
        
        }
    
        public String getKeyItemPurpose()
        {
        
            return this.keyItemPurpose;
        
        }

    }

}
