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
    public partial class FormUser : Form
    {
        private int UserID;
        private User UserObj;
        private DALUsers DALUserObj;

        public FormUser(int UserId)
        {
            InitializeComponent();

            this.UserID = UserId;

            UserObj = new User();
            DALUserObj = new DALUsers();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            if (UserID != 0)
            {
                UserObj = DALUserObj.GetUserById(UserID);

                textBoxUserName.Text = UserObj.UserName;
                textBoxPassword.Text = UserObj.PasswordHash;
                comboBoxRole.Text = UserObj.UserRole;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                UserObj.UserName = textBoxUserName.Text;
                UserObj.PasswordHash = textBoxPassword.Text;
                UserObj.UserRole = comboBoxRole.Text;

                if (UserID == 0)
                {
                    DALUserObj.InsertUser(UserObj);
                }
                else
                {
                    DALUserObj.UpdateUser(UserObj);
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
