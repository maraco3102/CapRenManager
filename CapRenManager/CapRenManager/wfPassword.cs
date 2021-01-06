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
    public partial class wfPassword : Form
    {
        public wfPassword()
        {
            InitializeComponent();
        }

        #region Buttons
        private void _btnAccess_Click(object sender, EventArgs e)
        {
            string password = _tbPassword.Text.ToString();

            if(password == Properties.Settings.Default.password)
            {
                
            }
        }
        #endregion

        #region Methods

        #endregion
    }
}
