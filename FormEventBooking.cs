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
    public partial class FormEventBooking : Form
    {
        public FormEventBooking()
        {
            InitializeComponent();
        }

        private void FormEventBooking_Load(object sender, EventArgs e)
        {

        }

        private void buttonAcceptPAyment_Click(object sender, EventArgs e)
        {
            FormPayment frmObj = new FormPayment();
            frmObj.ShowDialog();
        }
    }
}
