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
        private char gender;
        private int phoneNum;
        private BillingAddress customerAddress;
        private Player customerPlayer;

        public Customer(String fName, String mName, String lName, String suff, String eMail, String uName, String passwd, char sex, int phone, BillingAddress addr, Player cPlayer)
        {

            this.firstName = fName;
            this.middleName = mName;
            this.lastName = lName;
            this.suffix = suff;
            this.eMailAddr = eMail;
            this.userName = uName;
            this.passwdHash = passwd;
            this.gender = sex;
            this.phoneNum = phone;
            this.customerAddress = addr;
            this.customerPlayer = cPlayer;

        }

        public Customer()
        {

            this.firstName = null;
            this.middleName = null;
            this.lastName = null;
            this.suffix = null;
            this.eMailAddr = null;
            this.userName = null;
            this.gender = 'x';
            this.phoneNum = -1;
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

        public void setPhone(int phone)
        {

            this.phoneNum = phone;

        }

        public void setUserName(String uName)
        {

            this.userName = uName;

        }

        public void setPasswdHash(String passwdDigest)
        {

            this.passwdHash = passwdDigest;

        }

        public String getFullName()
        {

            String fullName;
            fullName = this.firstName + " " + this.middleName + " " + this.lastName + ", " + this.suffix;

            return fullName;

        }

        public Player getCustomerPlayer()
        {

            return this.customerPlayer;

        }
 
    }

}
