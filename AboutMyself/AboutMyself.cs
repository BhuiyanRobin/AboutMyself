using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AboutMyself
{
    public partial class AboutMyselfUI : Form
    {
        private string firstName;
        private string lastName;
        private string fathersName;
        private string mothersName;
        private string address;
        public AboutMyselfUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            fathersName = fathersNameTextBox.Text;
            mothersName = mothersNameTextBox.Text;
            address = addressTextBox.Text;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            fathersNameTextBox.Text = string.Empty;
            mothersNameTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
            MessageBox.Show("Information has been saved in memory.");
        }

        private void showAllInfoButton_Click(object sender, EventArgs e)
        {
            //firstNameTextBox.Text = firstName;
            //lastNameTextBox.Text = lastName;
            //fathersNameTextBox.Text = fathersName;
            //mothersNameTextBox.Text = mothersName;
            //addressTextBox.Text = address;
            MessageBox.Show("My All Information "+"\nFirst Name: " + firstName + "\nLast Name: " + lastName + "\nFather's Name: " + fathersName + "\nMother's Name: " + mothersName + "\nAddress: " + address);
        }

        private void showNameButton_Click(object sender, EventArgs e)
        {
            //firstNameTextBox.Text = firstName;
            //lastNameTextBox.Text = lastName;
            //fathersNameTextBox.Text = string.Empty;
            //mothersNameTextBox.Text = string.Empty;
            //addressTextBox.Text = string.Empty;
            MessageBox.Show("My Name " + "\nFirst Name: " + firstName + "\nLast Name: " + lastName);
        }

        private void showParentsNameButton_Click(object sender, EventArgs e)
        {
            //firstNameTextBox.Text = string.Empty;
            //lastNameTextBox.Text = string.Empty;
            //fathersNameTextBox.Text = fathersName;
            //mothersNameTextBox.Text = mothersName;
            //addressTextBox.Text = string.Empty;
            MessageBox.Show("My Parents Name " + "\nFather's Name: " + fathersName + "\nMother's Name: " + mothersName);
        }

        private void showAddressButton_Click(object sender, EventArgs e)
        {
            //firstNameTextBox.Text = string.Empty;
            //lastNameTextBox.Text = string.Empty;
            //fathersNameTextBox.Text = string.Empty;
            //mothersNameTextBox.Text = string.Empty;
            //addressTextBox.Text = address;
            MessageBox.Show("My Address " + "\nAddress: " + address);
        }
    }
}
