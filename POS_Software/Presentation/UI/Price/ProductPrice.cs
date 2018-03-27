namespace POS_Software.Presentation.UI.Price
{
    public partial class frmProductPrice : POS_Software.Presentation.Template.frmDisplay
    {
        public frmProductPrice()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            new frmProductPriceNew().ShowDialog();
        }
    }
}
