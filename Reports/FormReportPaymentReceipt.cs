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

namespace HallBookingManagementSystem.Reports
{
    public partial class FormReportPaymentReceipt : Form
    {
        public FormReportPaymentReceipt()
        {
            InitializeComponent();
        }

        private void FormReportPaymentReceipt_Load(object sender, EventArgs e)
        {
            DALVenueSettings DALVenueSetting = new DALVenueSettings();
            //DALCustomers DALCustomerObj = new DALCustomers();

            VenueSetting VenueSettingObj = DALVenueSetting.GetVenueSettingById(Properties.Settings.Default.VenueId);
            //List<Customer> customers = DALCustomerObj.GetAllCustomers();

            CrystalReportPaymentReceipt rptObj = new CrystalReportPaymentReceipt();
            // First: set DataSource for report document
            //rptObj.SetDataSource(customers);
            // Second: Add values for report parameters.
            rptObj.ParameterFields["VenueName"].CurrentValues.AddValue(VenueSettingObj.VenueName);
            rptObj.ParameterFields["VenueAddress"].CurrentValues.AddValue(VenueSettingObj.VenueAddress);
            rptObj.ParameterFields["MobileNo"].CurrentValues.AddValue(VenueSettingObj.MobileNumber);
            rptObj.ParameterFields["Email"].CurrentValues.AddValue(VenueSettingObj.Email);
            rptObj.ParameterFields["Website"].CurrentValues.AddValue(VenueSettingObj.Website);

            crystalReportViewerMain.ReportSource = rptObj;
        }
    }
}
