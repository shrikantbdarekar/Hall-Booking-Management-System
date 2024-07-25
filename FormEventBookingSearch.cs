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
    public partial class FormEventBookingSearch : Form
    {
        public DALEventBookings DALEventBooking;
        public DALCustomers DALCustomer;
        public DALEventTypes DALEventType;
        public FormEventBookingSearch()
        {
            InitializeComponent();

            DALEventBooking = new DALEventBookings();
            DALCustomer = new DALCustomers();
            DALEventType = new DALEventTypes();

            dataGridViewEventBooking.AutoGenerateColumns = false;
        }

        private void FormBookingTypeSearch_Load(object sender, EventArgs e)
        {
            dgcCustomerId.DataSource = DALCustomer.GetAllCustomers();
            dgcCustomerId.DisplayMember = "CustomerName";
            dgcCustomerId.ValueMember = "CustomerId";

            dgcEventTypeId.DataSource = DALEventType.GetAllEventTypes();
            dgcEventTypeId.DisplayMember = "EventTypeName";
            dgcEventTypeId.ValueMember = "EventTypeId";

            LoadData();
        }

        private void LoadData()
        {
            // Show all records to gridview
            dataGridViewEventBooking.DataSource = DALEventBooking.GetAllEventBookings();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormEventBooking frmObj = new FormEventBooking(0);
            frmObj.ShowDialog();

            LoadData();
        }

        private void dataGridViewEventBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgcEdit.Index || e.ColumnIndex == dgcDelete.Index || e.ColumnIndex == dgcPayment.Index)
            {
                int EventBookingId = Convert.ToInt32(dataGridViewEventBooking.CurrentRow.Cells[dgcEventBookingId.Name].Value);

                if (e.ColumnIndex == dgcEdit.Index)
                {
                    // Edit record
                    FormEventBooking FormObj = new FormEventBooking(EventBookingId);
                    FormObj.ShowDialog();
                }
                else if (e.ColumnIndex == dgcDelete.Index)
                {
                    if (MessageBox.Show("Do you want to Delete this record ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Delete record.
                        DALEventBooking.DeleteEventBooking(EventBookingId);
                    }
                }
                else if (e.ColumnIndex == dgcPayment.Index)
                {
                    FormPayment frmObj = new FormPayment(0, EventBookingId);
                    frmObj.ShowDialog();
                }

                LoadData();
            }
        }
    }
}
