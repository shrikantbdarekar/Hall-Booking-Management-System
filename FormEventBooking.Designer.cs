
namespace HallBookingManagementSystem
{
    partial class FormEventBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonAcceptPAyment = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxFinalAmount = new System.Windows.Forms.TextBox();
            this.labelFinalAmount = new System.Windows.Forms.Label();
            this.textBoxDiscountAmount = new System.Windows.Forms.TextBox();
            this.labelDiscountAmount = new System.Windows.Forms.Label();
            this.textBoxPackageAmount = new System.Windows.Forms.TextBox();
            this.labelPackageAmount = new System.Windows.Forms.Label();
            this.comboBoxEventTypeId = new System.Windows.Forms.ComboBox();
            this.labelEventTypeId = new System.Windows.Forms.Label();
            this.comboBoxBookingTypeId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPackageId = new System.Windows.Forms.ComboBox();
            this.textBoxReceivedAmount = new System.Windows.Forms.TextBox();
            this.labelReceivedAmount = new System.Windows.Forms.Label();
            this.textBoxPersonCount = new System.Windows.Forms.TextBox();
            this.labelPersonCount = new System.Windows.Forms.Label();
            this.textBoxEventDescription = new System.Windows.Forms.TextBox();
            this.labelEventDescription = new System.Windows.Forms.Label();
            this.textBoxEventName = new System.Windows.Forms.TextBox();
            this.labelEventName = new System.Windows.Forms.Label();
            this.labelBookingDate = new System.Windows.Forms.Label();
            this.dateTimePickerBookingDate = new System.Windows.Forms.DateTimePicker();
            this.labelBookingTypeId = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelPackageId = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.comboBoxCustomerId = new System.Windows.Forms.ComboBox();
            this.textBoxRemark = new System.Windows.Forms.TextBox();
            this.labelRemark = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.textBoxRemark);
            this.panelMain.Controls.Add(this.labelRemark);
            this.panelMain.Controls.Add(this.buttonAcceptPAyment);
            this.panelMain.Controls.Add(this.label11);
            this.panelMain.Controls.Add(this.textBoxFinalAmount);
            this.panelMain.Controls.Add(this.labelFinalAmount);
            this.panelMain.Controls.Add(this.textBoxDiscountAmount);
            this.panelMain.Controls.Add(this.labelDiscountAmount);
            this.panelMain.Controls.Add(this.textBoxPackageAmount);
            this.panelMain.Controls.Add(this.labelPackageAmount);
            this.panelMain.Controls.Add(this.comboBoxEventTypeId);
            this.panelMain.Controls.Add(this.labelEventTypeId);
            this.panelMain.Controls.Add(this.comboBoxBookingTypeId);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.dateTimePicker1);
            this.panelMain.Controls.Add(this.comboBoxPackageId);
            this.panelMain.Controls.Add(this.textBoxReceivedAmount);
            this.panelMain.Controls.Add(this.labelReceivedAmount);
            this.panelMain.Controls.Add(this.textBoxPersonCount);
            this.panelMain.Controls.Add(this.labelPersonCount);
            this.panelMain.Controls.Add(this.textBoxEventDescription);
            this.panelMain.Controls.Add(this.labelEventDescription);
            this.panelMain.Controls.Add(this.textBoxEventName);
            this.panelMain.Controls.Add(this.labelEventName);
            this.panelMain.Controls.Add(this.labelBookingDate);
            this.panelMain.Controls.Add(this.dateTimePickerBookingDate);
            this.panelMain.Controls.Add(this.labelBookingTypeId);
            this.panelMain.Controls.Add(this.buttonCancel);
            this.panelMain.Controls.Add(this.buttonSave);
            this.panelMain.Controls.Add(this.labelPackageId);
            this.panelMain.Controls.Add(this.labelCustomerName);
            this.panelMain.Controls.Add(this.comboBoxCustomerId);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(639, 423);
            this.panelMain.TabIndex = 0;
            // 
            // buttonAcceptPAyment
            // 
            this.buttonAcceptPAyment.Location = new System.Drawing.Point(480, 380);
            this.buttonAcceptPAyment.Name = "buttonAcceptPAyment";
            this.buttonAcceptPAyment.Size = new System.Drawing.Size(126, 27);
            this.buttonAcceptPAyment.TabIndex = 30;
            this.buttonAcceptPAyment.Text = "Accept Payment";
            this.buttonAcceptPAyment.UseVisualStyleBackColor = true;
            this.buttonAcceptPAyment.Click += new System.EventHandler(this.buttonAcceptPAyment_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.LightGray;
            this.label11.Location = new System.Drawing.Point(164, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(441, 2);
            this.label11.TabIndex = 31;
            // 
            // textBoxFinalAmount
            // 
            this.textBoxFinalAmount.Location = new System.Drawing.Point(480, 308);
            this.textBoxFinalAmount.Name = "textBoxFinalAmount";
            this.textBoxFinalAmount.ReadOnly = true;
            this.textBoxFinalAmount.Size = new System.Drawing.Size(126, 24);
            this.textBoxFinalAmount.TabIndex = 25;
            // 
            // labelFinalAmount
            // 
            this.labelFinalAmount.AutoSize = true;
            this.labelFinalAmount.Location = new System.Drawing.Point(349, 311);
            this.labelFinalAmount.Name = "labelFinalAmount";
            this.labelFinalAmount.Size = new System.Drawing.Size(94, 18);
            this.labelFinalAmount.TabIndex = 24;
            this.labelFinalAmount.Text = "Final Amount";
            // 
            // textBoxDiscountAmount
            // 
            this.textBoxDiscountAmount.Location = new System.Drawing.Point(164, 308);
            this.textBoxDiscountAmount.Name = "textBoxDiscountAmount";
            this.textBoxDiscountAmount.Size = new System.Drawing.Size(126, 24);
            this.textBoxDiscountAmount.TabIndex = 19;
            // 
            // labelDiscountAmount
            // 
            this.labelDiscountAmount.AutoSize = true;
            this.labelDiscountAmount.Location = new System.Drawing.Point(33, 311);
            this.labelDiscountAmount.Name = "labelDiscountAmount";
            this.labelDiscountAmount.Size = new System.Drawing.Size(122, 18);
            this.labelDiscountAmount.TabIndex = 18;
            this.labelDiscountAmount.Text = "Discount Amount";
            // 
            // textBoxPackageAmount
            // 
            this.textBoxPackageAmount.Location = new System.Drawing.Point(480, 278);
            this.textBoxPackageAmount.Name = "textBoxPackageAmount";
            this.textBoxPackageAmount.ReadOnly = true;
            this.textBoxPackageAmount.Size = new System.Drawing.Size(126, 24);
            this.textBoxPackageAmount.TabIndex = 23;
            // 
            // labelPackageAmount
            // 
            this.labelPackageAmount.AutoSize = true;
            this.labelPackageAmount.Location = new System.Drawing.Point(349, 281);
            this.labelPackageAmount.Name = "labelPackageAmount";
            this.labelPackageAmount.Size = new System.Drawing.Size(121, 18);
            this.labelPackageAmount.TabIndex = 22;
            this.labelPackageAmount.Text = "Package Amount";
            // 
            // comboBoxEventTypeId
            // 
            this.comboBoxEventTypeId.FormattingEnabled = true;
            this.comboBoxEventTypeId.Location = new System.Drawing.Point(440, 112);
            this.comboBoxEventTypeId.Name = "comboBoxEventTypeId";
            this.comboBoxEventTypeId.Size = new System.Drawing.Size(166, 26);
            this.comboBoxEventTypeId.TabIndex = 11;
            // 
            // labelEventTypeId
            // 
            this.labelEventTypeId.AutoSize = true;
            this.labelEventTypeId.Location = new System.Drawing.Point(353, 116);
            this.labelEventTypeId.Name = "labelEventTypeId";
            this.labelEventTypeId.Size = new System.Drawing.Size(81, 18);
            this.labelEventTypeId.TabIndex = 10;
            this.labelEventTypeId.Text = "Event Type";
            // 
            // comboBoxBookingTypeId
            // 
            this.comboBoxBookingTypeId.FormattingEnabled = true;
            this.comboBoxBookingTypeId.Location = new System.Drawing.Point(164, 112);
            this.comboBoxBookingTypeId.Name = "comboBoxBookingTypeId";
            this.comboBoxBookingTypeId.Size = new System.Drawing.Size(166, 26);
            this.comboBoxBookingTypeId.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Event Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(490, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 24);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // comboBoxPackageId
            // 
            this.comboBoxPackageId.FormattingEnabled = true;
            this.comboBoxPackageId.Location = new System.Drawing.Point(164, 79);
            this.comboBoxPackageId.Name = "comboBoxPackageId";
            this.comboBoxPackageId.Size = new System.Drawing.Size(442, 26);
            this.comboBoxPackageId.TabIndex = 7;
            // 
            // textBoxReceivedAmount
            // 
            this.textBoxReceivedAmount.Location = new System.Drawing.Point(480, 338);
            this.textBoxReceivedAmount.Name = "textBoxReceivedAmount";
            this.textBoxReceivedAmount.ReadOnly = true;
            this.textBoxReceivedAmount.Size = new System.Drawing.Size(126, 24);
            this.textBoxReceivedAmount.TabIndex = 27;
            // 
            // labelReceivedAmount
            // 
            this.labelReceivedAmount.AutoSize = true;
            this.labelReceivedAmount.Location = new System.Drawing.Point(349, 341);
            this.labelReceivedAmount.Name = "labelReceivedAmount";
            this.labelReceivedAmount.Size = new System.Drawing.Size(124, 18);
            this.labelReceivedAmount.TabIndex = 26;
            this.labelReceivedAmount.Text = "Received Amount";
            // 
            // textBoxPersonCount
            // 
            this.textBoxPersonCount.Location = new System.Drawing.Point(164, 278);
            this.textBoxPersonCount.Name = "textBoxPersonCount";
            this.textBoxPersonCount.Size = new System.Drawing.Size(126, 24);
            this.textBoxPersonCount.TabIndex = 17;
            // 
            // labelPersonCount
            // 
            this.labelPersonCount.AutoSize = true;
            this.labelPersonCount.Location = new System.Drawing.Point(33, 281);
            this.labelPersonCount.Name = "labelPersonCount";
            this.labelPersonCount.Size = new System.Drawing.Size(100, 18);
            this.labelPersonCount.TabIndex = 16;
            this.labelPersonCount.Text = "Person Count";
            // 
            // textBoxEventDescription
            // 
            this.textBoxEventDescription.Location = new System.Drawing.Point(164, 174);
            this.textBoxEventDescription.Multiline = true;
            this.textBoxEventDescription.Name = "textBoxEventDescription";
            this.textBoxEventDescription.Size = new System.Drawing.Size(442, 98);
            this.textBoxEventDescription.TabIndex = 15;
            // 
            // labelEventDescription
            // 
            this.labelEventDescription.AutoSize = true;
            this.labelEventDescription.Location = new System.Drawing.Point(33, 177);
            this.labelEventDescription.Name = "labelEventDescription";
            this.labelEventDescription.Size = new System.Drawing.Size(124, 18);
            this.labelEventDescription.TabIndex = 14;
            this.labelEventDescription.Text = "Event Description";
            // 
            // textBoxEventName
            // 
            this.textBoxEventName.Location = new System.Drawing.Point(164, 144);
            this.textBoxEventName.Name = "textBoxEventName";
            this.textBoxEventName.Size = new System.Drawing.Size(442, 24);
            this.textBoxEventName.TabIndex = 13;
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Location = new System.Drawing.Point(33, 147);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(89, 18);
            this.labelEventName.TabIndex = 12;
            this.labelEventName.Text = "Event Name";
            // 
            // labelBookingDate
            // 
            this.labelBookingDate.AutoSize = true;
            this.labelBookingDate.Location = new System.Drawing.Point(33, 22);
            this.labelBookingDate.Name = "labelBookingDate";
            this.labelBookingDate.Size = new System.Drawing.Size(98, 18);
            this.labelBookingDate.TabIndex = 0;
            this.labelBookingDate.Text = "Booking Date";
            // 
            // dateTimePickerBookingDate
            // 
            this.dateTimePickerBookingDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBookingDate.Location = new System.Drawing.Point(164, 17);
            this.dateTimePickerBookingDate.Name = "dateTimePickerBookingDate";
            this.dateTimePickerBookingDate.Size = new System.Drawing.Size(115, 24);
            this.dateTimePickerBookingDate.TabIndex = 1;
            // 
            // labelBookingTypeId
            // 
            this.labelBookingTypeId.AutoSize = true;
            this.labelBookingTypeId.Location = new System.Drawing.Point(33, 116);
            this.labelBookingTypeId.Name = "labelBookingTypeId";
            this.labelBookingTypeId.Size = new System.Drawing.Size(99, 18);
            this.labelBookingTypeId.TabIndex = 8;
            this.labelBookingTypeId.Text = "Booking Type";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(245, 380);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(164, 380);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 27);
            this.buttonSave.TabIndex = 28;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // labelPackageId
            // 
            this.labelPackageId.AutoSize = true;
            this.labelPackageId.Location = new System.Drawing.Point(33, 82);
            this.labelPackageId.Name = "labelPackageId";
            this.labelPackageId.Size = new System.Drawing.Size(66, 18);
            this.labelPackageId.TabIndex = 6;
            this.labelPackageId.Text = "Package";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(33, 50);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(118, 18);
            this.labelCustomerName.TabIndex = 4;
            this.labelCustomerName.Text = "Customer Name";
            // 
            // comboBoxCustomerId
            // 
            this.comboBoxCustomerId.FormattingEnabled = true;
            this.comboBoxCustomerId.Location = new System.Drawing.Point(164, 47);
            this.comboBoxCustomerId.Name = "comboBoxCustomerId";
            this.comboBoxCustomerId.Size = new System.Drawing.Size(442, 26);
            this.comboBoxCustomerId.TabIndex = 5;
            // 
            // textBoxRemark
            // 
            this.textBoxRemark.Location = new System.Drawing.Point(164, 338);
            this.textBoxRemark.Name = "textBoxRemark";
            this.textBoxRemark.Size = new System.Drawing.Size(126, 24);
            this.textBoxRemark.TabIndex = 21;
            // 
            // labelRemark
            // 
            this.labelRemark.AutoSize = true;
            this.labelRemark.Location = new System.Drawing.Point(33, 341);
            this.labelRemark.Name = "labelRemark";
            this.labelRemark.Size = new System.Drawing.Size(61, 18);
            this.labelRemark.TabIndex = 20;
            this.labelRemark.Text = "Remark";
            // 
            // FormEventBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 447);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEventBooking";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Booking";
            this.Load += new System.EventHandler(this.FormEventBooking_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelBookingTypeId;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelPackageId;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelBookingDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookingDate;
        private System.Windows.Forms.ComboBox comboBoxPackageId;
        private System.Windows.Forms.TextBox textBoxReceivedAmount;
        private System.Windows.Forms.Label labelReceivedAmount;
        private System.Windows.Forms.TextBox textBoxPersonCount;
        private System.Windows.Forms.Label labelPersonCount;
        private System.Windows.Forms.TextBox textBoxEventDescription;
        private System.Windows.Forms.Label labelEventDescription;
        private System.Windows.Forms.TextBox textBoxEventName;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.ComboBox comboBoxCustomerId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxBookingTypeId;
        private System.Windows.Forms.ComboBox comboBoxEventTypeId;
        private System.Windows.Forms.Label labelEventTypeId;
        private System.Windows.Forms.TextBox textBoxFinalAmount;
        private System.Windows.Forms.Label labelFinalAmount;
        private System.Windows.Forms.TextBox textBoxDiscountAmount;
        private System.Windows.Forms.Label labelDiscountAmount;
        private System.Windows.Forms.TextBox textBoxPackageAmount;
        private System.Windows.Forms.Label labelPackageAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonAcceptPAyment;
        private System.Windows.Forms.TextBox textBoxRemark;
        private System.Windows.Forms.Label labelRemark;
    }
}