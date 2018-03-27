namespace POS_Software.Presentation.UI.Brand
{
    public partial class frmBrand : POS_Software.Presentation.Template.frmDisplay
    {
        public frmBrand()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            new frmBrandNew().ShowDialog();
        }
    }
}
