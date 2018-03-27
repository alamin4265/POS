using System;
using DAL;

namespace POS_Software.Presentation.UI.Product_Image
{
    public partial class frmProductImage : POS_Software.Presentation.Template.frmDisplay
    {
        public frmProductImage()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ProductImageGetway aProductImage = new ProductImageGetway();
            myGrid1.DataSource = aProductImage.Select().Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmProductImageNew().ShowDialog();
            btnSearch.PerformClick();
        }
    }
}
