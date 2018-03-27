using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace POS_Software.Presentation.UI.Country
{
    public partial class frmCountryNew : POS_Software.Presentation.Template.NewEdit
    {
        private ErrorProvider ep = new ErrorProvider();
        private CountryGetWay countryGetWay = new CountryGetWay();
        public frmCountryNew()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;
            if (txtName.Text == "")
            {
                er++;
                ep.SetError(txtName,"Required");
            }
            if(er>0)
                return;
            countryGetWay.Insert()

        }
    }
}
