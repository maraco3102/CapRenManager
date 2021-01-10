using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CapRenManager.Properties;
using Microsoft.Office.Interop.Word;
using System.IO;

namespace CapRenManager
{
    public partial class ucSalesRegister : UserControl
    {
        public ucSalesRegister()
        {
            InitializeComponent();
        }

        #region On Load
        private void ucSalesRegister_Load(object sender, EventArgs e)
        {
            LoadCoffinsFromDB();

            LoadServiceTypesFromDB();

            LoadCivilStates();

            int today = GetCurrentDate();
            _lblMainDateLabel.Text = today.ToString();
        }
        #endregion

        #region Button Events
        private void _btnRegisterSale_Click(object sender, EventArgs e)
        {
            List<string> FormData = new List<string>();

            FormData.Add(_tbDeadName.Text.ToString());
            FormData.Add(_tbDeadSurname.Text.ToString());
            FormData.Add(_tbDeadBirthPlace.Text.ToString());
            FormData.Add(_dtpDeadBorn.Text.ToString());
            FormData.Add(_cbDeadSex.Text.ToString());
            FormData.Add(_nudAge.Text.ToString());
            FormData.Add(_cbCivilStatus.Text.ToString());
            FormData.Add(_tbDeadSchool.Text.ToString());
            FormData.Add(_tbDeadNation.Text.ToString());
            FormData.Add(_tbDeadJob.Text.ToString());
            FormData.Add(_tbDeadAddress.Text.ToString());
            FormData.Add(_tbDeadPartner.Text.ToString());
            FormData.Add(_tbDeadPlace.Text.ToString());
            FormData.Add(_tbDeadDoctorNum.Text.ToString());
            FormData.Add(_nudCertificate.Text.ToString());
            FormData.Add(_dtpDeadDate.Text.ToString());
            FormData.Add(_tbDeadTime.Text.ToString());
            FormData.Add(_tbDeadCause.Text.ToString());
            FormData.Add(_tbDeadDocName.Text.ToString());
            FormData.Add(_tbInformantName.Text.ToString());
            FormData.Add(_tbClientRelation.Text.ToString());
            FormData.Add(_tbClientAddress.Text.ToString());
            FormData.Add(_tbClientPhone.Text.ToString());
            FormData.Add(_tbPlaceService.Text.ToString());
            FormData.Add(_dtpServiceDate.Text.ToString());
            FormData.Add(_dtpFuneralDate.Text.ToString());
            FormData.Add(_tbFuneralTime.Text.ToString());
            FormData.Add(_tbCementery.Text.ToString());
            FormData.Add(_tbNameClient.Text.ToString());
            FormData.Add(_nudPrice.Text.ToString());
            FormData.Add(_cbTypeCoffin.Text.ToString());
            FormData.Add(_cbTypeService.Text.ToString());

            //Prepare data for DB
            int registerDate = GetCurrentDate();
            //string registerDate = _lblMainDateLabel.Text.ToString();
            //DateTime registerDate = DateTime.Today;
            string date = _dtpDeadDate.Text.ToString();
            string name = _tbDeadName.Text.ToString() + " " + _tbDeadSurname.Text.ToString();
            string price = _nudPrice.Value.ToString();
            string coffin = _cbTypeCoffin.Text.ToString();
            string type = _cbTypeService.Text.ToString();

            //Send data to DB
            registerData(registerDate, date, name, price, coffin, type);

            #region Docs Creation
            //Create a new microsoft word file
            Microsoft.Office.Interop.Word.Application fileOpen = new Microsoft.Office.Interop.Word.Application();
            //Open a already existing word file into the new document created
            Microsoft.Office.Interop.Word.Document document = fileOpen.Documents.Open(@"C:\Resources\Docs.docx", ReadOnly: false);
            //Make the file visible 
            fileOpen.Visible = true;
            document.Activate();
            //The FindAndReplace takes the text to find under any formatting and replaces it with the
            //new text with the same exact formmating (e.g red bold text will be replaced with red bold text)
            DateTime today = DateTime.Today;
            string CurrentDate = today.ToString("dd-MM-yyyy");

            FindAndReplace(fileOpen, "%DateRegister", CurrentDate.ToString());
            FindAndReplace(fileOpen, "%DeadName", _tbDeadName.Text.ToString());
            FindAndReplace(fileOpen, "%DeadSurname", _tbDeadSurname.Text.ToString());
            FindAndReplace(fileOpen, "%DeadBirthPlace", _tbDeadBirthPlace.Text.ToString());
            FindAndReplace(fileOpen, "%DeadDateBirth", _dtpDeadBorn.Text.ToString());
            FindAndReplace(fileOpen, "%DeadSex", _cbDeadSex.Text.ToString());
            FindAndReplace(fileOpen, "%DeadAge", _nudAge.Text.ToString());
            FindAndReplace(fileOpen, "%DeadCivil", _cbCivilStatus.Text.ToString());
            FindAndReplace(fileOpen, "%DeadSchool", _tbDeadSchool.Text.ToString());
            FindAndReplace(fileOpen, "%DeadNation", _tbDeadNation.Text.ToString());
            FindAndReplace(fileOpen, "%DeadJob", _tbDeadJob.Text.ToString());
            FindAndReplace(fileOpen, "%DeadPlace", _tbDeadAddress.Text.ToString());
            FindAndReplace(fileOpen, "%DeadPartner", _tbDeadPartner.Text.ToString());
            FindAndReplace(fileOpen, "%DeadDeathPlace", _tbDeadPlace.Text.ToString());
            FindAndReplace(fileOpen, "%DeadNumDoc", _tbDeadDoctorNum.Text.ToString());
            FindAndReplace(fileOpen, "%DeadCertificate", _nudCertificate.Text.ToString());
            FindAndReplace(fileOpen, "%DeadDateDeath", _dtpDeadDate.Text.ToString());
            FindAndReplace(fileOpen, "%DeatTime", _tbDeadTime.Text.ToString());
            FindAndReplace(fileOpen, "%DeadCause", _tbDeadCause.Text.ToString());
            FindAndReplace(fileOpen, "%DoctorName", _tbDeadDocName.Text.ToString());
            FindAndReplace(fileOpen, "%InforName", _tbInformantName.Text.ToString());
            FindAndReplace(fileOpen, "%InforRelation", _tbClientRelation.Text.ToString());
            FindAndReplace(fileOpen, "%InforPlace", _tbClientAddress.Text.ToString());
            FindAndReplace(fileOpen, "%Phone", _tbClientPhone.Text.ToString());
            FindAndReplace(fileOpen, "%PlaceService", _tbPlaceService.Text.ToString());
            FindAndReplace(fileOpen, "%DateService", _dtpServiceDate.Text.ToString());
            FindAndReplace(fileOpen, "%FuneralDate", _dtpFuneralDate.Text.ToString());
            FindAndReplace(fileOpen, "%FuneralTime", _tbFuneralTime.Text.ToString());
            FindAndReplace(fileOpen, "%Cementery", _tbCementery.Text.ToString());
            FindAndReplace(fileOpen, "%ClientName", _tbNameClient.Text.ToString());
            FindAndReplace(fileOpen, "%Price", _nudPrice.Text.ToString());
            FindAndReplace(fileOpen, "%Coffin", _cbTypeCoffin.Text.ToString());
            FindAndReplace(fileOpen, "%TypeService", _cbTypeService.Text.ToString());

            //Save the editted file in a specified location
            //Can use SaveAs instead of SaveAs2 and just give it a name to have it saved by default
            //to the documents folder
            string root = @"C:\Registros\Servicios";

            string _sYear = GetCurrentYear();
            string subdirYear = @"C:\Registros\Servicios\"+_sYear;

            int _iMonth = GetCurrentDate();
            string _sMonth = GetMonthName(_iMonth);
            string fullPath = Path.Combine(subdirYear,_sMonth);
            //string subdirMonth = subdirYear + _sMonth;

            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }

