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
    public partial class FormBookingTypeSearch : Form
    {
        public DALBookingTypes DALBookingType;
        public FormBookingTypeSearch()
        {
            InitializeComponent();

            DALBookingType = new DALBookingTypes();
            dataGridViewBookingType.AutoGenerateColumns = false;
        }

        private void FormBookingTypeSearch_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Show all records to gridview
            dataGridViewBookingType.DataSource = DALBookingType.GetAllBookingTypes();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormBookingType frmObj = new FormBookingType(0);
            frmObj.ShowDialog();

            LoadData();
        }

        private void dataGridViewBookingType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgcEdit.Index || e.ColumnIndex == dgcDelete.Index)
                {
                    int BookingTypeId = Convert.ToInt32(dataGridViewBookingType.CurrentRow.Cells[dgcBookingTypeId.Name].Value);

                    if (e.ColumnIndex == dgcEdit.Index)
                    {
                        // Edit record
                        FormBookingType FormObj = new FormBookingType(BookingTypeId);
                        FormObj.ShowDialog();
                    }
                    else if (e.ColumnIndex == dgcDelete.Index)
                    {
                        if (MessageBox.Show("Do you want to Delete this record ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            // Delete record.
                            DALBookingType.DeleteBookingType(BookingTypeId);
                        }
                    }

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
