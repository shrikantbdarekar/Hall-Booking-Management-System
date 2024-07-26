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
    public partial class FormReportDuePayment : Form
    {
        public FormReportDuePayment()
        {
            InitializeComponent();
        }

        private void FormReportDuePayment_Load(object sender, EventArgs e)
        {
            DALVenueSettings DALVenueSetting = new DALVenueSettings();
            DALEventBookings DALEventBooking = new DALEventBookings();

            VenueSetting VenueSettingObj = DALVenueSetting.GetVenueSettingById(Properties.Settings.Default.VenueId);
            List<DueReport> dueReport = DALEventBooking.GetDueReport();

            CrystalReportDuePayments rptObj = new CrystalReportDuePayments();
            
            // First: set DataSource for report document
            rptObj.SetDataSource(dueReport);
            
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
