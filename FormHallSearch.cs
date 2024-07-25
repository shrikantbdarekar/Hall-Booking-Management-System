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
    public partial class FormHallSearch : Form
    {
        public DALHalls DALHall;
        public FormHallSearch()
        {
            InitializeComponent();

            DALHall = new DALHalls();
            dataGridViewHall.AutoGenerateColumns = false;
        }

        private void FormHallSearch_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Show all records to gridview
            dataGridViewHall.DataSource = DALHall.GetAllHalls();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormHall frmObj = new FormHall(0);
            frmObj.ShowDialog();

            LoadData();
        }

        private void dataGridViewHalls_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgcEdit.Index || e.ColumnIndex == dgcDelete.Index)
                {
                    int HallId = Convert.ToInt32(dataGridViewHalls.CurrentRow.Cells[dgcHallId.Name].Value);

                    if (e.ColumnIndex == dgcEdit.Index)
                    {
                        // Edit record
                        FormHall FormObj = new FormHall(HallId);
                        FormObj.ShowDialog();
                    }
                    else if (e.ColumnIndex == dgcDelete.Index)
                    {
                        if (MessageBox.Show("Do you want to Delete this record ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            // Delete record.
                            DALHall.DeleteHall(HallId);
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
