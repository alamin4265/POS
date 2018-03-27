namespace POS_Software.Presentation.UI.Product
{
    public partial class frmProduct : POS_Software.Presentation.Template.frmDisplay
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            new frmProductNew().ShowDialog();
        }
    }
}
