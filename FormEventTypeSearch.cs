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
    public partial class FormEventTypeSearch : Form
    {
        public DALEventTypes DALEventType;
        public FormEventTypeSearch()
        {
            InitializeComponent();

            DALEventType = new DALEventTypes();
            dataGridViewEventType.AutoGenerateColumns = false;
        }

        private void FormEventTypeSearch_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Show all records to gridview
            dataGridViewEventType.DataSource = DALEventType.GetAllEventTypes();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormEventType frmObj = new FormEventType(0);
            frmObj.ShowDialog();

            LoadData();
        }

        private void dataGridViewEventType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgcEdit.Index || e.ColumnIndex == dgcDelete.Index)
                {
                    int EventTypeId = Convert.ToInt32(dataGridViewEventType.CurrentRow.Cells[dgcEventTypeId.Name].Value);

                    if (e.ColumnIndex == dgcEdit.Index)
                    {
                        // Edit record
                        FormEventType FormObj = new FormEventType(EventTypeId);
                        FormObj.ShowDialog();
                    }
                    else if (e.ColumnIndex == dgcDelete.Index)
                    {
                        if (MessageBox.Show("Do you want to Delete this record ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            // Delete record.
                            DALEventType.DeleteEventType(EventTypeId);
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
