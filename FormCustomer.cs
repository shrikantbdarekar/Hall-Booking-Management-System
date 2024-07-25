using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HallBookingManagementSystem.MyClasses;

namespace HallBookingManagementSystem
{
    public partial class FormCustomer : Form
    {
        private int CustomerId;
        private Customer CustomerObj;
        private DALCustomers DALCustomer;

        public FormCustomer(int CustomerId)
        {
            InitializeComponent();

            this.CustomerId = CustomerId;

            CustomerObj = new Customer();
            DALCustomer = new DALCustomers();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            if (CustomerId != 0)
            {
                CustomerObj = DALCustomer.GetCustomerById(CustomerId);

                textBoxCustomerName.Text = CustomerObj.CustomerName;
                textBoxCustomerAddress.Text = CustomerObj.CustomerAddress;
                textBoxContactNo.Text = CustomerObj.MobileNumber;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerObj.CustomerName = textBoxCustomerName.Text;
                CustomerObj.CustomerAddress = textBoxCustomerAddress.Text;
                CustomerObj.MobileNumber = textBoxContactNo.Text;

                if (CustomerId == 0)
                {
                    DALCustomer.InsertCustomer(CustomerObj);
                }
                else
                {
                    DALCustomer.UpdateCustomer(CustomerObj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
