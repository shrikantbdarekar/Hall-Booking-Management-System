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
    public partial class FormPayment : Form
    {
        private bool IsLoaded = false;
        private int PaymentId, EventBookingId;
        private Payment PaymenteObj;
        private DALPayments DALPayment;
        private DALEventBookings DALEventBooking;

        public FormPayment(int PaymentId, int EventBookingId)
        {
            InitializeComponent();

            // PaymentId=XX and EventBookingId=0, when edit payment
            // PaymentId=0 and EventBookingId=xx, add payment against booking

            this.PaymentId = PaymentId;
            this.EventBookingId = EventBookingId;

            PaymenteObj = new Payment();
            DALPayment = new DALPayments();
            DALEventBooking = new DALEventBookings();
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            comboBoxEventBookingId.DataSource = DALEventBooking.GetEventBookingsDropDown();
            comboBoxEventBookingId.DisplayMember = "EventName";
            comboBoxEventBookingId.ValueMember = "EventBookingId";

            if (PaymentId != 0 && EventBookingId == 0)
            {
                PaymenteObj = DALPayment.GetPaymentById(PaymentId);

                dateTimePickerPaymentDate.Value = PaymenteObj.PaymentDate;
                comboBoxEventBookingId.SelectedValue = PaymenteObj.EventBookingId;
                textBoxDueAmount.Text = PaymenteObj.DueAmount.ToString();
                textBoxPaymentAmount.Text = PaymenteObj.PaymentAmount.ToString();
                textBoxBalanceAmount.Text = PaymenteObj.BalanceAmount.ToString();
                textBoxRemark.Text = PaymenteObj.Remark;
            }
            else if (PaymentId == 0 && EventBookingId != 0)
            {
                comboBoxEventBookingId.SelectedValue = EventBookingId;
                comboBoxEventBookingId.Enabled = false;
                textBoxDueAmount.Text = ((EventBookingDropDown)comboBoxEventBookingId.SelectedItem).DueAmount.ToString();
            }

            IsLoaded = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                PaymenteObj.PaymentDate = dateTimePickerPaymentDate.Value;
                PaymenteObj.EventBookingId = Convert.ToInt32(comboBoxEventBookingId.SelectedValue);
                PaymenteObj.DueAmount = Convert.ToDecimal(textBoxDueAmount.Text);
                PaymenteObj.PaymentAmount = Convert.ToDecimal(textBoxPaymentAmount.Text);
                PaymenteObj.BalanceAmount = Convert.ToDecimal(textBoxBalanceAmount.Text);
                PaymenteObj.Remark = textBoxRemark.Text;

                if (PaymentId == 0)
                {
                    DALPayment.InsertPayment(PaymenteObj);
                    DALEventBooking.UpdateEventBookingReceivedAmount(PaymenteObj.EventBookingId, PaymenteObj.PaymentAmount);
                }
                else
                {
                    DALPayment.UpdatePayment(PaymenteObj);
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

        private void comboBoxEventBookingId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                textBoxDueAmount.Text = ((EventBookingDropDown)comboBoxEventBookingId.SelectedItem).DueAmount.ToString();
            }
        }

        private void textBoxPaymentAmount_TextChanged(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                decimal DueAmount = Convert.ToDecimal(textBoxDueAmount.Text);
                decimal PaymentAmount = Convert.ToDecimal(textBoxPaymentAmount.Text);
                decimal BalanceAmount = DueAmount - PaymentAmount;
                textBoxBalanceAmount.Text = BalanceAmount.ToString();
            }
        }

        private void buttonPrintReceipt_Click(object sender, EventArgs e)
        {
            Reports.FormReportPaymentReceipt frmObj = new Reports.FormReportPaymentReceipt(PaymentId);
            frmObj.ShowDialog();
        }
    }
}
