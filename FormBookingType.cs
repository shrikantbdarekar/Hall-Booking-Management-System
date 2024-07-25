using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HallBookingManagementSystem.MyClasses;

namespace HallBookingManagementSystem
{
    public partial class FormBookingType : Form
    {
        private int BookingTypeId;
        private BookingType BookingTypeObj;
        private DALBookingTypes DALBookingType;

        public FormBookingType(int BookingTypeId)
        {
            InitializeComponent();

            this.BookingTypeId = BookingTypeId;

            BookingTypeObj = new BookingType();
            DALBookingType = new DALBookingTypes();
        }

        private void FormBookingType_Load(object sender, EventArgs e)
        {
            if (BookingTypeId != 0)
            {
                BookingTypeObj = DALBookingType.GetBookingTypeById(BookingTypeId);

                textBoxBookingTypeName.Text = BookingTypeObj.BookingTypeName;
                textBoxBookingTypeDescription.Text = BookingTypeObj.BookingTypeDescription;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                BookingTypeObj.BookingTypeName = textBoxBookingTypeName.Text;
                BookingTypeObj.BookingTypeDescription = textBoxBookingTypeDescription.Text;

                if (BookingTypeId == 0)
                {
                    DALBookingType.InsertBookingType(BookingTypeObj);
                }
                else
                {
                    DALBookingType.UpdateBookingType(BookingTypeObj);
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
    }
}
