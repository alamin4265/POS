using System;

namespace POS_Software.Presentation.UI.City
{
    public partial class frmCity : Template.frmDisplay
    {
        public frmCity()
        {
            InitializeComponent();
        }
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmCityNew().ShowDialog();
        }
    }
}
