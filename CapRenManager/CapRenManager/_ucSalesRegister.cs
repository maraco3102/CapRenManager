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
    public partial class _ucSalesRegister : UserControl
    {
        public _ucSalesRegister()
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



        }
    }
}
