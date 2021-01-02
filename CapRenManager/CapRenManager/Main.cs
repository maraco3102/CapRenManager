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

namespace CapRenManager
{
    public partial class Main : Form
    {
        ucSalesRegister _ucSalesRegister;
        ucHistoric _ucHistoric;

        public Main()
        {
            _ucSalesRegister = new ucSalesRegister();
            _ucHistoric = new ucHistoric();

            InitializeComponent();
        }

        #region On load
        private void Main_Load(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Main Buttons
        private void _bSalesRegister_Click(object sender, EventArgs e)
        {

            _pMainPanel.Controls.Remove(_ucHistoric);
            _ucSalesRegister.Dock = DockStyle.Fill;
            _pMainPanel.Controls.Add(_ucSalesRegister);

        }

        private void _bSalesRecord_Click(object sender, EventArgs e)
        {

            _pMainPanel.Controls.Remove(_ucSalesRegister);
            _ucHistoric.Dock = DockStyle.Fill;
            _pMainPanel.Controls.Add(_ucHistoric);

        }

        private void _bInventary_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}