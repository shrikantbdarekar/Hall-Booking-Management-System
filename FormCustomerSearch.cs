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
    public partial class FormCustomerSearch : Form
    {
        public DALCustomers DALCustomer;
        public FormCustomerSearch()
        {
            InitializeComponent();

            DALCustomer = new DALCustomers();
            dataGridViewCustomers.AutoGenerateColumns = false;
        }

        private void FormCustomerSearch_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Show all records to gridview
            dataGridViewCustomers.DataSource = DALCustomer.GetAllCustomers();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormCustomer frmObj = new FormCustomer(0);
            frmObj.ShowDialog();

            LoadData();
        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgcEdit.Index || e.ColumnIndex == dgcDelete.Index)
                {
                    int CustomerId = Convert.ToInt32(dataGridViewCustomers.CurrentRow.Cells[dgcCustomerId.Name].Value);

                    if (e.ColumnIndex == dgcEdit.Index)
                    {
                        // Edit record
                        FormCustomer FormObj = new FormCustomer(CustomerId);
                        FormObj.ShowDialog();
                    }
                    else if (e.ColumnIndex == dgcDelete.Index)
                    {
                        if (MessageBox.Show("Do you want to Delete this record ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            // Delete record.
                            DALCustomer.DeleteCustomer(CustomerId);
                        }
                    }

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
