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
    public partial class FormEventBookingSearch : Form
    {
        public FormEventBookingSearch()
        {
            InitializeComponent();
        }

        private void FormBookingTypeSearch_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormEventBooking frmObj = new FormEventBooking();
            frmObj.ShowDialog();
        }
    }
}
