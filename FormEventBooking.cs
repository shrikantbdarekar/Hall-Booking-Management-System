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
    public partial class FormEventBooking : Form
    {
        bool IsLoaded = false;

        private int EventBookingId;
        private EventBooking EventBookingObj;
        private DALEventBookings DALEventBooking;

        private DALBookingPackages DALBookingPackage;
        private DALCustomers DALCustomerObj;
        private DALBookingTypes DALBookingType;
        private DALEventTypes DALEventType;
        public FormEventBooking(int OrderID)
        {
            InitializeComponent();

            this.EventBookingId = OrderID;

            EventBookingObj = new EventBooking();
            DALEventBooking = new DALEventBookings();

            DALBookingPackage = new DALBookingPackages();
            DALCustomerObj = new DALCustomers();
            DALBookingType = new DALBookingTypes();
            DALEventType = new DALEventTypes();
        }

        private void FormEventBooking_Load(object sender, EventArgs e)
        {
            comboBoxCustomerId.DataSource = DALCustomerObj.GetAllCustomers();
            comboBoxCustomerId.DisplayMember = "CustomerName";
            comboBoxCustomerId.ValueMember = "CustomerId";

            comboBoxPackageId.DataSource = DALBookingPackage.GetAllPackages();
            comboBoxPackageId.DisplayMember = "PackageName";
            comboBoxPackageId.ValueMember = "PackageId";

            comboBoxBookingTypeId.DataSource = DALBookingType.GetAllBookingTypes();
            comboBoxBookingTypeId.DisplayMember = "BookingTypeName";
            comboBoxBookingTypeId.ValueMember = "BookingTypeId";

            comboBoxEventTypeId.DataSource = DALEventType.GetAllEventTypes();
            comboBoxEventTypeId.DisplayMember = "EventTypeName";
            comboBoxEventTypeId.ValueMember = "EventTypeId";

            if (EventBookingId != 0)
            {
                EventBookingObj = DALEventBooking.GetEventBookingById(EventBookingId);

                dateTimePickerBookingDate.Value = EventBookingObj.BookingDate;
                dateTimePickerEventDate.Value = EventBookingObj.EventDate;
                comboBoxCustomerId.SelectedValue = EventBookingObj.CustomerId;
                comboBoxPackageId.SelectedValue = EventBookingObj.PackageId;
                comboBoxBookingTypeId.SelectedValue = EventBookingObj.BookingTypeId;
                comboBoxEventTypeId.SelectedValue = EventBookingObj.EventTypeId;
                textBoxEventName.Text = EventBookingObj.EventName;
                textBoxEventDescription.Text = EventBookingObj.EventDescription;
                textBoxPersonCount.Text = EventBookingObj.PersonCount.ToString();
                textBoxPackageAmount.Text = EventBookingObj.PackageAmount.ToString();
                textBoxDiscountAmount.Text = EventBookingObj.DiscountAmount.ToString();
                textBoxFinalAmount.Text = EventBookingObj.FinalAmount.ToString();
                textBoxRemark.Text = EventBookingObj.Remark;
                textBoxReceivedAmount.Text = EventBookingObj.ReceivedAmount.ToString();
            }
            else
            {
                textBoxDiscountAmount.Text = "0";
                textBoxFinalAmount.Text = "0";
                textBoxReceivedAmount.Text = "0";
            }

            IsLoaded = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                EventBookingObj.BookingDate = dateTimePickerBookingDate.Value;
                EventBookingObj.EventDate = dateTimePickerEventDate.Value;
                EventBookingObj.CustomerId = Convert.ToInt32(comboBoxCustomerId.SelectedValue);
                EventBookingObj.PackageId = Convert.ToInt32(comboBoxPackageId.SelectedValue);
                EventBookingObj.BookingTypeId = Convert.ToInt32(comboBoxBookingTypeId.SelectedValue);
                EventBookingObj.EventTypeId = Convert.ToInt32(comboBoxEventTypeId.SelectedValue);
                EventBookingObj.EventName = textBoxEventName.Text;
                EventBookingObj.EventDescription = textBoxEventDescription.Text;
                EventBookingObj.PersonCount = Convert.ToInt32(textBoxPersonCount.Text);
                EventBookingObj.PackageAmount = Convert.ToDecimal(textBoxPackageAmount.Text);
                EventBookingObj.DiscountAmount = Convert.ToDecimal(textBoxDiscountAmount.Text);
                EventBookingObj.FinalAmount = Convert.ToDecimal(textBoxFinalAmount.Text);
                EventBookingObj.Remark = textBoxRemark.Text;
                EventBookingObj.ReceivedAmount = Convert.ToDecimal(textBoxReceivedAmount.Text);

                if (EventBookingId == 0)
                {
                    DALEventBooking.InsertEventBooking(EventBookingObj);
                }
                else
                {
                    DALEventBooking.UpdateEventBooking(EventBookingObj);
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

        private void buttonAcceptPAyment_Click(object sender, EventArgs e)
        {
            FormPayment frmObj = new FormPayment(0, EventBookingId);
            frmObj.ShowDialog();
        }

        private void comboBoxPackageId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                BookingPackage BookingPackageObj = (BookingPackage)comboBoxPackageId.SelectedItem;
                textBoxEventDescription.Text = BookingPackageObj.PackageDescription;
                textBoxFinalAmount.Text = textBoxPackageAmount.Text = BookingPackageObj.PackageAmount.ToString();
                textBoxDiscountAmount.Text = "0";
            }
        }

        private void textBoxDiscountAmount_TextChanged(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                decimal PackageAmount = Convert.ToDecimal(textBoxPackageAmount.Text);
                decimal DiscountAmount = Convert.ToDecimal(textBoxDiscountAmount.Text);
                decimal FinalAmount = PackageAmount - DiscountAmount;
                textBoxFinalAmount.Text = FinalAmount.ToString();
            }
        }
    }
}

