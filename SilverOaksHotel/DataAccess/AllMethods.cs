using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccess
{

    public class AllMethods
    {
        private static SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DBSilverOaksHotel.mdf;Integrated Security=True");//public static SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\salim\\OneDrive\\Documents\\GitHub\\github-cmpg223-project\\SilverOaksHotel\\DataAccess\\DBSilverOaksHotel.mdf;Integrated Security=True");
        private static SqlCommand command;
        private static SqlDataAdapter dataAdapter;
        private static SqlDataReader dataReader;
        private static DataSet ds;

        public static string UserFullName { get; set; }
        public static string UserUsername { get; set; }
        public static int UserID { get; set; }

       //GENERIC CRUD METHOD
        public static void CrudOperations(char crud, string sql, DataGridView dgv)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                ds = new DataSet();
                
                command = new SqlCommand(sql, con);
                dataAdapter = new SqlDataAdapter();

                switch (crud)
                {
                    case 'C':
                        {
                            dataAdapter.InsertCommand = command;
                            dataAdapter.InsertCommand.ExecuteNonQuery();

                            break;
                        }

                    case 'R':
                        {
                            dataAdapter.SelectCommand = command;

                            dataAdapter.Fill(ds, "SourceTable");
                            dgv.DataSource = ds;
                            dgv.DataMember = "SourceTable";
                            break;

                        }

                    case 'U':
                        {
                            command = new SqlCommand(sql, con);
                            dataAdapter.UpdateCommand = command;
                            dataAdapter.UpdateCommand.ExecuteNonQuery();

                            break;
                        }

                    case 'D':
                        {
                            dataAdapter.DeleteCommand = command;
                            dataAdapter.DeleteCommand.ExecuteNonQuery();

                            break;
                        }

                    default:
                        {
                            MessageBox.Show("No CRUD character identified! Please contact your software solutions provider.", "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;
                        }
                }
                
                command.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please contact your software solutions provider.\n" + ex.Message, "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //GET DATETIME
        public static DateTime GetDateTime()
        {
            DateTime now = DateTime.Now;
            now.ToLocalTime();
            string completeDateTime = now.ToShortDateString() + " " + now.ToLongTimeString();
            return Convert.ToDateTime(completeDateTime);
        }

        //VALIDATE LOGIN needs work
        public static bool LoginValidation(string username, string password)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string sql = $"SELECT * FROM Employee";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    if (username == dataReader.GetValue(7).ToString())
                    {

                        if (password == dataReader.GetValue(8).ToString())
                        {
                            UserID = Convert.ToInt32(dataReader.GetValue(0));
                            UserFullName = dataReader.GetValue(1).ToString() + ", " + (dataReader.GetValue(2).ToString())[0];
                            UserUsername = dataReader.GetValue(7).ToString();
                            command.Dispose();
                            con.Close();
                            return true;
                        }
                    }
                }

                command.Dispose();
                con.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please contact your software solutions provider.\n" + ex.Message, "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //IS ADMIN
        public static bool IsAdmin()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql = $"SELECT * FROM Employee WHERE Username = '{UserUsername}'";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader.GetValue(6).ToString() == "Administrator")
                {
                    command.Dispose();
                    con.Close();
                    return true;
                }
            }

            command.Dispose();
            con.Close();
            return false;
        }

        //AUTOFILLCLIENTDETAILS
        public static void FillClients(int clientID, TextBox txtName,TextBox txtSName,TextBox txtNumber, TextBox txtEmail)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string sql = $"SELECT * FROM Client WHERE CAST(Client_ID AS VARCHAR) LIKE '%{clientID.ToString()}%'";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    txtSName.Text = dataReader.GetString(1);
                    txtName.Text = dataReader.GetString(2);
                    txtEmail.Text = dataReader.GetString(3);
                    txtNumber.Text = dataReader.GetString(4);
                }

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please contact your software solutions provider.\n" + ex.Message, "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //AUTOFILLEMPLOYEEDETAILS
        public static void FillEmployees(int employeeID,TextBox txtName, TextBox txtSurname,TextBox txtIDNumber, TextBox txtPhoneNumber, TextBox txtEmail, TextBox txtUsername, TextBox txtPassword, RadioButton rdbReceptionist, RadioButton rdbAdministrator)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string sql = $"SELECT * FROM Employee WHERE CAST(Employee_ID AS VARCHAR) LIKE '%{employeeID.ToString()}%'";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    txtSurname.Text = dataReader.GetString(1);
                    txtName.Text = dataReader.GetString(2);
                    txtIDNumber.Text = dataReader.GetString(3);
                    txtPhoneNumber.Text = dataReader.GetString(4);
                    txtEmail.Text = dataReader.GetString(5);
                    if (dataReader.GetString(6) == "Receptionist")
                    {
                        rdbReceptionist.Checked = true;
                    }
                    if (dataReader.GetString(6) == "Administrator")
                    {
                        rdbAdministrator.Checked = true;
                    }
                    txtUsername.Text = dataReader.GetString(7);
                    txtPassword.Text = dataReader.GetString(8);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please contact your software solutions provider.\n" + ex.Message, "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //AUTOFILLROOMDETAILS
        public static void FillRoom(int roomNumber, TextBox txtRoomNumber, RadioButton rdbYes, RadioButton rdbNo)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string sql = $"SELECT * FROM Room WHERE CAST(Room_Number AS VARCHAR) LIKE '%{roomNumber.ToString()}%'";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    txtRoomNumber.Text = dataReader.GetValue(1).ToString();
                    if (dataReader.GetValue(2).ToString() == "True")
                    {
                        rdbYes.Checked = true;
                    }
                    if (dataReader.GetValue(2).ToString() == "False")
                    {
                        rdbNo.Checked = true;
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please contact your software solutions provider.\n" + ex.Message, "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //AUTO FILL ROOM SIZE 
        public static void FillSize(int sizeID, TextBox txtDescrip, TextBox txtPrice)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string sql = $"SELECT * FROM Room_Size WHERE CAST(Size_ID AS VARCHAR) LIKE '%{sizeID.ToString()}%'";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    txtDescrip.Text = dataReader.GetString(1).ToString();
                    txtPrice.Text = Convert.ToDouble(dataReader.GetValue(2)).ToString("");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please contact your software solutions provider.\n" + ex.Message, "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //AUTO FILL PACKAGE
        public static void FillPackage(TextBox txtNm, TextBox txtPrc, string packageName)
        {
            try
            {
                 if (con.State == ConnectionState.Closed)
                 {
                     con.Open();
                 }

                string sql = $"SELECT * FROM Package WHERE Package_Name = '{packageName}'";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    txtNm.Text = dataReader.GetValue(1).ToString();
                    txtPrc.Text = Convert.ToDouble(dataReader.GetValue(2)).ToString();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please contact your software solutions provider.\n" + ex.Message, "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //BookingReport
        public static List<String> BookingReportTimePeriod(DateTime start, DateTime end)
        {
            List<String> lines = new List<string>();

            int count = 0;
            try
            {
                con.Open();
                string sql = $"SELECT * FROM Booking WHERE Check_InDate >= '{start}' AND Check_OutDate <= '{end}'";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                lines.Add("Bookings from " + start.ToShortDateString() + " to " + end.ToShortDateString());
                lines.Add("_____________________________________________");
                while (dataReader.Read())
                {
                    count++;
                }
                if(count == 0)
                {
                    return lines;
                }
                lines.Add("Amount of Bookings: \t" + count.ToString());
                con.Close();

                con.Open();
                int totalAdults = 0;
                string sqlAdults = $"SELECT Number_Adults FROM Booking WHERE Check_InDate >= '{start}' AND Check_OutDate <= '{end}'";
                command = new SqlCommand(sqlAdults, con);
                dataReader = command.ExecuteReader();
               // report += "\nTotal number of Adults: ";
                while (dataReader.Read())
                {
                    totalAdults += dataReader.GetInt32(0);
                }
                lines.Add("Total number of Adults: \t" + totalAdults);
                lines.Add("Average number of Adults: \t" + Decimal.Truncate(totalAdults / count).ToString());
                con.Close();

                con.Open();
                int totalChildren = 0;
                string sqlChildren = $"SELECT Number_Child FROM Booking WHERE Check_InDate >= '{start}' AND Check_OutDate <= '{end}'";
                command = new SqlCommand(sqlChildren, con);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    totalChildren += dataReader.GetInt32(0);
                }
                lines.Add("Total number of Children: \t"+totalChildren);
                lines.Add("Average number of Children: \t" + Decimal.Truncate(totalChildren / count).ToString());
                con.Close();
                return lines;
            }
            catch (Exception ex)
            {
                List<String> error = new List<String>();
                MessageBox.Show("Please contact your software solutions provider \n" + ex.Message, "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return error;
            }
        }

        //PackageReport
        public static List<String> PackageReportTimePeriod(DateTime start, DateTime end)
        {
            try
            {
                List<String> lines = new List<string>();

                con.Open();
                string sql = $"SELECT p.Package_ID, p.Package_Name, p.Package_Price, COUNT(b.Package_ID) AS Package_Count FROM Package AS p LEFT JOIN Booking AS b ON p.Package_ID = b.Package_ID WHERE b.Check_InDate >= '{start}' AND b.Check_OutDate <= '{end}' GROUP BY p.Package_ID, p.Package_Name, p.Package_Price ORDER BY Package_Count DESC";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                lines.Add("Packages Sorted by Popularity from " + start.ToShortDateString() + " to " + end.ToShortDateString());
                lines.Add("");
                lines.Add("Package_ID \t Package Name \t Package Price \t Frequency");
                lines.Add("_______________________________________________________________");
                while (dataReader.Read())
                {
                    lines.Add(dataReader.GetValue(0).ToString() + "\t\t" + dataReader.GetValue(1).ToString() + "\t\t" + dataReader.GetValue(2).ToString() + "\t\t" + dataReader.GetValue(3).ToString());
                }
                con.Close();
                return lines;

            }
            catch (Exception ex)
            {
                List<String> error = new List<string>();
                MessageBox.Show("Please contact your software solutions provider \n" + ex.Message, "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.Add("An error has occured");
                return error;
            }
        }

        //populateTableNames
        public static void PopulateTableNameComboBox(ComboBox cboTableNames)
        {
            cboTableNames.Items.Clear();
            con.Open();
            DataTable tableNames = con.GetSchema("Tables");
            foreach (DataRow row in tableNames.Rows)
                cboTableNames.Items.Add(row["TABLE_NAME"].ToString());
        }

        //exportToCSV
        public static void ExportToCSV(string tableName)
        {
            string file = $"{tableName}.csv";
            string header = "";
            List<string> lines = new List<string>();

            try
            {
                con.Open();
                string sql = $"SELECT * FROM {tableName}";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();

                string[] columns = new string[dataReader.FieldCount];
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    columns[i] = dataReader.GetName(i);
                }

                header = string.Join(",", columns);
                lines.Add(header);

                while (dataReader.Read())
                {
                    string[] data = new string[dataReader.FieldCount];
                    for (int j = 0; j < dataReader.FieldCount; j++)
                    {
                        data[j] = dataReader.GetValue(j).ToString();
                    }
                    lines.Add(string.Join(",", data));
                }

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.InitialDirectory = @"C:\";
                saveDialog.FileName = file;
                saveDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    file = saveDialog.FileName;
                    MessageBox.Show(tableName + " Table saved successfully as CSV file.");
                }
                else
                {
                    MessageBox.Show(tableName + " Table was not saved successfully as CSV file.");
                }

                System.IO.File.WriteAllLines(file, lines);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please contact your software solutions provider \n" + ex.Message, "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //populatePackagesComboBox
        public static void PopulatePackagesComboBox(ComboBox cboPackages)
        {
            try
            {
                cboPackages.Items.Clear();
                con.Open();
                string sql = "SELECT Package_Name FROM Package";
                command = new SqlCommand(sql,con);
                dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    cboPackages.Items.Add(dataReader.GetValue(0).ToString());
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please contact your software solutions provider \n" + ex.Message, "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //FillUpdatePackage
        public static void AutoFillPackage(int bookingID, Label lblCurrentPackage)
        {
            try
            {
                con.Open();
                string sql = $"SELECT p.Package_Name FROM Package p, Booking b WHERE p.Package_ID = b.Package_ID AND b.Booking_ID = {bookingID}";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    lblCurrentPackage.Text = dataReader.GetValue(0).ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please contact your software solutions provider \n" + ex.Message, "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //DoesClientExist
        public static bool DoesClientExist(string fullName)
        {
            try
            {
                bool found = false;
                string firstName = "", lastName = "";
                if(fullName.IndexOf(" ") != 0)
                {
                    string[] nameParts = fullName.Split(' ');
                    if(nameParts.Length == 2)
                    {
                        firstName = nameParts[0];
                        lastName = nameParts[1];
                    }
                    else
                    {
                        firstName = nameParts[0];
                        for (int i = 1; i <= nameParts.Length; i++)
                        {
                            if(i == nameParts.Length)
                                lastName += nameParts[i];
                            else
                                lastName += nameParts[i] + " ";
                        }
                           
                    }

                }
                else
                {
                    return false;
                }
                con.Open();
                string sql = "SELECT Client_Last_Name, Client_First_Name FROM Client";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    if ((dataReader.GetString(0) == lastName) && (dataReader.GetString(1) == firstName))
                        found = true;
                }
                con.Close();
                if (found)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please contact your software solutions provider \n" + ex.Message, "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //GetPackageID
        public static int GetPackageID(string packageName)
        {
            try
            {
                int package_ID = 0;
                con.Open();
                string sqlPackageID = $"SELECT Package_ID, Package_Price FROM Package WHERE Package_Name = '{packageName}'";
                command = new SqlCommand(sqlPackageID, con);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    package_ID = Convert.ToInt32(dataReader.GetValue(0));
                }
                con.Close();
                return package_ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please contact your software solutions provider \n" + ex.Message, "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }

        //GetBookingPrice
        public static double GetBookingPrice(string packageName, int bookingID)
        {
            try
            {
                double packagePrice = 0;
                con.Open();
                string sqlPackagePrice = $"SELECT Package_Price FROM Package WHERE Package_Name = '{packageName}'";
                command = new SqlCommand(sqlPackagePrice, con);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    packagePrice = Convert.ToDouble(dataReader.GetValue(0));
                }
                con.Close();

                double sizePrice = 0;
                con.Open();
                string sqlRoomPrice = $"SELECT Size_Price FROM Booking b,Room r,Room_Size s WHERE Booking_ID = {bookingID} AND b.Room_ID = r.Room_ID AND r.Size_ID = s.Size_ID";
                command = new SqlCommand(sqlRoomPrice, con);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    sizePrice = Convert.ToDouble(dataReader.GetValue(0));
                }
                con.Close();
                return packagePrice + sizePrice;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please contact your software solutions provider \n" + ex.Message, "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        //MakeBooking
        public static void MakeBooking(int numAdults, int numChildren, string fullName, string package, bool paymentRecieved, Label lblPrice)
        {
            try
            {
                
                int ClientID = 0;
                int totalPeople = numAdults + numChildren;
                string firstName = "", lastName = "";
                if (fullName.IndexOf(" ") != 0)
                {
                    string[] nameParts = fullName.Split(' ');
                    if (nameParts.Length == 2)
                    {
                        firstName = nameParts[0];
                        lastName = nameParts[1];
                    }
                    else
                    {
                        firstName = nameParts[0];
                        for (int i = 1; i <= nameParts.Length; i++)
                        {
                            if (i == nameParts.Length)
                                lastName += nameParts[i];
                            else
                                lastName += nameParts[i] + " ";
                        }

                    }
                }



                con.Open();

                string sqlGetID = $"SELECT Client_ID FROM Client WHERE Client_Last_Name = '{lastName}' AND Client_First_Name = '{firstName}'";
                command = new SqlCommand(sqlGetID, con);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                ClientID = Convert.ToInt32(dataReader.GetValue(0));
                con.Close();

                int package_ID = 0;
                double packagePrice = 0;
                con.Open();
                string sqlPackageID = $"SELECT Package_ID, Package_Price FROM Package WHERE Package_Name = '{package}'";
                command = new SqlCommand(sqlPackageID, con);
                dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    package_ID = Convert.ToInt32(dataReader.GetValue(0));
                    packagePrice = Convert.ToDouble(dataReader.GetValue(1));
                }
                con.Close();

                int sizeID = 0;
                int roomID = 0;
                int roomNumber = 0;
                double sizePrice = 0;
                con.Open();
                string sqlRoom = $"SELECT * FROM Room, Room_Size WHERE Room_Available = 'True' AND Size_Description <= '{totalPeople} person(s)'";
                command = new SqlCommand(sqlRoom, con);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                roomID = Convert.ToInt32(dataReader.GetValue(0));
                sizeID = Convert.ToInt32(dataReader.GetValue(1));
                sizePrice = Convert.ToDouble(dataReader.GetValue(6));
                roomNumber = Convert.ToInt32(dataReader.GetValue(3));
                con.Close();
                if (roomID != 0)
                {
                    double bookingTotal = packagePrice + sizePrice;
                    lblPrice.Text = bookingTotal.ToString("C");
                    AllMethods.CrudOperations('C',$"INSERT INTO Booking (Number_Adults,Number_Child,Booking_Total,Check_InDate,Check_OutDate,Booking_Active,Booking_Paid,Room_ID,Client_ID,Package_ID,Employee_ID) Values ({numAdults},{numChildren},{bookingTotal},'{GetDateTime()}','{GetDateTime().AddYears(1)}','True','{paymentRecieved}',{roomID},{ClientID},{package_ID},{2})",null);
                    AllMethods.CrudOperations('U',$"UPDATE Room SET Room_Available = 'False' WHERE Room_ID = {roomID}",null);
                    MessageBox.Show("Booking for client " + fullName + " made for Room Number " + roomNumber);
                }
                else
                {
                    MessageBox.Show("NO ROOM AVAILABLE");
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Please contact your software solutions provider \n" + ex.Message, "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
