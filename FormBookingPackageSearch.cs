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
    public partial class FormBookingPackageSearch : Form
    {
        public DALBookingPackages DALBookingPackage;
        public DALHalls DALHall;
        public FormBookingPackageSearch()
        {
            InitializeComponent();

            DALBookingPackage = new DALBookingPackages();
            DALHall = new DALHalls();
            dataGridViewBookingPackage.AutoGenerateColumns = false;
        }

        private void FormBookingTypeSearch_Load(object sender, EventArgs e)
        {
            dgcHallId.DataSource = DALHall.GetAllHalls();
            dgcHallId.DisplayMember = "HallName";
            dgcHallId.ValueMember = "HallId";

            LoadData();
        }

        private void LoadData()
        {
            // Show all records to gridview
            dataGridViewBookingPackage.DataSource = DALBookingPackage.GetAllPackages();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormBookingPackage frmObj = new FormBookingPackage(0);
            frmObj.ShowDialog();

            LoadData();
        }

        private void dataGridViewBookingPackage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgcEdit.Index || e.ColumnIndex == dgcDelete.Index)
            {
                int BookingPackageId = Convert.ToInt32(dataGridViewBookingPackage.CurrentRow.Cells[dgcPackageId.Name].Value);

                if (e.ColumnIndex == dgcEdit.Index)
                {
                    // Edit record
                    FormBookingPackage FormObj = new FormBookingPackage(BookingPackageId);
                    FormObj.ShowDialog();
                }
                else if (e.ColumnIndex == dgcDelete.Index)
                {
                    if (MessageBox.Show("Do you want to Delete this record ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Delete record.
                        DALBookingPackage.DeletePackage(BookingPackageId);
                    }
                }

                LoadData();
            }
        }
    }
}
