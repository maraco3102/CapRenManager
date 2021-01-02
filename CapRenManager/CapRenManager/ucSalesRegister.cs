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

        protected new enum DataFields
        {
            data = 1,
            Name,
            Password,
            Active
        }

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
            DateTime registerDate = DateTime.Today;
            string date = _dtpDeadDate.Text.ToString();
            string name = _tbDeadName.Text.ToString() + " " + _tbDeadSurname.Text.ToString();
            string price = _nudPrice.Value.ToString();
            string coffin = _cbTypeCoffin.Text.ToString();
            string type = _cbTypeService.Text.ToString();

            //Send data to DB
            registerData(registerDate, date, name, price, coffin, type);

            //FormData.ForEach(Print);

        }

        #region Register in DB
        static void registerData(DateTime registerDate, string date, string name, string price, string coffin, string type)
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = Properties.Settings.Default.connectDB;
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into sales(Date,DateDead,Name,Price,Coffin,Type) values('" + registerDate.ToString() + "','" + date + "','" + name + "','" + price + "','" + coffin + "','" + type + "');";
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

        #endregion

        #region Generate Docs

        #endregion

        private void ucSalesRegister_Load(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = Properties.Settings.Default.connectDB;
                //Display query  
                string Query = "select NameCoffin from coffins;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2 = MyCommand2.ExecuteReader();
                MyConn2.Open();

                while (MyReader2.Read())
                {
                    _cbTypeCoffin.Items.Add(MyReader2.GetString("id"));
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            }

        
    }
}
