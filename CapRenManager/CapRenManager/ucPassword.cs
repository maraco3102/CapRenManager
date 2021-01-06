using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapRenManager
{
    public partial class ucPassword : UserControl
    {
        public ucPassword()
        {
            InitializeComponent();
        }

        private void _btnAccess_Click(object sender, EventArgs e)
        {
            string password = _tbPassword.Text.ToString();

            if (password == Properties.Settings.Default.password)
            {
               
            }
        }
    }
}
