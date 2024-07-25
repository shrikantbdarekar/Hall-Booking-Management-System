
namespace HallBookingManagementSystem
{
    partial class FormPayment
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
            this.buttonPrintReceipt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelPaymentAmount = new System.Windows.Forms.Label();
            this.textBoxDueAmount = new System.Windows.Forms.TextBox();
            this.labelDueAmount = new System.Windows.Forms.Label();
            this.textBoxBalanceAmount = new System.Windows.Forms.TextBox();
            this.labelBalanceAmount = new System.Windows.Forms.Label();
            this.textBoxPaymentAmount = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPaymentDate = new System.Windows.Forms.Label();
            this.dateTimePickerPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelEventBookingId = new System.Windows.Forms.Label();
            this.comboBoxEventBookingId = new System.Windows.Forms.ComboBox();
            this.labelRemark = new System.Windows.Forms.Label();
            this.textBoxRemark = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.labelRemark);
            this.panelMain.Controls.Add(this.textBoxRemark);
            this.panelMain.Controls.Add(this.buttonPrintReceipt);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label11);
            this.panelMain.Controls.Add(this.labelPaymentAmount);
            this.panelMain.Controls.Add(this.textBoxDueAmount);
            this.panelMain.Controls.Add(this.labelDueAmount);
            this.panelMain.Controls.Add(this.textBoxBalanceAmount);
            this.panelMain.Controls.Add(this.labelBalanceAmount);
            this.panelMain.Controls.Add(this.textBoxPaymentAmount);
            this.panelMain.Controls.Add(this.textBox1);
            this.panelMain.Controls.Add(this.labelPaymentDate);
            this.panelMain.Controls.Add(this.dateTimePickerPaymentDate);
            this.panelMain.Controls.Add(this.buttonCancel);
            this.panelMain.Controls.Add(this.buttonSave);
            this.panelMain.Controls.Add(this.labelEventBookingId);
            this.panelMain.Controls.Add(this.comboBoxEventBookingId);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(639, 320);
            this.panelMain.TabIndex = 0;
            // 
            // buttonPrintReceipt
            // 
            this.buttonPrintReceipt.Location = new System.Drawing.Point(481, 279);
            this.buttonPrintReceipt.Name = "buttonPrintReceipt";
            this.buttonPrintReceipt.Size = new System.Drawing.Size(124, 27);
            this.buttonPrintReceipt.TabIndex = 13;
            this.buttonPrintReceipt.Text = "Print Receipt";
            this.buttonPrintReceipt.UseVisualStyleBackColor = true;
            this.buttonPrintReceipt.Click += new System.EventHandler(this.buttonPrintReceipt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Show All Details For Reference Purpose";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.LightGray;
            this.label11.Location = new System.Drawing.Point(164, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(441, 2);
            this.label11.TabIndex = 31;
            // 
            // labelPaymentAmount
            // 
            this.labelPaymentAmount.AutoSize = true;
            this.labelPaymentAmount.Location = new System.Drawing.Point(33, 216);
            this.labelPaymentAmount.Name = "labelPaymentAmount";
            this.labelPaymentAmount.Size = new System.Drawing.Size(121, 18);
            this.labelPaymentAmount.TabIndex = 7;
            this.labelPaymentAmount.Text = "Payment Amount";
            // 
            // textBoxDueAmount
            // 
            this.textBoxDueAmount.Location = new System.Drawing.Point(164, 183);
            this.textBoxDueAmount.Name = "textBoxDueAmount";
            this.textBoxDueAmount.ReadOnly = true;
            this.textBoxDueAmount.Size = new System.Drawing.Size(126, 24);
            this.textBoxDueAmount.TabIndex = 6;
            // 
            // labelDueAmount
            // 
            this.labelDueAmount.AutoSize = true;
            this.labelDueAmount.Location = new System.Drawing.Point(33, 186);
            this.labelDueAmount.Name = "labelDueAmount";
            this.labelDueAmount.Size = new System.Drawing.Size(90, 18);
            this.labelDueAmount.TabIndex = 5;
            this.labelDueAmount.Text = "Due Amount";
            // 
            // textBoxBalanceAmount
            // 
            this.textBoxBalanceAmount.Location = new System.Drawing.Point(164, 243);
            this.textBoxBalanceAmount.Name = "textBoxBalanceAmount";
            this.textBoxBalanceAmount.ReadOnly = true;
            this.textBoxBalanceAmount.Size = new System.Drawing.Size(126, 24);
            this.textBoxBalanceAmount.TabIndex = 10;
            // 
            // labelBalanceAmount
            // 
            this.labelBalanceAmount.AutoSize = true;
            this.labelBalanceAmount.Location = new System.Drawing.Point(33, 246);
            this.labelBalanceAmount.Name = "labelBalanceAmount";
            this.labelBalanceAmount.Size = new System.Drawing.Size(116, 18);
            this.labelBalanceAmount.TabIndex = 9;
            this.labelBalanceAmount.Text = "Balance Amount";
            // 
            // textBoxPaymentAmount
            // 
            this.textBoxPaymentAmount.Location = new System.Drawing.Point(163, 213);
            this.textBoxPaymentAmount.Name = "textBoxPaymentAmount";
            this.textBoxPaymentAmount.Size = new System.Drawing.Size(126, 24);
            this.textBoxPaymentAmount.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(442, 98);
            this.textBox1.TabIndex = 4;
            // 
            // labelPaymentDate
            // 
            this.labelPaymentDate.AutoSize = true;
            this.labelPaymentDate.Location = new System.Drawing.Point(33, 22);
            this.labelPaymentDate.Name = "labelPaymentDate";
            this.labelPaymentDate.Size = new System.Drawing.Size(101, 18);
            this.labelPaymentDate.TabIndex = 0;
            this.labelPaymentDate.Text = "Payment Date";
            // 
            // dateTimePickerPaymentDate
            // 
            this.dateTimePickerPaymentDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPaymentDate.Location = new System.Drawing.Point(164, 17);
            this.dateTimePickerPaymentDate.Name = "dateTimePickerPaymentDate";
            this.dateTimePickerPaymentDate.Size = new System.Drawing.Size(115, 24);
            this.dateTimePickerPaymentDate.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(245, 279);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(164, 279);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 27);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelEventBookingId
            // 
            this.labelEventBookingId.AutoSize = true;
            this.labelEventBookingId.Location = new System.Drawing.Point(33, 50);
            this.labelEventBookingId.Name = "labelEventBookingId";
            this.labelEventBookingId.Size = new System.Drawing.Size(94, 18);
            this.labelEventBookingId.TabIndex = 2;
            this.labelEventBookingId.Text = "Event Details";
            // 
            // comboBoxEventBookingId
            // 
            this.comboBoxEventBookingId.FormattingEnabled = true;
            this.comboBoxEventBookingId.Location = new System.Drawing.Point(164, 47);
            this.comboBoxEventBookingId.Name = "comboBoxEventBookingId";
            this.comboBoxEventBookingId.Size = new System.Drawing.Size(442, 26);
            this.comboBoxEventBookingId.TabIndex = 3;
            // 
            // labelRemark
            // 
            this.labelRemark.AutoSize = true;
            this.labelRemark.Location = new System.Drawing.Point(349, 243);
            this.labelRemark.Name = "labelRemark";
            this.labelRemark.Size = new System.Drawing.Size(121, 18);
            this.labelRemark.TabIndex = 32;
            this.labelRemark.Text = "Payment Amount";
            // 
            // textBoxRemark
            // 
            this.textBoxRemark.Location = new System.Drawing.Point(479, 240);
            this.textBoxRemark.Name = "textBoxRemark";
            this.textBoxRemark.Size = new System.Drawing.Size(126, 24);
            this.textBoxRemark.TabIndex = 33;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 344);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPayment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelEventBookingId;
        private System.Windows.Forms.Label labelPaymentDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaymentDate;
        private System.Windows.Forms.TextBox textBoxBalanceAmount;
        private System.Windows.Forms.Label labelBalanceAmount;
        private System.Windows.Forms.TextBox textBoxPaymentAmount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEventBookingId;
        private System.Windows.Forms.Label labelPaymentAmount;
        private System.Windows.Forms.TextBox textBoxDueAmount;
        private System.Windows.Forms.Label labelDueAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonPrintReceipt;
        private System.Windows.Forms.Label labelRemark;
        private System.Windows.Forms.TextBox textBoxRemark;
    }
}