using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherPrototype
{

    class BillingAddress
    {

        private String addressLine1;
        private String addressLine2;
        private String city;
        private String state;
        private String county;
        private String country;
        private String continent;
        private UInt32 zipCode;

        public BillingAddress(String addr1, String addr2, String cty, String st, String cnty, String ctry, String ctnt, UInt32 zip)
        {

            this.addressLine1 = addr1;
            this.addressLine2 = addr2;
            this.city = cty;
            this.state = st;
            this.county = cnty;
            this.country = ctry;
            this.continent = ctnt;
            this.zipCode = zip;

        }

        public BillingAddress()
        {

            this.addressLine1 = null;
            this.addressLine2 = null;
            this.city = null;
            this.state = null;
            this.county = null;
            this.country = null;
            this.continent = null;
            this.zipCode = 0;

        }

        public void setAddressLine1(String addr1)
        {

            this.addressLine1 = addr1;

        }

        public void setAddressLine2(String addr2)
        {

            this.addressLine2 = addr2;

        }

        public void setCity(String cty)
        {

            this.city = cty;

        }

        public void setState(String st)
        {

            this.state = st;

        }

        public void setCounty(String cnty)
        {

            this.county = cnty;

        }

        public void setCountry(String ctry)
        {

            this.country = ctry;

        }

        public void setContinent(String ctnt)
        {

            this.continent = ctnt;

        }

        public void setZipCode(UInt32 zip)
        {

            this.zipCode = zip;

        }

        public String getAddressLine1()
        {

            return this.addressLine1;

        }

        public String getAddressLine2()
        {

            return this.addressLine2;

        }

        public String getFullAddress()
        {

            String fullAddress;
            fullAddress = this.addressLine1 + '\n' + this.addressLine2 + '\n' + this.city + ", " + this.state + " " + this.zipCode + '\n' + this.county + " County" + '\n' + this.country + " " + this.continent;
                
            return fullAddress;

        }

        public String getCity()
        {

            return this.city;

        }

        public String getState()
        {

            if (this.state == null)
            {

                return "";

            }

            else
            {

                return this.state;

            }

        }

        public String getCounty()
        {

            if (this.county == null)
            {

                return "";

            }

            else
            {

                return this.county;

            }

        }

        public String getCountry()
        {

             return this.country;

        }

        public String getContinent()
        {

            if (this.continent == null)
            {

                return "";

            }

            else
            {

                return this.continent;

            }

        }

        public UInt32 getZipCode()
        {

            return this.zipCode;

        }

    }

}