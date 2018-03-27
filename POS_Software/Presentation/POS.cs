using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_Software.Presentation;
using POS_Software.Presentation.UI.Brand;
using POS_Software.Presentation.UI.Category;
using POS_Software.Presentation.UI.City;
using POS_Software.Presentation.UI.Country;
using POS_Software.Presentation.UI.Price;
using POS_Software.Presentation.UI.Product;
using POS_Software.Presentation.UI.Product_Image;
using POS_Software.Presentation.UI.Unit;

namespace POS_Software.UI
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
        }

        private frmCountry country = new frmCountry();
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (country.IsDisposed)
                country = new frmCountry();
            country.MdiParent = this;
            country.Show();
            country.BringToFront();
        }

        private frmCity city = new frmCity();
        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (city.IsDisposed)
                city = new frmCity();
            city.MdiParent = this;
            city.Show();
            city.BringToFront();
        }

        private frmBrand brand = new frmBrand();
        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (brand.IsDisposed)
                brand = new frmBrand();
            brand.MdiParent = this;
            brand.Show();
            brand.BringToFront();
        }

        private frmCategory category = new frmCategory();
        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (category.IsDisposed)
                category = new frmCategory();
            category.MdiParent = this;
            category.Show();
            category.BringToFront();
        }

        private frmUnit unit = new frmUnit();
        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unit.IsDisposed)
                unit = new frmUnit();
            unit.MdiParent = this;
            unit.Show();
            unit.BringToFront();
        }

        private frmProduct product = new frmProduct();
        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (product.IsDisposed)
                product = new frmProduct();
            product.MdiParent = this;
            product.Show();
            product.BringToFront();
        }

        private frmProductPrice productPrice = new frmProductPrice();
        private void productPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(productPrice.IsDisposed)
                productPrice=new frmProductPrice();
            productPrice.MdiParent = this;
            productPrice.Show();
            productPrice.BringToFront();
        }

        private frmProductImage productImage = new frmProductImage();
        private void productImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productImage.IsDisposed)
                productImage = new frmProductImage();
            productImage.MdiParent = this;
            productImage.Show();
            productImage.BringToFront();
        }

        
    }
}
