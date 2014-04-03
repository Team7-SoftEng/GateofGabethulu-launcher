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
        private readonly String mySQLServer = "originoffear.com";
        private readonly String dbName = "Gabethulu";
        private readonly String uid = "reg";
        private readonly String passwd = "CNu@Bc4102$!";
        private String connectionString;
        private String inputString;

        //Constructor
        public DBClient()
        {

            Initialize();
    
        }

        private void Initialize()
        {

            connectionString = "SERVER=" + mySQLServer + ";" + "DATABASE=" + dbName + ";" + "UID=" + uid + ";" + "PASSWORD=" + passwd + ";" + "SslMode=Required;" + "CertificateFile=server.crt;";
            sqlConn = new MySqlConnection(connectionString);
            sqlComm = new MySqlCommand();
            sqlConn.Open();
            sqlComm.Connection = sqlConn;
        
        }

        private void closeConnection()
        {

            sqlConn.Close();

        }

        public MySqlConnection getSQLConnection()
        {

            return sqlConn;

        }

        private void insertNewAddress(String eMailAddr, String addrLine1, String addrLine2, String cty, String cnty, String st, String cntry, String ctnt, int zip)
        {

            inputString = "INSERT INTO Address (Email_Address,Address_1,Address_2,City,County,State,Country,Continent,Zip_Code) VALUES(\'" + eMailAddr + "\',\'" + addrLine1 + "\',\'" + addrLine2 + "\',\'" + cty + "\',\'" + cnty + "\',\'" + st + "\',\'" + cntry + "\',\'" + ctnt + "'," + zip + ");";
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

        public void insertNewCustomer(String fName, String mName, String lName, String suff, String eMail, String phone, String uName, String passwdHash, char sex, String addr1, String addr2, String city, String county, String state, String country, String continent, int zipCode)
        {

            bool customerSuccessful = false;
            inputString = "INSERT INTO Customer(First_Name,Middle_Name,Last_Name,Suffix,Email_Address,Phone_Number,Username,Passwd_Hash,Gender) VALUES(\'" + fName + "\',\'" + mName + "\',\'" + lName + "\',\'" + suff + "\',\'" + eMail + "\',\'" + phone + "\',\'" + uName + "\',\'" + passwdHash + "\',\'" + sex + "\');";
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
                
            }

            if(customerSuccessful == true)
            {

                insertNewAddress(eMail, addr1, addr2, city, county, state, country, continent, zipCode);
                insertNewPlayer(uName);
                insertNewCharacter(uName);
                insertNewInventory(uName);

            }

            sqlConn.Close();

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

    }

}
