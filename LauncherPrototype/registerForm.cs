using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherPrototype
{

    public partial class registerForm : Form
    {

        private DBClient regClient;
        private Crypto cryptSvc;
        private Customer newCustomer;
        private BillingAddress newAddress;
        private bool validated = true;

        public registerForm()
        {

            regClient = new DBClient();
            cryptSvc = new Crypto();
            newCustomer = new Customer();
            newAddress = new BillingAddress();
            InitializeComponent();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

            this.regClient.closeConnection();
            this.Close();

        }

        private void createBtn_Click(object sender, EventArgs e)
        {

           /* Thread validationThread = new Thread(new ThreadStart(verifyAllRequiredFields));

            try
            {

                validationThread.Start();

            }

            catch (ThreadStartException te)
            {

                MessageBox.Show("ERROR: Could not validate user input fields.  Please try again.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }*/

            if(validated == false)
            {

                MessageBox.Show("ERROR: Please check your information and try again.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if(regClient.insertNewCustomer(newCustomer, newAddress))
            {

                MessageBox.Show("New User registration complete!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            regClient.changePassword(newCustomer.getUserName(), cryptSvc.generateSHA512PasswordHash(passwdField.Text));
            regClient.closeConnection();
            this.Close();

        }

        private void firstNameField_TextChanged(object sender, EventArgs e)
        {

            newCustomer.setFirstName(firstNameField.Text);

        }

        private void middleNameField_TextChanged(object sender, EventArgs e)
        {

            newCustomer.setMiddleName(middleNameField.Text);

        }

        private void lastNameField_TextChanged(object sender, EventArgs e)
        {

            newCustomer.setLastName(lastNameField.Text);

        }

        private void suffixField_TextChanged(object sender, EventArgs e)
        {

            newCustomer.setSuffix(suffixField.Text);

        }

        private void eMailAddressField_TextChanged(object sender, EventArgs e)
        {

            if (Regex.IsMatch(eMailAddressField.Text, @"^((([\w]+\.[\w]+)+)|([\w]+))@(([\w]+\.)+)([A-Za-z]{1,3})$", RegexOptions.IgnoreCase) == false)
            {

                this.eMailValidationLbl.Text = "E-Mail Not Valid!";
                this.eMailValidationLbl.ForeColor = Color.Red;
                this.eMailValidationLbl.Visible = true;

            }

            else
            {

                this.eMailValidationLbl.Text = "E-Mail Valid!";
                this.eMailValidationLbl.ForeColor = Color.Lime;
                this.eMailValidationLbl.Visible = true;
                newCustomer.setEmailAddress(eMailAddressField.Text);

            }

        }

        private void passwdField_TextChanged(object sender, EventArgs e)
        {

            comparePasswords(passwdField.Text, reenterPasswdField.Text);

        }

        private void comparePasswords(String passwd1, String passwd2)
        {

            if((String.Compare(passwd1, passwd2) == 0) && (String.Compare(passwd1, "") != 0) && (String.Compare(passwd2, "") != 0))
            {

                passwdMatchLbl.Text = "Passwords Match!";
                passwdMatchLbl.ForeColor = Color.Lime;
                passwdMatchLbl.Visible = true;
                newCustomer.setPasswdHash(cryptSvc.generateSHA512PasswordHash(passwdField.Text));

            }
            
            else
            {

                passwdMatchLbl.Text = "Passwords do not match!";
                passwdMatchLbl.ForeColor = Color.Red;
                passwdMatchLbl.Visible = true;

            }

            if((passwd1.Length > 15) || (passwd2.Length > 15))
            {

                passwdMatchLbl.Text = "Passwords too long!";
                passwdMatchLbl.ForeColor = Color.Red;
                passwdMatchLbl.Visible = true;

            }

            if ((String.Compare(passwd1, "") == 0) || (String.Compare(passwd2, "") == 0))
            {

                passwdMatchLbl.Visible = false;

            }

        }

        private void reenterPasswdField_TextChanged(object sender, EventArgs e)
        {

            comparePasswords(passwdField.Text, reenterPasswdField.Text);

        }

        private void sexSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            newCustomer.setGender(sexSelect.SelectedItem.ToString()[0]);

        }

        private void phoneField_TextChanged(object sender, EventArgs e)
        {

            newCustomer.setPhone(phoneField.Text);

        }

        private void addressField_TextChanged(object sender, EventArgs e)
        {

            newAddress.setAddressLine1(addressField.Text);

        }

        private void streetField_TextChanged(object sender, EventArgs e)
        {

            newAddress.setAddressLine2(streetField.Text);

        }

        private void cityField_TextChanged(object sender, EventArgs e)
        {

            newAddress.setCity(cityField.Text);

        }

        private void stateField_TextChanged(object sender, EventArgs e)
        {

            newAddress.setState(stateField.Text);

        }

        private void countyField_TextChanged(object sender, EventArgs e)
        {

            newAddress.setCounty(countyField.Text);

        }

        private void countryField_TextChanged(object sender, EventArgs e)
        {

            newAddress.setCountry(countryField.Text);

        }

        private void continentField_TextChanged(object sender, EventArgs e)
        {

            newAddress.setContinent(continentField.Text);

        }

        private void zipCodeField_TextChanged(object sender, EventArgs e)
        {

            String zip = zipCodeField.Text.ToString();

            if (zip.Length < 10)
            {

                return;

            }

            else
            {

                zip = zip.Remove(5, 1);
                newAddress.setZipCode(UInt32.Parse(zip));

            }

        }
        private void userNameField_TextChanged(object sender, EventArgs e)
        {

            if (String.Compare(this.userNameField.Text, "") == 0)
            {

                availableNameLbl.Visible = false;

            }

            else if (regClient.isUserNameAvailable(this.userNameField.Text) == false)
            {

                availableNameLbl.Text = "Not available!";
                availableNameLbl.ForeColor = Color.Red;
                availableNameLbl.Visible = true;

            }

            else
            {

                availableNameLbl.Text = "Available!";
                availableNameLbl.ForeColor = Color.Lime;
                availableNameLbl.Visible = true;
                newCustomer.setUserName(userNameField.Text);

            }

        }

       /* private void verifyAllRequiredFields()
        {

            if((this.newCustomer.getFirstName() == null) || (this.newCustomer.getFirstName() == ""))
            {

                validated = false;

            }

            else if((this.newCustomer.getMiddleName() == null) || (this.newCustomer.getMiddleName() == ""))
            {

                validated = false;

            }

            else if((this.newCustomer.getLastName() == null) || (this.newCustomer.getLastName() == ""))
            {

                validated = false;

            }

            else if((this.newCustomer.getPhone() == null) || (this.newCustomer.getPhone() == ""))
            {

                validated = false;

            }

            else if((this.newCustomer.getAddress().getAddressLine1() == null) || (this.newCustomer.getAddress.getAddressLine1() == ""))
            {

                validated = false;

            }

            else if((this.newCustomer.getAddress().getAddressLine2() == null) || (this.newCustomer.getAddress().getAddressLine2() == ""))
            {

                validated = false;

            }

            else if((this.newCustomer.getAddress().getCity() == null) || (this.newCustomer.getAddress().getCity() == ""))
            {

                validated = false;

            }

            else if((this.newCustomer.getAddress().getCountry() == null) || (this.newCustomer.getAddress().getCountry() == ""))
            {

                validated = false;

            }

            else if(this.newCustomer.getAddress().getZipCode() == 0)
            {

                validated = false;

            }

            else
            {

                validated = true;

            }

        }*/

    }

}