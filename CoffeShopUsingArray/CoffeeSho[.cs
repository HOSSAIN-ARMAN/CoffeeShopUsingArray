using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopUsingArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            int arraySize = 1, quantity, countArrayIndex=0, totalAmount, customerContact;
            customerContact = Convert.ToInt32(contactTextBox.Text);
            quantity = Convert.ToInt32(quantityTextBox.Text);
            string[] customerInfo = new string[arraySize];
            if (countArrayIndex <= arraySize)
            {
                if (itemComboBox.Text == "Black-120")
                {
                    totalAmount = quantity * 120;
                    customerInfo[countArrayIndex] = "Name: "+nameTextBox.Text + "\nContact: "+customerContact +"\nAddress: "+ addressTextBox.Text+ "\nItem: "+itemComboBox.Text +"\nQuantity: "+ quantity +"Total Amount: "+ totalAmount+"tk\n\n-------------------";
                    
                }
                else if(itemComboBox.Text == "Clod-100")
                {
                    totalAmount = quantity * 100;
                    customerInfo[countArrayIndex] = "Name: " + nameTextBox.Text + "\nContact: " + customerContact + "\nAddress: " + addressTextBox.Text + "\nItem: " + itemComboBox.Text + "\nQuantity: " + quantity + "Total Amount: " + totalAmount + "tk\n\n---------------";
                   
                }else if (itemComboBox.Text == "Hot-90")
                {
                    totalAmount = quantity * 90;
                    customerInfo[countArrayIndex] = "Name: " + nameTextBox.Text + "\nContact: " + customerContact + "\nAddress: " + addressTextBox.Text + "\nItem: " + itemComboBox.Text + "\nQuantity: " + quantity + "Total Amount: " + totalAmount + "tk\n\n-------------------";
                    
                }
                else if (itemComboBox.Text == "Regular-80")
                {
                    totalAmount = quantity * 80;
                    customerInfo[countArrayIndex] = "Name: " + nameTextBox.Text + "\nContact: " + customerContact + "\nAddress: " + addressTextBox.Text + "\nItem: " + itemComboBox.Text + "\nQuantity: " + quantity + "Total Amount: " + totalAmount + "tk\n\n-------------------";

                }
                else
                {
                    MessageBox.Show("Please select Item");
                }
                countArrayIndex++;
            }
            else
            {
                MessageBox.Show("Array is full");
            }
            for(int i = 0; i<arraySize; i++)
            {
                saveConfirmationRichTextBox.Text += customerInfo[i];
            }
        }

    }
}
