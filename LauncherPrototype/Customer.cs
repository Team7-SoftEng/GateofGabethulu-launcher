using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherPrototype
{

    class Customer
    {

        private String firstName;
        private String middleName;
        private String lastName;
        private String suffix;
        private String eMailAddr;
        private String userName;
        private String passwdHash;
        private String phoneNum;
        private char gender;
        private BillingAddress customerAddress;
        private Player customerPlayer;

        public Customer()
        {

            this.firstName = null;
            this.middleName = null;
            this.lastName = null;
            this.suffix = null;
            this.eMailAddr = null;
            this.userName = null;
            this.gender = 'x';
            this.phoneNum = "-1";
            this.customerAddress = null;
            this.customerPlayer = null;

        }

        public void setFirstName(String fName)
        {
            
            this.firstName = fName;

        }

        public void setMiddleName(String mName)
        {

            this.middleName = mName;

        }

        public void setLastName(String lName)
        {

            this.lastName = lName;

        }

        public void setSuffix(String suff)
        {

            this.suffix = suff;

        }

        public void setEmailAddress(String eMail)
        {

            this.eMailAddr = eMail;

        }

        public void setGender(char sex)
        {

            this.gender = sex;

        }

        public void setPhone(String phone) { this.phoneNum = phone; }

        public bool setUserName(String uName)
        {

            this.userName = uName;

            return true;

        }

        public void setPasswdHash(String passwdDigest)
        {

            this.passwdHash = passwdDigest;

        }

        public void setAddress(BillingAddress inputAddress)
        {

            this.customerAddress = inputAddress;

        }

        public void setCustomerPlayer(Player inputPlayer)
        {

            this.customerPlayer = inputPlayer;

        }

        public char getGender()
        {

            return this.gender;

        }

        public String getFirstName()
        {

            return this.firstName;

        }

        public String getMiddleName()
        {

            return this.middleName;

        }

        public String getLastName()
        {

            return this.lastName;

        }

        public String getFullName()
        {

            String fullName;
            fullName = this.firstName + " " + this.middleName + " " + this.lastName + ", " + this.suffix;

            return fullName;

        }
        
        public String getUserName()
        {

            return this.userName;

        }

        public String getSuffix()
        {

            return this.suffix;

        }

        public String getEmailAddress()
        {

            return this.eMailAddr;

        }

        public String getPhone()
        {

            return this.phoneNum;

        }

        public BillingAddress getAddress()
        {

            return this.customerAddress;

        }

        public Player getCustomerPlayer()
        {

            return this.customerPlayer;

        }
 
    }

}
