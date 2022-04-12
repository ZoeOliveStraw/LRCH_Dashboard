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
        /// Handles the View Patients button event when it's clicked
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
                // Displays error message
                MessageBox.Show("Please enter a Physician Number", "Empty Physician Number");
            }
            // User has enter something
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

                            // Includes id and full name for each list item
                            string listItem = id + " - " + firstName + " " + lastName;

                            // Adds the patient to the listbox
                            listBoxPatients.Items.Add(listItem);

                        }
                    }

                    // Checks if the physician has no patients
                    if (listBoxPatients.Items.Count == 0)
                    {
                        // Displays message
                        MessageBox.Show("No Patients Assigned to Physician", "No Patients");
                    }

                    // Close the connection
                    cn.Close();

                    // Hides the patient info labels, just incase they are visible
                    PatientInfoVisibility(false);

                }
                catch (Exception ex)
                {
                    // Displays error message related to the exception
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        /// <summary>
        /// Handles the event for when the application is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Checks if the tab is Room Utilization
            if (tabControlNavigation.SelectedTab.Text == "Room Utilization")
            {
                // Displays Room Util Information
                DisplayRoomUtilInfo();
            }
        }

        /// <summary>
        /// Handles the querying of the database to display all bed information.
        /// Including a data table and general information related to the bed's table
        /// in the database.
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

                // Gets all bed information and uses aliases (For the datatable)
                string selectAllBeds = "SELECT BED_ID AS 'Bed ID', BED_ROOM AS 'Room', BED_BED AS 'Position', " +
                    "BED_EXTENSION AS 'Extension', BED_ROOM_TYPE AS 'Room Type', BED_IS_FILLED AS 'Is Occupied?' FROM BED;";
                // Creates a new sql command
                SqlCommand allCommand = new SqlCommand(selectAllBeds, cn);
                // Need a SQL Data adapter in order to capture all the information (the whole table)
                SqlDataAdapter sda = new SqlDataAdapter(allCommand);
                // Create the dataTable
                DataTable dataTable = new DataTable();
                // Fill the dataTable
                sda.Fill(dataTable);
                // Sets the data grid's data source
                dataGridViewBeds.DataSource = dataTable;

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

                // Total Beds
                string totalBedsQuery = "SELECT COUNT(BED_ID) FROM BED;";
                SqlCommand sqlCommmand13 = new SqlCommand(totalBedsQuery, cn);
                int totalBeds = Convert.ToInt32(sqlCommmand13.ExecuteScalar());

                // Number of beds Discharging
                string dischargingBedsQuery = "SELECT COUNT(PATIENT_NO) FROM PATIENT WHERE PATIENT_DATE_DISCHARGED BETWEEN '" +
                    DateTime.Today.ToString() + "' AND '" + DateTime.Today.AddDays(1).AddSeconds(-1).ToString() + "';";
                SqlCommand sqlCommmand14 = new SqlCommand(dischargingBedsQuery, cn);
                int dischargedBeds = Convert.ToInt32(sqlCommmand14.ExecuteScalar());

                // Obtains the total empty rooms by type
                int totalEmptyPRooms = totalPRooms - pRoomsOccupied;
                int totalEmptySPRooms = totalSPRooms - spRoomsOccupied;
                int totalEmptyICRooms = totalICRooms - icRoomsOccupied;
                int totalEmptyW3Rooms = totalW3Rooms - w3RoomsOccupied;
                int totalEmptyW4Rooms = totalW4Rooms - w4RoomsOccupied;

                // Calculates the total number of rooms
                int totalRooms = totalPRooms + totalSPRooms + totalICRooms + totalW3Rooms + totalW4Rooms;

                // Updates textboxes related to occupied beds, rooms, and number of beds discharged in that day
                labelOccByRoom.Text = roomsOccupied.ToString() + "/" + totalRooms.ToString();
                labelOccByBed.Text = bedsOccupied.ToString() + "/" + totalBeds.ToString();
                labelBedDischarging.Text = dischargedBeds.ToString() + "/" + totalBeds.ToString();

                // Updates textboxes related to occupied rooms by room type
                labelPInput.Text = pRoomsOccupied.ToString() + "/" + totalPRooms.ToString();
                labelSPInput.Text = spRoomsOccupied.ToString() + "/" + totalSPRooms.ToString();
                labelICInput.Text = icRoomsOccupied.ToString() + "/" + totalICRooms.ToString();
                labelW3Input.Text = w3RoomsOccupied.ToString() + "/" + totalW3Rooms.ToString();
                labelW4Input.Text = w4RoomsOccupied.ToString() + "/" + totalW4Rooms.ToString();

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
        /// Handles event handling when a new tab is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlSelected(object sender, TabControlEventArgs e)
        {
            // Checks if the tab is Room Utilization
            if (tabControlNavigation.SelectedTab.Text == "Room Utilization")
            {
                // Displays Room Utilization Information
                DisplayRoomUtilInfo();
            }
        }

        /// <summary>
        /// Handles the event When a patient is double clicked on the Physician-Patient tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatientDoubleClick(object sender, MouseEventArgs e)
        {
            // Checks if a patient is selected
            if (listBoxPatients.SelectedIndex > -1)
            {
                try
                {
                    // Declare and Initialize required variables for the SqlDataReader
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

                    // Concatenation string variables, used for displaying patient info
                    string fullName = "";
                    string location = "";
                    string sAndP = "";

                    // Gets the data source for the connection to the database from the properties settings of the project
                    string connectString = Properties.Settings.Default.Kamrin_ConnectionString;

                    // Creates a new connection to the database
                    SqlConnection cn = new SqlConnection(connectString);

                    // Opens a connection to the database
                    cn.Open();

                    // Gets the patient number from listBoxPatients items, using the selected item and substringing
                    string patientNo = listBoxPatients.SelectedItem.ToString().Substring(0, 6);

                    string retrievePatient = "SELECT * FROM PATIENT WHERE PATIENT_NO = '" + patientNo + "';";
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

                // Shows the patient info labels, just incase they are invisible
                PatientInfoVisibility(true);

            }
            // Display error message
            else
            {
                MessageBox.Show("Please Select A Patient", "Patient Not Selected");
            }

        }

        /// <summary>
        /// Handles the click event when the submit button is pressed for Additional Notes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitNotesClick(object sender, EventArgs e)
        {
            try
            {
                // Gets the patient number from listBoxPatients
                string patientNo = listBoxPatients.SelectedItem.ToString().Substring(0, 6);
                string notes = textBoxNotes.Text.Trim();
                string updateQuery = "UPDATE PATIENT SET PATIENT_ADDITIONAL_NOTES = '" + notes + "' WHERE PATIENT_NO = '" + patientNo + "';";

                // Gets the data source for the connection to the database from the properties settings of the project
                string connectString = Properties.Settings.Default.Kamrin_ConnectionString;

                // Creates a new connection to the database
                SqlConnection cn = new SqlConnection(connectString);

                // Opens a connection to the database
                cn.Open();

                // Execute the update statement, which adds the additional notes to patient table
                SqlCommand command = new SqlCommand(updateQuery, cn);
                command.ExecuteScalar();

                // Display message
                MessageBox.Show("Patient Notes Updated Successfully", "Additional Notes");

                // Refresh the patient info using the Patient double click event
                PatientDoubleClick(sender, (MouseEventArgs)e);

            }
            // Catch any exception that may occur
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show(ex.Message, "Error with Database");
            }
            
        }

        /// <summary>
        /// Handles the visibility for patient info
        /// </summary>
        /// <param name="isVisible">boolean, either false or true</param>
        private void PatientInfoVisibility(bool isVisible)
        {
            // Visibilty settings for patient info
            labelPatientInfo.Visible = isVisible;
            labelName.Visible = isVisible;
            labelNameInput.Visible = isVisible;
            labelLoc.Visible = isVisible;
            labelLocInput.Visible = isVisible;
            labelDA.Visible = isVisible;
            labelDAInput.Visible = isVisible;
            labelDD.Visible = isVisible;
            labelDDInput.Visible = isVisible;
            labelHCN.Visible = isVisible;
            labelHCNInput.Visible = isVisible;
            labelSandP.Visible = isVisible;
            labelSandPInput.Visible = isVisible;
            labelPhone.Visible = isVisible;
            labelPhoneInput.Visible = isVisible;
            labelFinance.Visible = isVisible;
            labelFinanceInput.Visible = isVisible;
            labelPatientBed.Visible = isVisible;
            labelBedInput.Visible = isVisible;
            labelNotes.Visible = isVisible;
            textBoxNotes.Visible = isVisible;
            buttonNotes.Visible = isVisible;
        }
    }
}
