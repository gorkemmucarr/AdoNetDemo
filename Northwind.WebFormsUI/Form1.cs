using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NhHibernate;
using Northwind.Enitites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IProductService _productService = new ProductManager(new EfProductDal());
        ICategoryService _categoryServiice = new CategoryManager(new EfCategoryDal());
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryServiice.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryIdAdd.DataSource = _categoryServiice.GetAll();
            cbxCategoryIdAdd.DisplayMember = "CategoryName";
            cbxCategoryIdAdd.ValueMember = "CategoryId";

            cbxCategoryIdUpdate.DataSource = _categoryServiice.GetAll();
            cbxCategoryIdUpdate.DisplayMember = "CategoryName";
            cbxCategoryIdUpdate.ValueMember = "CategoryId";
        }

        public void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {
            }

        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.getProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    ProductName = tbxProduckNameAdd.Text,
                    CategoryId = Convert.ToInt32(cbxCategoryIdAdd.SelectedValue),
                    QuantityPerUnit = tbxQuantityPerUnitAdd.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceAdd.Text),
                    UnitsInStock = Convert.ToInt16(tbxUnitsInStock.Text)
                });
                MessageBox.Show("New Product Added!!!");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxProductNameUpdate.Text,
                CategoryId = Convert.ToInt32(cbxCategoryIdUpdate.SelectedValue),
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                QuantityPerUnit = tbxQuantityPerUnitUpdate.Text,
                UnitsInStock = Convert.ToInt16(tbxUnitsInStockUpdate.Text)
            });
            MessageBox.Show("Product Updated!!!");
            LoadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbxProductNameUpdate.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            cbxCategoryIdUpdate.SelectedValue = dgwProduct.CurrentRow.Cells[1].Value;
            tbxUnitPriceUpdate.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            tbxQuantityPerUnitUpdate.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            tbxUnitsInStockUpdate.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Product Deleted!!!");
                    LoadProducts();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }


            }

        }
    }
}
