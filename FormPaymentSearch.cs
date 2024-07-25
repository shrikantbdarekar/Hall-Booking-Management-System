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
        public FormPaymentSearch()
        {
            InitializeComponent();
        }

        private void FormPaymentSearch_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormPayment frmObj = new FormPayment();
            frmObj.ShowDialog();
        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonPrintReceipt_Click(object sender, EventArgs e)
        {
            Reports.FormReportPaymentReceipt frmObj = new Reports.FormReportPaymentReceipt();
            frmObj.ShowDialog();
        }
    }
}
