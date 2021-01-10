using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace CapRenManager
{
    public partial class Main : Form
    {
        CultureInfo myCIintl = new CultureInfo("es-ES", false);

        ucSalesRegister _ucSalesRegister;
        ucHistoric _ucHistoric;
        ucInventary _ucInventary;
        ucPassword _ucPassword;
        wfPassword _wfPassword;

        public Main()
        {
            _ucSalesRegister = new ucSalesRegister();
            _ucHistoric = new ucHistoric();
            _ucInventary = new ucInventary();
            _ucPassword = new ucPassword();
            _wfPassword = new wfPassword();
            
            InitializeComponent();
        }

        #region On load
        private void Main_Load(object sender, EventArgs e)
        {
            _ucSalesRegister.Dock = DockStyle.Fill;
            _pMainPanel.Controls.Add(_ucSalesRegister);
        }
        #endregion

        #region Main Buttons
        private void _bSalesRegister_Click(object sender, EventArgs e)
        {

            _pMainPanel.Controls.Remove(_ucHistoric);
            _pMainPanel.Controls.Remove(_ucInventary);

            _ucSalesRegister.Dock = DockStyle.Fill;
            _pMainPanel.Controls.Add(_ucSalesRegister);

        }

        private void _bSalesRecord_Click(object sender, EventArgs e)
        {

            _pMainPanel.Controls.Remove(_ucSalesRegister);
            _pMainPanel.Controls.Remove(_ucInventary);

            _ucHistoric.Dock = DockStyle.Fill;
            _pMainPanel.Controls.Add(_ucHistoric);

        }

        private void _bInventary_Click(object sender, EventArgs e)
        {
            _pMainPanel.Controls.Remove(_ucSalesRegister);
            _pMainPanel.Controls.Remove(_ucHistoric);

            _ucInventary.Dock = DockStyle.Fill;
            _pMainPanel.Controls.Add(_ucInventary);
        }
        #endregion

    }
}