            // Create a sub directory
            if (!Directory.Exists(subdirYear))
            {
                Directory.CreateDirectory(subdirYear);
            }

            // Create a sub directory
            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }

            string savePath = Path.Combine(fullPath, _tbDeadName.Text.ToString() + "_" + _tbDeadSurname.Text.ToString());
            document.SaveAs2(savePath);
            //Close the file out
            fileOpen.Quit();

            #endregion

            #region Cards Creation

            ////Create a new microsoft word file
            //Microsoft.Office.Interop.Word.Application fileOpen2 = new Microsoft.Office.Interop.Word.Application();
            ////Open a already existing word file into the new document created
            //Microsoft.Office.Interop.Word.Document document2 = fileOpen2.Documents.Open(@"C:\Resources\Stamp.docx", ReadOnly: false);
            ////Make the file visible 
            //fileOpen2.Visible = true;
            //document2.Activate();
            ////The FindAndReplace takes the text to find under any formatting and replaces it with the
            ////new text with the same exact formmating (e.g red bold text will be replaced with red bold text)

            //FindAndReplace(fileOpen2, "%DeadName", _tbDeadName.Text.ToString());
            //FindAndReplace(fileOpen2, "%DeadSurname", _tbDeadSurname.Text.ToString());
            //FindAndReplace(fileOpen2, "%DeadDateDeath", _dtpDeadDate.Text.ToString());

