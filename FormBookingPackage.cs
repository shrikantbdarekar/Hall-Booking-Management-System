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
    public partial class FormBookingPackage : Form
    {
        private int PackageId;
        private BookingPackage BookingPackageObj;
        private DALBookingPackages DALBookingPackage;
        private DALHalls DALHall;
        public FormBookingPackage(int PackageId)
        {
            InitializeComponent();

            this.PackageId = PackageId;

            BookingPackageObj = new BookingPackage();
            DALBookingPackage = new DALBookingPackages();
            DALHall = new DALHalls();
        }

        private void FormBookingPackage_Load(object sender, EventArgs e)
        {
            comboBoxHallName.DataSource = DALHall.GetAllHalls();
            comboBoxHallName.DisplayMember = "HallName";
            comboBoxHallName.ValueMember = "HallId";

            if (PackageId != 0)
            {
                BookingPackageObj = DALBookingPackage.GetPackageById(PackageId);

                textBoxPackageName.Text = BookingPackageObj.PackageName;
                comboBoxHallName.SelectedValue = BookingPackageObj.HallId;
                textBoxPackageAmount.Text = BookingPackageObj.PackageAmount.ToString();
                textBoxPackageDescription.Text = BookingPackageObj.PackageDescription;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                BookingPackageObj.PackageName = textBoxPackageName.Text;
                BookingPackageObj.HallId = Convert.ToInt32(comboBoxHallName.SelectedValue.ToString());
                BookingPackageObj.PackageAmount = Convert.ToInt32(textBoxPackageAmount.Text);
                BookingPackageObj.PackageDescription = textBoxPackageDescription.Text;

                if (PackageId == 0)
                {
                    DALBookingPackage.InsertPackage(BookingPackageObj);
                }
                else
                {
                    DALBookingPackage.UpdatePackage(BookingPackageObj);
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
