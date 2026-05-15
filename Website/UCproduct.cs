using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

    namespace Website
{
    public partial class UCproduct : UserControl
    {
        private BindingList<Product> _inventoryList = new BindingList<Product>();
        private BindingSource _bindingSource = new BindingSource();

        string filePath = ".\\anything.csv";
        public UCproduct()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // 1. Validation
                if (!ValidateInputs()) return;

                // 2. Get textbox inputs and create the new product 
                int newId = _inventoryList.Count + 1000;
                string name = txtID.Text;
                string brand = HJGFC.Text;
                decimal price = decimal.Parse(LB4.Text);
                int quantity = int.Parse(LB3.Text);

                // Use the Constructor to create a new intance of Product
                Product newProduct = new Product(newId, name, brand, price, quantity);
                _inventoryList.Add(newProduct);

                // 4. Refresh the grid to show the new item
                _bindingSource.ResetBindings(false);

                // 5. Clear fields for the next entry
                ClearFields();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private bool ValidateInputs() //true or false
        {
            // Check if Name contains invalid special characters like #, $, @
            // This regex allows only letters, numbers, and spaces
            if (!Regex.IsMatch(txtID.Text, @"^[a-zA-Z0-9 ]+$"))
            {
                MessageBox.Show("Product Name contains invalid characters.");
                return false;
            }

            // Check if Price is a positive decimal
            if (!decimal.TryParse(LB4.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive price.");
                return false;
            }

            // Check if Quantity is a positive integer
            if (!int.TryParse(LB3.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Please enter a valid positive quantity.");
                return false;
            }

            return true;
        }
        private void ClearFields()
        {
            txtID.Clear();
            txtID.Clear();
            //HJGFC.Clear();
            LB4.Clear();
            LB3.Clear();
        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void UCproduct_Load(object sender, EventArgs e)
        {
            //this pulls it for file path, then puts in temp list
            string path = filePath;
            var tempdata = InventoryService.LoadFromCSV(path);
            // 1. clears the binding list and loads th data
            _inventoryList.Clear(); //clears the gride before it 
            foreach (var item in tempdata) // for each item in the temp data 
            {
                _inventoryList.Add(item); // this acc adds it 
            }

            dvgInventory.DataSource = _inventoryList; // binds the binding list to the grid

        }

        private void Update_Click(object sender, EventArgs e) 
        {
            if (!int.TryParse(txtID.Text, out int idToUpdate)) // if (! mean not anything before it) it search what ID you used 
            {
                MessageBox.Show("Please select an product"); // shows an massage box
                return; // returns back to the code
            }

            var productToUpdate = _inventoryList.FirstOrDefault(p => p.ProductID == idToUpdate); // (=> mean equal to or more) to the ID product == to the idToUpdate js mean no i wont do 

            if (productToUpdate != null) //this mean not equal to null
            {
                // Update the object properties (EX)
                if (ValidateInputs())
                { 
                productToUpdate
                }
            }
        }
    }
}
