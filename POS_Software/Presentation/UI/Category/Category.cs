namespace POS_Software.Presentation.UI.Category
{
    public partial class frmCategory : POS_Software.Presentation.Template.frmDisplay
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            new frmCategoryNew().ShowDialog();
        }
    }
}
