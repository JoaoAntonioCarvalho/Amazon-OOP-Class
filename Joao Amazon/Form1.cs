using System;
using System.Windows.Forms;

namespace Joao_Amazon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;

            listView.Columns.Add("Product ID", 100);
            listView.Columns.Add("Product Name", 150);
            listView.Columns.Add("Description", 250);
            listView.Columns.Add("Category", 150);
            listView.Columns.Add("Size (oz)", 70);

            
            try
            {
                Product p1 = new Product();
                p1.ProductName = "Echo Dot";
                p1.ProductDescription = "Smart Speaker with Alexa";
                p1.ProductSize = "3.9";
                addProductsToListView(p1);

                Product p2 = new Product("P-1002", "Kindle Paperwhite");
                p2.ProductDescription = "E-reader with 6.8 inch display";
                p2.ProductSize = "7.2";
                addProductsToListView(p2);

                Product p3 = new Product("P-1003", "Fire TV Stick", "4K Streaming Device", "Electronics", "1.9");
                addProductsToListView(p3);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error creating products: {ex.Message}");
            }

            lblCount.Text = $"Product Count: {listView.Items.Count}";
        }

        private void addProductsToListView(Product product)
        {
            ListViewItem item = new ListViewItem(product.ProductID ?? "");
            item.SubItems.Add(product.ProductName ?? "");
            item.SubItems.Add(product.ProductDescription ?? "");
            item.SubItems.Add(product.ProductCategory ?? "");
            item.SubItems.Add(product.ProductSize ?? "");
            listView.Items.Add(item);
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product(
                    txtPID.Text,
                    txtName.Text,
                    txtDescription.Text,
                    txtCategory.Text,
                    txtSize.Text
                );

                addProductsToListView(product);

                txtPID.Clear();
                txtDescription.Clear();
                txtName.Clear();
                txtSize.Clear();
                txtCategory.Clear();

                lblCount.Text = $"Product Count: {listView.Items.Count}";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                listView.Items.Remove(listView.SelectedItems[0]);
            }
            lblCount.Text = $"Product Count: {listView.Items.Count}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPID.Clear();
            txtName.Clear();
            txtCategory.Clear();
            txtDescription.Clear();
            txtSize.Clear();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            lblCount.Text = $"Product Count: {listView.Items.Count}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPID_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
