using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS_Software.Presentation.UI.Country
{
    public partial class frmCountry : POS_Software.Presentation.Template.frmDisplay
    {
        public frmCountry()
        {
            InitializeComponent();
        }

        
        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmCountryNew().ShowDialog();
        }
    }
}
