using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LauncherPrototype
{

    class DBClient
    {

        private MySqlConnection sqlConn;
        private MySqlCommand sqlComm;
        private MySqlDataReader sqlReader;
        private readonly String mySQLServer = "originoffear.com";
        private readonly String dbName = "Gabethulu";
        private readonly String uid = "ssluser";
        private readonly String passwd = "\'S5L@0R1giN89$!\'";
        private String connectionString; 
        private String inputString;

        //Constructor
        public DBClient()
        {

            Initialize();
    
        }

        private void Initialize() 
        {

            this.connectionString = "HOST=" + mySQLServer + ";"
                             + "DATABASE=" + dbName + ";"
                             + "UID=" + uid + ";"
                             + "PASSWORD=" + passwd + ";" 
                             + "SSLMODE=Required;"
                             + "CertificateFile=C:\\Users\\hodgesmb\\Documents\\Visual Studio 2012\\Projects\\LauncherPrototype\\LauncherPrototype\\client.pfx;" + "CertificatePassword=\'\';";

            this.sqlConn = new MySqlConnection(connectionString);
            this.sqlComm = new MySqlCommand();


            try
            {

                sqlConn.Open();
                sqlComm.Connection = sqlConn;

            }
            catch (MySqlException sqle)
            {

                MessageBox.Show("ERROR: Could not connect to database. \n\n Error Message:  " + sqle.Message + "\n\n", "Register Form", MessageBoxButtons.OK);

            }

        }

        public void closeConnection()
        {

            this.sqlConn.Close();

        }

        public bool verifyCredentials(String uName, String cText)
        {

            if (isUserNameAvailable(uName) == true)
            {

                MessageBox.Show("ERROR: User does not exist.", "Gate of Gabethulu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            else
            {

                this.sqlComm.CommandText = "SELECT Passwd_Hash FROM Customer WHERE Username=\'" + uName + "\';";
                String hashStr = this.sqlComm.ExecuteScalar().ToString();

                if (String.Compare(cText, hashStr) == 0)
                {

                    return true;

                }
                else
                {

                    return false;

                }

            }

        }

        public bool isUserNameAvailable(String uName)
        {

            this.sqlComm.CommandText = "SELECT 1 FROM Customer WHERE Username=\'" + uName + "\';";
            sqlReader = sqlComm.ExecuteReader();

            if (sqlReader.Read() == true)
            {

                sqlReader.Close();
                return false;

            }

            else
            {

                sqlReader.Close();
                return true;

            }

        }

        public void changePassword(String uName, String cText)
        {

            this.sqlComm.CommandText = "UPDATE Customer SET Passwd_Hash=\'" + cText + "\' WHERE Username=\'" + uName + "\';";

            try
            {

                this.sqlComm.ExecuteNonQuery();

            }

            catch (MySqlException sqle)
            {

                MessageBox.Show("Error " + sqle.Number + " has occurred: " + sqle.Message + ".", "Registration Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void insertNewAddress(BillingAddress newAddress, String eMail)
        {

            inputString = "INSERT INTO Address (Email_Address,Address_1,Address_2,City,County,State,Country,Continent,Zip_Code) VALUES " +
                "(\'" + eMail + "\',\'" + newAddress.getAddressLine1() + "\',\'" + newAddress.getAddressLine2() +
                "\',\'" + newAddress.getCity() + "\',\'" + newAddress.getCounty() + "\',\'" + newAddress.getState() + "\',\'" + newAddress.getCountry() + "\',\'" + newAddress.getContinent() + "'," + 
                newAddress.getZipCode() + ");";
            sqlComm.CommandText = inputString;

            try
            {

                sqlComm.ExecuteNonQuery();

            }

            catch(MySqlException sqle)
            {

                MessageBox.Show("Error " + sqle.Number + " has occurred: " + sqle.Message + ".", "Registration Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void insertNewPlayer(String uName)
        {

            inputString = "INSERT INTO PlayerStats(Username,Total_Kills,Total_Deaths,Total_Play_Time,Last_Server_Used) VALUES(\'" + uName + "\',0,0,0,\'localhost\');";
            sqlComm.CommandText = inputString;

            try
            {

                sqlComm.ExecuteNonQuery();

            }

            catch (MySqlException sqle)
            {

                MessageBox.Show("Error " + sqle.Number + " has occurred: " + sqle.Message + ".", "Registration Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void insertNewCharacter(String uName)
        {

            inputString = "INSERT INTO CharacterStats(Username,Attack,Defense,Speed,Vitality,EXP) VALUES(\'" + uName + "\',1,1,1,1,0);";
            sqlComm.CommandText = inputString;

            try
            {

                sqlComm.ExecuteNonQuery();

            }

            catch (MySqlException sqle)
            {

                MessageBox.Show("Error " + sqle.Number + " has occurred: " + sqle.Message + ".", "Registration Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void insertNewInventory(String uName)
        {

            inputString = "INSERT INTO Inventory(Username,Item1,Item2,Item3,Item4,Item5) VALUES(\'" + uName + "\',\'Empty\',\'Empty\',\'Empty\',\'Empty\',\'Empty\');";
            sqlComm.CommandText = inputString;

            try
            {

                sqlComm.ExecuteNonQuery();

            }

            catch (MySqlException sqle)
            {

                MessageBox.Show("Error " + sqle.Number + " has occurred: " + sqle.Message + ".", "Registration Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public bool insertNewCustomer(Customer newCustomer, BillingAddress newAddress)
        {

            bool customerSuccessful = false;
            inputString = "INSERT INTO Customer(First_Name,Middle_Name,Last_Name,Suffix,Email_Address,Phone_Number,Username,Passwd_Hash,Gender) " + 
                "VALUES(\'" + newCustomer.getFirstName() + "\',\'" + newCustomer.getMiddleName() + "\',\'" + newCustomer.getLastName() + "\',\'" +
                newCustomer.getSuffix() + "\',\'" + newCustomer.getEmailAddress() + "\',\'" + newCustomer.getPhone() + "\',\'" + newCustomer.getUserName() +
                "\',\'" + "" + "\',\'" + newCustomer.getGender() + "\');";
            sqlComm.CommandText = inputString;

            try
            {

                sqlComm.ExecuteNonQuery();
                customerSuccessful = true;

            }

            catch(MySqlException sqle)
            {

                MessageBox.Show("Error " + sqle.Number + " has occurred: " + sqle.Message + ".", "Registration Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customerSuccessful = false;
                return false;
                
            }

            if(customerSuccessful == true)
            {

                insertNewAddress(newAddress, newCustomer.getEmailAddress());
                insertNewPlayer(newCustomer.getUserName());
                insertNewCharacter(newCustomer.getUserName());
                insertNewInventory(newCustomer.getUserName());
                return true;

            }

            return false;

        }

        public void updatePlayerAttack(String uName, int newAtt)
        {

            inputString = "UPDATE PlayerStats SET Attack =" + newAtt + " WHERE Username = \'" + uName + "\';";
            sqlComm.CommandText = inputString;

            try
            {

                sqlComm.ExecuteNonQuery();

            }

            catch(MySqlException sqle)
            {

                MessageBox.Show("Error " + sqle.Number + " has occurred: " + sqle.Message + ".", "Registration Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void updatePlayerDefense(String uName, int newDef)
        {

            inputString = "UPDATE PlayerStats SET Defense =" + newDef + " WHERE Username = \'" + uName + "\';";
            sqlComm.CommandText = inputString;

            try
            {

                sqlComm.ExecuteNonQuery();

            }

            catch (MySqlException sqle)
            {

                MessageBox.Show("Error " + sqle.Number + " has occurred: " + sqle.Message + ".", "Registration Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void updatePlayerSpeed(String uName, int newSpd)
        {

            inputString = "UPDATE PlayerStats SET Speed =" + newSpd + " WHERE Username = \'" + uName + "\';";
            sqlComm.CommandText = inputString;

            try
            {

                sqlComm.ExecuteNonQuery();

            }

            catch (MySqlException sqle)
            {

                MessageBox.Show("Error " + sqle.Number + " has occurred: " + sqle.Message + ".", "Registration Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void updatePlayerVitality(String uName, int newLfe)
        {

            inputString = "UPDATE PlayerStats SET Vitality =" + newLfe + " WHERE Username = \'" + uName + "\';";
            sqlComm.CommandText = inputString;

            try
            {

                sqlComm.ExecuteNonQuery();

            }

            catch (MySqlException sqle)
            {

                MessageBox.Show("Error " + sqle.Number + " has occurred: " + sqle.Message + ".", "Registration Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void updatePlayerEXP(String uName, int newEXP)
        {

            inputString = "UPDATE PlayerStats SET EXP =" + newEXP + " WHERE Username = \'" + uName + "\';";
            sqlComm.CommandText = inputString;

            try
            {

                sqlComm.ExecuteNonQuery();

            }

            catch (MySqlException sqle)
            {

                MessageBox.Show("Error " + sqle.Number + " has occurred: " + sqle.Message + ".", "Registration Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public String getCustomerFirstName(String uName)
        {

            this.sqlComm.CommandText = "SELECT First_Name FROM Customer WHERE Username=\'" + uName + "\';";
            return this.sqlComm.ExecuteScalar().ToString();

        }

        public String getCustomerMiddleName(String uName)
        {

            this.sqlComm.CommandText = "SELECT Middle_Name FROM Customer WHERE Username=\'" + uName + "\';";
            return this.sqlComm.ExecuteScalar().ToString();

        }

        public String getCustomerLastName(String uName)
        {

            this.sqlComm.CommandText = "SELECT Last_Name FROM Customer WHERE Username=\'" + uName + "\';";
            return this.sqlComm.ExecuteScalar().ToString();

        }

        public String getCustomerSuffix(String uName)
        {

            this.sqlComm.CommandText = "SELECT Suffix FROM Customer WHERE Username=\'" + uName + "\';";
            return this.sqlComm.ExecuteScalar().ToString();

        }

        public char getCustomerGender(String uName)
        {

            this.sqlComm.CommandText = "SELECT Gender FROM Customer WHERE Username=\'" + uName + "\';";
            return this.sqlComm.ExecuteScalar().ToString()[0];

        }

        public String getCustomerEMailAddress(String uName)
        {

            this.sqlComm.CommandText = "SELECT Email_Address FROM Customer WHERE Username=\'" + uName + "\';";
            return sqlComm.ExecuteScalar().ToString();

        }

        public Customer getCustomer(String uName)
        {

            Customer customer = new Customer();
            customer.setFirstName(this.getCustomerFirstName(uName));
            customer.setMiddleName(this.getCustomerMiddleName(uName));
            customer.setLastName(this.getCustomerLastName(uName));
            customer.setSuffix(this.getCustomerSuffix(uName));
            customer.setGender(this.getCustomerGender(uName));
            customer.setEmailAddress(this.getCustomerEMailAddress(uName));
            return customer;

        }

        public Int32 getPlayerTotalKills(String uName)
        {

            this.sqlComm.CommandText = "SELECT Total_Kills FROM PlayerStats WHERE Username=\'" + uName + "\';";
            return Convert.ToInt32(this.sqlComm.ExecuteScalar());

        }

        public Int32 getPlayerTotalDeaths(String uName)
        {

            this.sqlComm.CommandText = "SELECT Total_Deaths FROM PlayerStats WHERE Username=\'" + uName + "\';";
            return Convert.ToInt32(this.sqlComm.ExecuteScalar());

        }

        public String getPlayerTotalPlayTime(String uName)
        {

            this.sqlComm.CommandText = "SELECT Total_Play_Time FROM PlayerStats WHERE Username=\'" + uName + "\';";
            TimeSpan ts = (TimeSpan)this.sqlComm.ExecuteScalar();
            String timeStr = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            return timeStr;

        }

        public String getPlayerLastServerUsed(String uName)
        {

            this.sqlComm.CommandText = "SELECT Last_Server_Used FROM PlayerStats WHERE Username=\'" + uName + "\';";
            return this.sqlComm.ExecuteScalar().ToString();

        }

        public Int32 getPlayerAttack(String uName)
        {

            this.sqlComm.CommandText = "SELECT Attack FROM CharacterStats WHERE Username=\'" + uName + "\';";
            return Convert.ToInt32(this.sqlComm.ExecuteScalar());

        }

        public Int32 getPlayerDefense(String uName)
        {

            this.sqlComm.CommandText = "SELECT Defense FROM CharacterStats WHERE Username=\'" + uName + "\';";
            return Convert.ToInt32(this.sqlComm.ExecuteScalar());

        }

        public Int32 getPlayerSpeed(String uName)
        {

            this.sqlComm.CommandText = "SELECT Speed FROM CharacterStats WHERE Username=\'" + uName + "\';";
            return Convert.ToInt32(this.sqlComm.ExecuteScalar());

        }

        public Int32 getPlayerVitality(String uName)
        {

            this.sqlComm.CommandText = "SELECT Vitality FROM CharacterStats WHERE Username=\'" + uName + "\';";
            return Convert.ToInt32(this.sqlComm.ExecuteScalar());

        }

        public Int32 getPlayerEXP(String uName)
        {

            this.sqlComm.CommandText = "SELECT EXP FROM CharacterStats WHERE Username=\'" + uName + "\';";
            return Convert.ToInt32(this.sqlComm.ExecuteScalar());

        }

        public Player getPlayer(String uName)
        {

            Player player = new Player();
            player.setTotalKills(this.getPlayerTotalKills(uName));
            player.setTotalDeaths(this.getPlayerTotalDeaths(uName));
            player.setTotalPlayTime(this.getPlayerTotalPlayTime(uName));
            player.setLastServerUsed(this.getPlayerLastServerUsed(uName));
            player.setAttack(this.getPlayerAttack(uName));
            player.setDefense(this.getPlayerDefense(uName));
            player.setSpeed(this.getPlayerSpeed(uName));
            player.setVitality(this.getPlayerVitality(uName));
            player.setExp(this.getPlayerEXP(uName));
            return player;

        }

        public String getInventoryItem(String uName, int index)
        {

            this.sqlComm.CommandText = "SELECT Item" + index + " FROM Inventory WHERE Username=\'" + uName + "\';";
            return this.sqlComm.ExecuteScalar().ToString();

        }

        public void deleteAccount(String uName, String eMail)
        {

            Console.WriteLine(uName + "\n");
            Console.WriteLine(eMail + "\n");

            this.sqlComm.CommandText = "DELETE FROM Inventory WHERE Username=\'" + uName + "\';";
            this.sqlComm.ExecuteNonQuery();
            this.sqlComm.CommandText = "DELETE FROM PlayerStats WHERE Username=\'" + uName + "\';";
            this.sqlComm.ExecuteNonQuery();
            this.sqlComm.CommandText = "DELETE FROM CharacterStats WHERE Username=\'" + uName + "\';";
            this.sqlComm.ExecuteNonQuery();
            this.sqlComm.CommandText = "DELETE FROM Address WHERE Email_Address=\'" + eMail + "\';";
            this.sqlComm.ExecuteNonQuery();
            this.sqlComm.CommandText = "DELETE FROM Customer WHERE Username=\'" + uName + "\';";
            this.sqlComm.ExecuteNonQuery();

        }

    }

}
