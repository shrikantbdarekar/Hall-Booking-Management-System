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
    public partial class FormEventType : Form
    {
        private int EventTypeId;
        private EventType EventTypeObj;
        private DALEventTypes DALEventType;

        public FormEventType(int EventTypeId)
        {
            InitializeComponent();

            this.EventTypeId = EventTypeId;

            EventTypeObj = new EventType();
            DALEventType = new DALEventTypes();
        }

        private void FormEventType_Load(object sender, EventArgs e)
        {
            if (EventTypeId != 0)
            {
                EventTypeObj = DALEventType.GetEventTypeById(EventTypeId);

                textBoxEventTypeName.Text = EventTypeObj.EventTypeName;
                textBoxEventTypeDescription.Text = EventTypeObj.EventTypeDescription;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                EventTypeObj.EventTypeName = textBoxEventTypeName.Text;
                EventTypeObj.EventTypeDescription = textBoxEventTypeDescription.Text;

                if (EventTypeId == 0)
                {
                    DALEventType.InsertEventType(EventTypeObj);
                }
                else
                {
                    DALEventType.UpdateEventType(EventTypeObj);
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
