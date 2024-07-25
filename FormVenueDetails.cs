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
    public partial class FormVenueDetails : Form
    {
        private int VenueId;
        private VenueSetting VenueSettingObj;
        private DALVenueSettings DALVenueSetting;

        public FormVenueDetails()
        {
            InitializeComponent();

            VenueId = Properties.Settings.Default.VenueId;
            VenueSettingObj = new VenueSetting();
            DALVenueSetting = new DALVenueSettings();
        }

        private void FormVenueDetails_Load(object sender, EventArgs e)
        {
            if (VenueId != 0)
            {
                VenueSettingObj = DALVenueSetting.GetVenueSettingById(VenueId);

                textBoxVenueName.Text = VenueSettingObj.VenueName;
                textBoxVenueAddress.Text = VenueSettingObj.VenueAddress;
                textBoxEmail.Text = VenueSettingObj.Email;
                textBoxWebsite.Text = VenueSettingObj.Website;
                textBoxMobileNo.Text = VenueSettingObj.MobileNumber;
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                VenueSettingObj.VenueName = textBoxVenueName.Text;
                VenueSettingObj.VenueAddress = textBoxVenueAddress.Text;
                VenueSettingObj.Email = textBoxEmail.Text;
                VenueSettingObj.Website = textBoxWebsite.Text;
                VenueSettingObj.MobileNumber = textBoxMobileNo.Text;

                if (VenueId != 0)
                {
                    DALVenueSetting.UpdateVenueSetting(VenueSettingObj);
                }

                MessageBox.Show("Data updated succedssfully !!!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
