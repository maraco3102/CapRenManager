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

            //FormData.ForEach(Print);

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
                MessageBox.Show("Servicio Registrado con exito!");
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

        #endregion

        #region Generate Docs

        #endregion

        #region Load Coffins nn CB
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

        #region Get Current Date
        private int GetCurrentDate()
        {
            DateTime today = DateTime.Today;
            string _sMonth = today.ToString("MM");
            int _iMonth = Int32.Parse(_sMonth);
            return _iMonth;
        }
        #endregion

        #endregion
    }
}
