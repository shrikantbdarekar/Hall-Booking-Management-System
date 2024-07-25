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
        private int PaymentId;
        public FormReportPaymentReceipt(int PayMentId)
        {
            InitializeComponent();

            this.PaymentId = PayMentId;
        }

        private void FormReportPaymentReceipt_Load(object sender, EventArgs e)
        {
            DALVenueSettings DALVenueSetting = new DALVenueSettings();
            DALPayments DALPayment = new DALPayments();
            DALEventBookings DALEventBooking = new DALEventBookings();
            DALCustomers DALCustomer = new DALCustomers();
            DALBookingTypes DALBookingType = new DALBookingTypes();

            VenueSetting VenueSettingObj = DALVenueSetting.GetVenueSettingById(Properties.Settings.Default.VenueId);
            //List<Customer> customers = DALCustomerObj.GetAllCustomers();

            Payment PaymentObj = DALPayment.GetPaymentById(PaymentId);
            EventBooking EventBookingObj = DALEventBooking.GetEventBookingById(PaymentObj.EventBookingId);
            Customer CustomerObj = DALCustomer.GetCustomerById(EventBookingObj.CustomerId);

            string BookingTypeName = DALBookingType.GetBookingTypeById(EventBookingObj.BookingTypeId).BookingTypeName;

            PaymentReceiptDataTable BillReportDataTableObj = new PaymentReceiptDataTable();
            DataSet dsObj = new DataSet("DataSetHallBookingDB");

            DataTable dtPayments = BillReportDataTableObj.DTPayments;
            DataTable dtEventBookings = BillReportDataTableObj.DTEventBookings;
            DataTable dtCustomers = BillReportDataTableObj.DTCustomers;

            // Adding a row to the DataTable Sale
            dtPayments.Rows.Add(PaymentObj.PaymentId,PaymentObj.PaymentDate,PaymentObj.EventBookingId,
                PaymentObj.DueAmount,PaymentObj.PaymentAmount,PaymentObj.BalanceAmount,PaymentObj.Remark);

            // Adding a row to the DataTable SaleDetails
            dtEventBookings.Rows.Add(EventBookingObj.EventBookingId, EventBookingObj.BookingDate, EventBookingObj.CustomerId,
                EventBookingObj.PackageId, EventBookingObj.BookingTypeId, EventBookingObj.EventDate, EventBookingObj.EventName,
                EventBookingObj.EventTypeId, EventBookingObj.EventDescription, EventBookingObj.PersonCount, EventBookingObj.ReceivedAmount,
                EventBookingObj.PackageAmount, EventBookingObj.DiscountAmount, EventBookingObj.FinalAmount, EventBookingObj.ReceivedAmount);

            // Adding a row to the DataTable Customers
            dtCustomers.Rows.Add(CustomerObj.CustomerId, CustomerObj.CustomerName, CustomerObj.MobileNumber, CustomerObj.CustomerAddress);

            dsObj.Tables.Add(dtPayments.Copy());
            dsObj.Tables.Add(dtEventBookings.Copy());
            dsObj.Tables.Add(dtCustomers.Copy());

            CrystalReportPaymentReceipt rptObj = new CrystalReportPaymentReceipt();
            // First: set DataSource for report document
            rptObj.SetDataSource(dsObj);
            // Second: Add values for report parameters.
            rptObj.ParameterFields["VenueName"].CurrentValues.AddValue(VenueSettingObj.VenueName);
            rptObj.ParameterFields["VenueAddress"].CurrentValues.AddValue(VenueSettingObj.VenueAddress);
            rptObj.ParameterFields["MobileNo"].CurrentValues.AddValue(VenueSettingObj.MobileNumber);
            rptObj.ParameterFields["Email"].CurrentValues.AddValue(VenueSettingObj.Email);
            rptObj.ParameterFields["Website"].CurrentValues.AddValue(VenueSettingObj.Website);
            rptObj.ParameterFields["BookingTypeName"].CurrentValues.AddValue(BookingTypeName);

            crystalReportViewerMain.ReportSource = rptObj;
        }
    }

    public class PaymentReceiptDataTable
    {
        public DataTable DTEventBookings
        {
            get
            {
                DataTable dtSale = new DataTable("EventBookings");
                dtSale.Columns.Add("EventBookingId", typeof(int));
                dtSale.Columns.Add("BookingDate", typeof(DateTime));
                dtSale.Columns.Add("CustomerId", typeof(int));
                dtSale.Columns.Add("PackageId", typeof(int));
                dtSale.Columns.Add("BookingTypeId", typeof(int));
                dtSale.Columns.Add("EventDate", typeof(DateTime));
                dtSale.Columns.Add("EventName", typeof(string));
                dtSale.Columns.Add("EventTypeId", typeof(int));
                dtSale.Columns.Add("EventDescription", typeof(string));
                dtSale.Columns.Add("PersonCount", typeof(int));
                dtSale.Columns.Add("Remark", typeof(string));
                dtSale.Columns.Add("PackageAmount", typeof(decimal));
                dtSale.Columns.Add("DiscountAmount", typeof(decimal));
                dtSale.Columns.Add("FinalAmount", typeof(decimal));
                dtSale.Columns.Add("ReceivedAmount", typeof(decimal));
                return dtSale.Copy();
            }
        }

        public DataTable DTPayments
        {
            get
            {
                DataTable dtPayments = new DataTable("Payments");
                dtPayments.Columns.Add("PaymentId", typeof(int));
                dtPayments.Columns.Add("PaymentDate", typeof(DateTime));
                dtPayments.Columns.Add("EventBookingId", typeof(int));
                dtPayments.Columns.Add("DueAmount", typeof(decimal));
                dtPayments.Columns.Add("PaymentAmount", typeof(decimal));
                dtPayments.Columns.Add("BalanceAmount", typeof(decimal));
                dtPayments.Columns.Add("Remark", typeof(string));
                return dtPayments.Copy();
            }
        }

        public DataTable DTCustomers
        {
            get
            {
                DataTable dtCustomers = new DataTable("Customers");
                dtCustomers.Columns.Add("CustomerID", typeof(int));
                dtCustomers.Columns.Add("CustomerName", typeof(string));
                dtCustomers.Columns.Add("ContactNo", typeof(string));
                dtCustomers.Columns.Add("CustomerAddress", typeof(string));
                return dtCustomers.Copy();
            }
        }
    }
}
