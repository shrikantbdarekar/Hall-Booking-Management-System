using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HallBookingManagementSystem.Reports;

namespace HallBookingManagementSystem
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {

        }

        private void mnuVenueDetails_Click(object sender, EventArgs e)
        {
            FormVenueDetails frmObj = new FormVenueDetails();
            frmObj.ShowDialog();
        }

        private void mnuBookingType_Click(object sender, EventArgs e)
        {
            FormBookingTypeSearch frmObj = new FormBookingTypeSearch();
            frmObj.ShowDialog();
        }

        private void mnuEventType_Click(object sender, EventArgs e)
        {
            FormEventTypeSearch frmObj = new FormEventTypeSearch();
            frmObj.ShowDialog();
        }

        private void mnuUsers_Click(object sender, EventArgs e)
        {
            FormUserSearch frmObj = new FormUserSearch();
            frmObj.ShowDialog();
        }

        private void mnuHall_Click(object sender, EventArgs e)
        {
            FormHallSearch frmObj = new FormHallSearch();
            frmObj.ShowDialog();
        }

        private void mnuBookingPackage_Click(object sender, EventArgs e)
        {
            FormBookingPackageSearch frmObj = new FormBookingPackageSearch();
            frmObj.ShowDialog();
        }

        private void mnuCustomer_Click(object sender, EventArgs e)
        {
            FormCustomerSearch frmObj = new FormCustomerSearch();
            frmObj.ShowDialog();
        }

        private void mnuEventBooking_Click(object sender, EventArgs e)
        {
            FormEventBookingSearch frmObj = new FormEventBookingSearch();
            frmObj.ShowDialog();
        }

        private void mnuPaymentCollection_Click(object sender, EventArgs e)
        {
            FormPaymentSearch frmObj = new FormPaymentSearch();
            frmObj.ShowDialog();
        }

        private void mnuCustomerReport_Click(object sender, EventArgs e)
        {
            FormReportCustomer frmObj = new FormReportCustomer();
            frmObj.ShowDialog();
        }

        private void mnuBookingReport_Click(object sender, EventArgs e)
        {
            FormReportBooking frmObj = new FormReportBooking();
            frmObj.ShowDialog();
        }

        private void mnuPaymentCollectionReport_Click(object sender, EventArgs e)
        {
            FormReportPaymentCollection frmObj = new FormReportPaymentCollection();
            frmObj.ShowDialog();
        }

        private void mnuDuePaymentReport_Click(object sender, EventArgs e)
        {
            FormReportDuePayment frmObj = new FormReportDuePayment();
            frmObj.ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
