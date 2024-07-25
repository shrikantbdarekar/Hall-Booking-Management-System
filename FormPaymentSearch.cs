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
    public partial class FormPaymentSearch : Form
    {
        public DALPayments DALPayment;
        public DALEventBookings DALEventBooking;

        public FormPaymentSearch()
        {
            InitializeComponent();

            DALPayment = new DALPayments();
            DALEventBooking = new DALEventBookings();
            dataGridViewPayments.AutoGenerateColumns = false;
        }

        private void FormPaymentSearch_Load(object sender, EventArgs e)
        {
            dgcEventBookingId.DataSource = DALEventBooking.GetAllEventBookings();
            dgcEventBookingId.DisplayMember = "EventName";
            dgcEventBookingId.ValueMember = "EventBookingId";

            LoadData();
        }

        private void LoadData()
        {
            // Show all records to gridview
            dataGridViewPayments.DataSource = DALPayment.GetAllPayments();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormPayment frmObj = new FormPayment(0,0);
            frmObj.ShowDialog();

            LoadData();
        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgcEdit.Index || e.ColumnIndex == dgcDelete.Index)
            {
                int PaymentId = Convert.ToInt32(dataGridViewPayments.CurrentRow.Cells[dgcPaymentId.Name].Value);
                int PaymentAmount = Convert.ToInt32(dataGridViewPayments.CurrentRow.Cells[dgcPaymentAmount.Name].Value);

                if (e.ColumnIndex == dgcEdit.Index)
                {
                    // Edit record
                    FormPayment FormObj = new FormPayment(PaymentId, 0);
                    FormObj.ShowDialog();
                }
                else if (e.ColumnIndex == dgcDelete.Index)
                {
                    if (MessageBox.Show("Do you want to Delete this record ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Delete record.
                        DALPayment.DeletePayment(PaymentId);
                        DALEventBooking.UpdateEventBookingReceivedAmountReset(PaymentId, PaymentAmount);
                    }
                }

                LoadData();
            }
        }

        private void buttonPrintReceipt_Click(object sender, EventArgs e)
        {
            Reports.FormReportPaymentReceipt frmObj = new Reports.FormReportPaymentReceipt();
            frmObj.ShowDialog();
        }
    }
}
