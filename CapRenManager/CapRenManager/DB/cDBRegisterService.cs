using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapRenManager.DB
{
    class cDBRegisterService
    {
        #region Constants

        protected new const string TABLE_NAME = "sales";
        protected new const string TABLE_ALIAS = " sales ";
        protected new const string FIELD_ALIAS = "sal.";

        protected new enum eFields
        {
            IdSale,
            Date,
            Name,
            Price,
            Coffin,
            Type
        }

        #endregion

        #region Properties & Vars

        private int _iIdSale;
        public int IdSale { get => _iIdSale; }

        private DateTime _dDate;

        public DateTime Date
        {
            get { return _dDate; }
            set { _dDate = value; }
        }

        private string _sName;
        public string Name { get => _sName; set => _sName = value; }

        private int _iPrice;
        public int Price { get => _iPrice; set => _iPrice = value; }

        private string _sCoffin;
        public string Coffin { get => _sCoffin; set => _sCoffin = value; }

        private string _sType;
        public string Type { get => _sType; set => _sType = value; }

        #endregion


    }
}