            ////Save the editted file in a specified location
            ////Can use SaveAs instead of SaveAs2 and just give it a name to have it saved by default
            ////to the documents folder
            //document2.SaveAs2(@"C:\Resources\NewFile2");
            ////Close the file out
            //fileOpen2.Quit();

            #endregion

            //Update Coffin DB
            UpdateCoffinDB(coffin);

            MessageBox.Show("Servicio Registrado con exito!");

        }

        #endregion

        #region Methods

        #region Register Sale in DB
        static void registerData(int registerDate, string date, string name, string price, string coffin, string type)
        {
            string _sMonthName = GetMonthName(registerDate);
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = Properties.Settings.Default.connectDB;
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into sales(Registro,Defuncion,Nombre,Precio,Ataud,Servicio) values('" + _sMonthName + "','" + date + "','" + name + "','" + price + "','" + coffin + "','" + type + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Get Month Name
        static string GetMonthName(int registerDate)
        {

            switch (registerDate)
            {
                case 1: return "Enero";
                case 2: return "Febrero";
                case 3: return "Marzo";
                case 4: return "Abril";
                case 5: return "Mayo";
                case 6: return "Junio";
                case 7: return "Julio";
                case 8: return "Agosto";
                case 9: return "Septiembre";
                case 10: return "Octubre";
                case 11: return "Noviembre";
                case 12: return "Diciembre";
                default: return "error";
            }

        }
        #endregion

        #region Find Replace
        static void FindAndReplace(Microsoft.Office.Interop.Word.Application fileOpen, object findText, object replaceWithText)
        {
            object matchCase = false;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            //execute find and replace
            fileOpen.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace,
                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        }
        #endregion

        #region Load Coffins on CB
        private void LoadCoffinsFromDB()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.connectDB);

                string selectQuery = "SELECT * FROM coffins";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    _cbTypeCoffin.Items.Add(reader.GetString("NameCoffin"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Load Service Types on CB
        private void LoadServiceTypesFromDB()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.connectDB);

                string selectQuery = "SELECT * FROM servicetype";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    _cbTypeService.Items.Add(reader.GetString("ServiceType"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Load Civil States in CB
        private void LoadCivilStates()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.connectDB);

                string selectQuery = "SELECT * FROM civilstates";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    _cbCivilStatus.Items.Add(reader.GetString("CivilState"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Get Current Date
        private int GetCurrentDate()
        {
            DateTime today = DateTime.Today;
            string _sMonth = today.ToString("MM");
            int _iMonth = Int32.Parse(_sMonth);
            return _iMonth;
        }
        #endregion

        #region Get Current Year
        private string GetCurrentYear()
        {
            DateTime today = DateTime.Today;
            string _sYear = today.ToString("yyyy");
            return _sYear;
        }
        #endregion

        #region Get Current Month
        private string GetCurrentMonth()
        {
            DateTime today = DateTime.Today;
            string _sMonth = today.ToString("MM");
            return _sMonth;
        }
        #endregion

        #region Get Id and Inventory of CoffinType
        private void UpdateCoffinDB(string _sCoffinType)
        {
            string _sIdCoffin;
            string _sQuantytyCoffin;

            try
            {
                MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.connectDB);

                string selectQuery = "SELECT * FROM coffins where NameCoffin= '" + _sCoffinType + "';";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    _sIdCoffin = reader.GetString("IdCoffin");
                    _sQuantytyCoffin = reader.GetString("Inventary");

                    UpdateCoffinQuantity(_sIdCoffin, _sQuantytyCoffin);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Update Coffin Quantity
        private void UpdateCoffinQuantity(string _sIdCoffin, string _sQuantity)
        {
            try
            {
                int _iNewQuantity = (Int32.Parse(_sQuantity)-1);
                string _sNewQuantity = _iNewQuantity.ToString();

                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = Properties.Settings.Default.connectDB;
                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update coffins set Inventary='" + _sNewQuantity + "' where IdCoffin='" + _sIdCoffin + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #endregion
    }
}
