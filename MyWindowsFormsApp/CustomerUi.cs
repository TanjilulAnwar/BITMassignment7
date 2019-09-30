using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWindowsFormsApp.BLL;

namespace MyWindowsFormsApp
{
    
    public partial class CustomerUi : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        public CustomerUi()
        {
            InitializeComponent();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _customerManager.Display();

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            //Check UNIQUE
            if (_customerManager.IsNameExists(nameTextBox.Text))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exists!");
                return;
            }

            //Set Price as Mandatory
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("name Can not be Empty!!!");
                return;
            }

            //Add/Insert Item
            bool isAdded = _customerManager.Add(nameTextBox.Text, phoneTextBox.Text, addressTextBox.Text);

            if (isAdded)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

           // showDataGridView.DataSource = _itemManager.Display();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            
            
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(phoneTextBox.Text))
            {
                MessageBox.Show("Phone Can not be Empty!!!");
                return;
            }

            if (_customerManager.Update(nameTextBox.Text, phoneTextBox.Text,addressTextBox.Text, Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Updated");
               // showDataGridView.DataSource = _customerManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {

            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }

            //Delete
            if (_customerManager.Delete(Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }

           // showDataGridView.DataSource = _itemManager.Display();
        }
    }
}
