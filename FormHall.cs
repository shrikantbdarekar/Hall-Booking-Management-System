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
    public partial class FormHall : Form
    {
        private int HallId;
        private Hall HallObj;
        private DALHalls DALHall;
        public FormHall(int HallId)
        {
            InitializeComponent();

            this.HallId = HallId;

            HallObj = new Hall();
            DALHall = new DALHalls();
        }

        private void FormHall_Load(object sender, EventArgs e)
        {
            if (HallId != 0)
            {
                HallObj = DALHall.GetHallById(HallId);

                textBoxHallName.Text = HallObj.HallName;
                textBoxHallDescription.Text = HallObj.HallDescription;
                textBoxHallCapacity.Text = HallObj.HallCapacity.ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                HallObj.HallName = textBoxHallName.Text;
                HallObj.HallDescription = textBoxHallDescription.Text;
                HallObj.HallCapacity = Convert.ToInt32(textBoxHallCapacity);

                if (HallId == 0)
                {
                    DALHall.InsertHall(HallObj);
                }
                else
                {
                    DALHall.UpdateHall(HallObj);
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
