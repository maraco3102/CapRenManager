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
    public partial class ucHistoric : UserControl
    {
        public ucHistoric()
        {
            InitializeComponent();
        }

        #region On Load
        private void ucHistoric_Load(object sender, EventArgs e)
        {
            LoadCoffinsFromDB();

            LoadServiceTypesFromDB();

            DateTime today = DateTime.Today;
            string _sMonth = today.ToString("MM");
            int _iMonth = Int32.Parse(_sMonth);

            string _sMonthName = GetMonthName(_iMonth);
            _cbMonth.Text = _sMonthName;
        }
        #endregion

        #region CheckBox Logic
        private void _chkDateFIlter_CheckedChanged(object sender, EventArgs e)
        {
            if(_cbMonth.Enabled == true)
            {
                _cbMonth.Enabled = false;
            }
            else
            {
                _cbMonth.Enabled = true;
            }
        }

        private void _chkServiceType_CheckedChanged(object sender, EventArgs e)
        {
            if (_cbServiceType.Enabled == true)
            {
                _cbServiceType.Enabled = false;
            }
            else
            {
                _cbServiceType.Enabled = true;
            }
        }

        private void _chkCoffinType_CheckedChanged(object sender, EventArgs e)
        {
            if (_cbCoffinType.Enabled == true)
            {
                _cbCoffinType.Enabled = false;
            }
            else
            {
                _cbCoffinType.Enabled = true;
            }
        }
        #endregion

        #region Buttons

        #region Filters
        private void _bSearchByFilters_Click(object sender, EventArgs e)
        {
            #region Filters configuration
            string _sMonth;
            bool _bMonth;
            _sMonth = _cbMonth.Text.ToString();

            //if (_chkDateFIlter.Checked)
            //{
            //    _bMonth = true;
            //    _sMonth = _cbMonth.Text.ToString();
            //}
            //else
            //{
            //     _bMonth = false;
            //    _sMonth = _cbMonth.Text.ToString();
            //}

            string _sService;
            bool _bService;
            if (_chkServiceType.Checked)
            {
                _bService = true;
                _sService = _cbServiceType.Text.ToString();
            }
            else
            {
                _bService = false;
                _sService = _cbServiceType.Text.ToString();
            }

            string _sCoffin;
            bool _bCoffin;
            if (_chkCoffinType.Checked)
            {
                _bCoffin = true;
                _sCoffin = _cbCoffinType.Text.ToString();
            }
            else
            {
                _bCoffin = false;
                _sCoffin = _cbCoffinType.Text.ToString();
            }
            #endregion

            #region Search By Filters
            SearchByFilters(_sMonth, _bService, _sService, _bCoffin, _sCoffin);
            #endregion
        }
        #endregion

        #region Export to DGV to excel
        private void _bExportData_Click(object sender, EventArgs e)
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
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < _dgvHistoric.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = _dgvHistoric.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < _dgvHistoric.Rows.Count - 1; i++)
            {
                for (int j = 0; j < _dgvHistoric.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = _dgvHistoric.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  

            DateTime Savetoday = DateTime.Today;
            string _sSaveMonth = Savetoday.ToString("MM");
            int _iSaveMonth = Int32.Parse(_sSaveMonth);

            //string _sSaveMonthName = GetMonthName(_iSaveMonth);

            string _sSaveMonthName = _cbMonth.Text;

            workbook.SaveAs("c:\\Registros\\" + _sSaveMonthName +".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
        }
        #endregion

        #endregion

        #region Methods

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
                    _cbCoffinType.Items.Add(reader.GetString("NameCoffin"));
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
                    _cbServiceType.Items.Add(reader.GetString("ServiceType"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Search by Filters
        private void SearchByFilters(string _sMonth, bool _bService, string _sService, bool _bCoffin, string _sCoffin)
        {
            try
            {
                string MyConnection2 = Properties.Settings.Default.connectDB;

                string MainQuery = "select * from sales where Registro= '" + _sMonth.ToString() + "'";

                string _sMonthQuery;
                string _sServiceQuery;
                string _sCoffinQuery;

                //if (_bMonth)
                //{
                //    _sMonthQuery = " where Registro= '" + _sMonth.ToString() + "'";
                //}
                //else
                //{
                //    _sMonthQuery = "";
                //}

                if (_bService)
                {
                    _sServiceQuery = "and Servicio= '" + _sService.ToString() + "'";
                }
                else
                {
                    _sServiceQuery = "";
                }

                if (_bCoffin)
                {
                    _sCoffinQuery = "and Ataud= '" + _sCoffin.ToString() + "'";
                }
                else
                {
                    _sCoffinQuery = "";
                }

                string FinalQuerry = MainQuery + _sServiceQuery + _sCoffinQuery + ";";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(FinalQuerry, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                _dgvHistoric.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                  // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region
        private string GetMonthName(int _iMonth)
        {
            switch (_iMonth)
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
    }
}

