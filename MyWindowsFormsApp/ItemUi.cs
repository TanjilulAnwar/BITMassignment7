using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWindowsFormsApp.BLL;

namespace MyWindowsFormsApp
{

    public partial class ItemUi : Form
    {
        ItemManager _itemManager = new ItemManager();

        public ItemUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Check UNIQUE
            if (_itemManager.IsNameExists(nameTextBox.Text))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exists!");
                return;
            }

            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }

            //Add/Insert Item
            bool isAdded = _itemManager.Add(nameTextBox.Text, Convert.ToDouble(priceTextBox.Text));

            if (isAdded)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

              showDataGridView.DataSource =  _itemManager.Display();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
              showDataGridView.DataSource =  _itemManager.Display();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }

            //Delete
            if (_itemManager.Delete(Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }

             showDataGridView.DataSource = _itemManager.Display();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _itemManager.Search(nameTextBox.Text);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //Check Unique
            if (_itemManager.IsNameExists(nameTextBox.Text))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exists!");
                return;
            }  

            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }

            if (_itemManager.Update(nameTextBox.Text, Convert.ToDouble(priceTextBox.Text), Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Updated");
                  showDataGridView.DataSource = _itemManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
        }

   
        //Method
        
       
       
       
        
        private void Search(string name)
        {
          
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemUi_Load(object sender, EventArgs e)
        {

        }

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customer_show_button_Click(object sender, EventArgs e)
        {
            new CustomerUi().Show();

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            new OrderUi().Show();
        }
    }
}
