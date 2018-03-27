namespace POS_Software.Presentation.UI.Unit
{
    public partial class frmUnit : POS_Software.Presentation.Template.frmDisplay
    {
        public frmUnit()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            new frmUnitNew().ShowDialog();
        }
    }
}
