using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LRCH_Database_Prototype
{
    public partial class FormLRCHPrototype : Form
    {
        public FormLRCHPrototype()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClickViewPatients(object sender, EventArgs e)
        {
            // Clear the list, to prevent patient stacking
            listBoxPatients.Items.Clear();

            // Obtains the textbox info
            string physicianNo = textBoxPhysicianNo.Text;

            // Check if physician's number empty
            if (physicianNo == "")
            {
                MessageBox.Show("Please enter a Physician Number", "Empty Physician Number");
            }
            else
            {
                try
                {

                    // Gets the data source for the connection to the database from the properties settings of the project
                    string connectString = Properties.Settings.Default.Kamrin_ConnectionString;

                    // Creates a new connection to the database
                    SqlConnection cn = new SqlConnection(connectString);

                    // Opens a connection to the database
                    cn.Open();

                    string retrievePatient = "SELECT PATIENT_NO, PATIENT_FIRST_NAME, PATIENT_LAST_NAME FROM PATIENT WHERE PATIENT_PHYSICIAN_NO = " + physicianNo +";";
                    // Creates a new command using the selction query and database connection
                    SqlCommand sqlCommand = new SqlCommand(retrievePatient, cn);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        // While there is "things" to read (reads until end of gathered data from table)
                        while (reader.Read())
                        {
                            // Gets the patient number, first name, and last name for each row
                            int id = Convert.ToInt32(reader[0]);
                            string firstName = reader[1].ToString();
                            string lastName = reader[2].ToString();

                            // Uppercase first letters of first and last name
                            string firstNameLetter = firstName.Substring(0, 1).ToUpper();
                            string lastNameLetter = lastName.Substring(0, 1).ToUpper();

                            // Reformats the first and last name to have an uppercased first letter
                            firstName = firstNameLetter + firstName.Substring(1, firstName.Length - 1);
                            lastName = lastNameLetter + lastName.Substring(1, lastName.Length - 1);

                            // Includes
                            string listItem = id + " - " + firstName + " " + lastName;

                            listBoxPatients.Items.Add(listItem);

                        }
                    }

                    cn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    }
}
