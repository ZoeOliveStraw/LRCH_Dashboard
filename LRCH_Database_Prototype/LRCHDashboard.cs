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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                    // Close the connection
                    cn.Close();

                }
                catch (Exception ex)
                {
                    // Displays error message related to the exception
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (tabControlNavigation.SelectedTab.Text == "Room Utilization")
            {
                DisplayRoomUtilInfo();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisplayRoomUtilInfo()
        {
            try
            {

                // Gets the data source for the connection to the database from the properties settings of the project
                string connectString = Properties.Settings.Default.Kamrin_ConnectionString;

                // Creates a new connection to the database
                SqlConnection cn = new SqlConnection(connectString);

                // Opens a connection to the database
                cn.Open();

                // Rooms Occupied
                string occupiedRoomsQuery = "SELECT COUNT(DISTINCT BED_ROOM) AS ROOMS FROM BED WHERE BED_IS_FILLED = 1;";
                SqlCommand sqlCommand = new SqlCommand(occupiedRoomsQuery, cn);
                int roomsOccupied = Convert.ToInt32(sqlCommand.ExecuteScalar());

                // Private Rooms Occupied
                string occupiedPRoomsQuery = "SELECT COUNT(DISTINCT BED_ROOM) AS ROOMS FROM BED WHERE BED_IS_FILLED = 1 AND BED_ROOM_TYPE = 'PR';";
                SqlCommand sqlCommand2 = new SqlCommand(occupiedPRoomsQuery, cn);
                int pRoomsOccupied = Convert.ToInt32(sqlCommand2.ExecuteScalar());

                // Semiprivate Rooms Occupied
                string occupiedSPRoomsQuery = "SELECT COUNT(DISTINCT BED_ROOM) AS ROOMS FROM BED WHERE BED_IS_FILLED = 1 AND BED_ROOM_TYPE = 'SP';";
                SqlCommand sqlCommand3 = new SqlCommand(occupiedSPRoomsQuery, cn);
                int spRoomsOccupied = Convert.ToInt32(sqlCommand3.ExecuteScalar());

                // Intensive Care Rooms Occupied
                string occupiedICRoomsQuery = "SELECT COUNT(DISTINCT BED_ROOM) AS ROOMS FROM BED WHERE BED_IS_FILLED = 1 AND BED_ROOM_TYPE = 'IC';";
                SqlCommand sqlCommand4 = new SqlCommand(occupiedICRoomsQuery, cn);
                int icRoomsOccupied = Convert.ToInt32(sqlCommand4.ExecuteScalar());

                // Ward 3 Rooms Occupied
                string occupiedW3RoomsQuery = "SELECT COUNT(DISTINCT BED_ROOM) AS ROOMS FROM BED WHERE BED_IS_FILLED = 1 AND BED_ROOM_TYPE = 'W3';";
                SqlCommand sqlCommand5 = new SqlCommand(occupiedW3RoomsQuery, cn);
                int w3RoomsOccupied = Convert.ToInt32(sqlCommand5.ExecuteScalar());

                // Ward 4 Rooms Occupied
                string occupiedW4RoomsQuery = "SELECT COUNT(DISTINCT BED_ROOM) AS ROOMS FROM BED WHERE BED_IS_FILLED = 1 AND BED_ROOM_TYPE = 'W4';";
                SqlCommand sqlCommand6 = new SqlCommand(occupiedW4RoomsQuery, cn);
                int w4RoomsOccupied = Convert.ToInt32(sqlCommand6.ExecuteScalar());

                // Total Private Rooms
                string totalPRoomsQuery = "SELECT COUNT(DISTINCT BED_ROOM) AS ROOMS FROM BED WHERE BED_ROOM_TYPE = 'PR';";
                SqlCommand sqlCommand7 = new SqlCommand(totalPRoomsQuery, cn);
                int totalPRooms = Convert.ToInt32(sqlCommand7.ExecuteScalar());

                // Total Semiprivate Rooms
                string totalSPRoomsQuery = "SELECT COUNT(DISTINCT BED_ROOM) AS ROOMS FROM BED WHERE BED_ROOM_TYPE = 'SP';";
                SqlCommand sqlCommand8 = new SqlCommand(totalSPRoomsQuery, cn);
                int totalSPRooms = Convert.ToInt32(sqlCommand8.ExecuteScalar());

                // Total Intensive Care Rooms
                string totalICRoomsQuery = "SELECT COUNT(DISTINCT BED_ROOM) AS ROOMS FROM BED WHERE BED_ROOM_TYPE = 'IC';";
                SqlCommand sqlCommand9 = new SqlCommand(totalICRoomsQuery, cn);
                int totalICRooms = Convert.ToInt32(sqlCommand9.ExecuteScalar());

                // Total Ward 3 Rooms
                string totalW3RoomsQuery = "SELECT COUNT(DISTINCT BED_ROOM) AS ROOMS FROM BED WHERE BED_ROOM_TYPE = 'W3';";
                SqlCommand sqlCommand10 = new SqlCommand(totalW3RoomsQuery, cn);
                int totalW3Rooms = Convert.ToInt32(sqlCommand10.ExecuteScalar());

                // Total Ward 4 Rooms
                string totalW4RoomsQuery = "SELECT COUNT(DISTINCT BED_ROOM) AS ROOMS FROM BED WHERE BED_ROOM_TYPE = 'W4';";
                SqlCommand sqlCommand11 = new SqlCommand(totalW4RoomsQuery, cn);
                int totalW4Rooms = Convert.ToInt32(sqlCommand11.ExecuteScalar());

                // Beds Occupied
                string occupiedBedsQuery = "SELECT COUNT(BED_ID) FROM BED WHERE BED_IS_FILLED = 1;";
                SqlCommand sqlCommand12 = new SqlCommand(occupiedBedsQuery, cn);
                int bedsOccupied = Convert.ToInt32(sqlCommand12.ExecuteScalar());

                // Obtains the total empty rooms by type
                int totalEmptyPRooms = totalPRooms - pRoomsOccupied;
                int totalEmptySPRooms = totalSPRooms - spRoomsOccupied;
                int totalEmptyICRooms = totalICRooms - icRoomsOccupied;
                int totalEmptyW3Rooms = totalW3Rooms - w3RoomsOccupied;
                int totalEmptyW4Rooms = totalW4Rooms - w4RoomsOccupied;

                // Updates textboxes related to occupied beds and rooms
                textBoxOccByRoom.Text = roomsOccupied.ToString();
                textBoxOccByBed.Text = bedsOccupied.ToString();

                // Updates textboxes related to occupied rooms by room type
                textBoxP.Text = pRoomsOccupied.ToString();
                textBoxSP.Text = spRoomsOccupied.ToString();
                textBoxIC.Text = icRoomsOccupied.ToString();
                textBoxW3.Text = w3RoomsOccupied.ToString();
                textBoxW4.Text = w4RoomsOccupied.ToString();

                // Updates textboxes related to empty rooms by room type
                textBoxPE.Text = totalEmptyPRooms.ToString();
                textBoxSPE.Text = totalEmptySPRooms.ToString();
                textBoxICE.Text = totalEmptyICRooms.ToString();
                textBoxW3E.Text = totalEmptyW3Rooms.ToString();
                textBoxW4E.Text = totalEmptyW4Rooms.ToString();

                // Close connection to the database
                cn.Close();
            }
            catch (Exception ex)
            {
                // Displays error message related to the exception
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlSelected(object sender, TabControlEventArgs e)
        {
            if (tabControlNavigation.SelectedTab.Text == "Room Utilization")
            {
                DisplayRoomUtilInfo();
            }
        }

        private void PatientDoubleClick(object sender, MouseEventArgs e)
        {
            // Checks if a patient is selected
            if (listBoxPatients.SelectedIndex > -1)
            {
                try
                {
                    int id;
                    string firstName = "";
                    string lastName = "";
                    string address = "";
                    string city = "";
                    string province = "";
                    string postalCode = "";
                    string dateAdmit = "";
                    string dateDischared = "";
                    string HCN = "";
                    string sex = "";
                    string pronouns = "";
                    string phone = "";
                    string finance = "";
                    string bed = "";
                    string notes = "";

                    string fullName = "";
                    string location = "";
                    string sAndP = "";

                    // Gets the data source for the connection to the database from the properties settings of the project
                    string connectString = Properties.Settings.Default.Kamrin_ConnectionString;

                    // Creates a new connection to the database
                    SqlConnection cn = new SqlConnection(connectString);

                    // Opens a connection to the database
                    cn.Open();

                    // Gets the patient number from listBoxPatients
                    string patientNo = listBoxPatients.SelectedItem.ToString().Substring(0, 6);

                    string retrievePatient = "SELECT * FROM PATIENT WHERE PATIENT_NO = " + patientNo + ";";
                    // Creates a new command using the selction query and database connection
                    SqlCommand sqlCommand = new SqlCommand(retrievePatient, cn);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        // While there is "things" to read (reads until end of gathered data from table)
                        while (reader.Read())
                        {
                            // Gets the patient number, first name, and last name for each row
                            id = Convert.ToInt32(reader[0]);
                            firstName = reader[1].ToString();
                            lastName = reader[2].ToString();
                            address = reader[3].ToString();
                            city = reader[4].ToString();
                            province = reader[5].ToString();
                            postalCode = reader[6].ToString();
                            dateAdmit = reader[7].ToString();
                            dateDischared = reader[8].ToString();
                            HCN = reader[9].ToString();
                            sex = reader[10].ToString();
                            pronouns = reader[11].ToString();
                            phone = reader[12].ToString();
                            finance = reader[13].ToString();
                            bed = reader[14].ToString();
                            notes = reader[16].ToString();

                            // Uppercase first letters of first and last name
                            string firstNameLetter = firstName.Substring(0, 1).ToUpper();
                            string lastNameLetter = lastName.Substring(0, 1).ToUpper();

                            // Reformats the first and last name to have an uppercased first letter
                            firstName = firstNameLetter + firstName.Substring(1, firstName.Length - 1);
                            lastName = lastNameLetter + lastName.Substring(1, lastName.Length - 1);

                        }
                    }

                    // Concatenates some of the strings
                    fullName = firstName + " " + lastName;
                    location = address + ", " + city + ", " + province + " " + postalCode;
                    sAndP = sex + "/" + pronouns;

                    // Fills the labels
                    labelNameInput.Text = fullName;
                    labelLocInput.Text = location;
                    labelDAInput.Text = dateAdmit;
                    labelDDInput.Text = dateDischared;
                    labelHCNInput.Text = HCN;
                    labelSandPInput.Text = sAndP;
                    labelPhoneInput.Text = phone;
                    labelFinanceInput.Text = finance;
                    labelBedInput.Text = bed;
                    textBoxNotes.Text = notes;

                    // Close the connection
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error with Database");
                }



                labelPatientInfo.Visible = true;
                labelName.Visible = true;
                labelNameInput.Visible = true;
                labelLoc.Visible = true;
                labelLocInput.Visible = true;
                labelDA.Visible = true;
                labelDAInput.Visible = true;
                labelDD.Visible = true;
                labelDDInput.Visible = true;
                labelHCN.Visible = true;
                labelHCNInput.Visible = true;
                labelSandP.Visible = true;
                labelSandPInput.Visible = true;
                labelPhone.Visible = true;
                labelPhoneInput.Visible = true;
                labelFinance.Visible = true;
                labelFinanceInput.Visible = true;
                labelPatientBed.Visible = true;
                labelBedInput.Visible = true;
                labelNotes.Visible = true;
                textBoxNotes.Visible = true;
                buttonNotes.Visible = true;

            }
            // Display error message
            else
            {
                MessageBox.Show("Please Select A Patient", "Patient Not Selected");
            }

        }
    }
}
