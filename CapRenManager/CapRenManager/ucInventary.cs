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
using System.IO;

namespace CapRenManager
{
    public partial class ucInventary : UserControl
    {
        public ucInventary()
        {
            InitializeComponent();
        }

        #region On Load
        private void ucInventary_Load(object sender, EventArgs e)
        {
            LoadCoffinsFromDB();
        }
        #endregion

        #region Button Events

        #region Update DB
        private void _btnUpdate_Click(object sender, EventArgs e)
        {
            string _sCoffinType = _cbType.SelectedItem.ToString();

            UpdateCoffinDB(_sCoffinType);

            GetInventory();

            MessageBox.Show("Base de Datos Actualizada");
        }
        #endregion

        #region Search DB
        private void _btnSearch_Click(object sender, EventArgs e)
        {
            GetInventory();
        }
        #endregion

        #region Export Inventary DGV to CSV
        private void _btnExport_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Inventario";
            // storing header part in Excel  
            for (int i = 1; i < _dgvInventary.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = _dgvInventary.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < _dgvInventary.Rows.Count - 1; i++)
            {
                for (int j = 0; j < _dgvInventary.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = _dgvInventary.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  

            string root = @"C:\Registros\Inventarios";
            //string subdir = @"C:\Temp\Mahesh";
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }

            DateTime Savetoday = DateTime.Today;
            string _sSaveMonth = Savetoday.ToString("dd-MM-yyyy");

            workbook.SaveAs("c:\\Registros\\Inventarios\\Inventario_" + _sSaveMonth + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            MessageBox.Show("Datos exportados exitosamente!");
        }

        #endregion

        #region Insert New CoffinType
        private void _btnAddNew_Click(object sender, EventArgs e)
        {
            string _sNewTypeName = _tbNewType.Text.ToString();
            string _sNewTypeQuantity = _nudNewTypeQuantity.Value.ToString();

            InsertNew(_sNewTypeName, _sNewTypeQuantity);

            GetInventory();

            MessageBox.Show("Nuevo Tipo Añadido, reinicie la aplicacion para aplicar los cambios.");
        }
        #endregion

        #endregion

        #region Methods

        #region Get Id and Inventory of CoffinType
        private void UpdateCoffinDB(string _sCoffinType)
        {
            string _sIdCoffin;

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

                    UpdateCoffinQuantity(_sIdCoffin);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Update Coffin Quantity
        private void UpdateCoffinQuantity(string _sIdCoffin)
        {
            try
            {
                string _sNewQuantity = _nudNewQuantity.Value.ToString();

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
                    _cbType.Items.Add(reader.GetString("NameCoffin"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Get Inventory
        private void GetInventory()
        {
            try
            {
                string MyConnection2 = Properties.Settings.Default.connectDB;

                string MainQuery = "select * from coffins;";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(MainQuery, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                _dgvInventary.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                  // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Insert New Type in DB
        private void InsertNew(string _sName, string _sQuantity)
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = Properties.Settings.Default.connectDB;
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into coffins(NameCoffin,Inventary) values('" + _sName + "','" + _sQuantity +"');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                //MessageBox.Show("Save Data");
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

        #endregion


    }
}
