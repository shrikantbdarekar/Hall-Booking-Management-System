
namespace HallBookingManagementSystem
{
    partial class FormPaymentSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.buttonPrintReceipt = new System.Windows.Forms.Button();
            this.dgcPrint = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcPaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEventBookingId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcDueAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcBalanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 14);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 27);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add Payment";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.AllowUserToAddRows = false;
            this.dataGridViewPayments.AllowUserToDeleteRows = false;
            this.dataGridViewPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPayments.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPayments.ColumnHeadersHeight = 30;
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcPrint,
            this.dgcPaymentId,
            this.dgcPaymentDate,
            this.dgcEventBookingId,
            this.dgcDueAmount,
            this.dgcPaymentAmount,
            this.dgcBalanceAmount,
            this.dgcEdit,
            this.dgcDelete});
            this.dataGridViewPayments.Location = new System.Drawing.Point(16, 48);
            this.dataGridViewPayments.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.ReadOnly = true;
            this.dataGridViewPayments.Size = new System.Drawing.Size(1055, 498);
            this.dataGridViewPayments.TabIndex = 13;
            this.dataGridViewPayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellContentClick);
            // 
            // buttonPrintReceipt
            // 
            this.buttonPrintReceipt.Location = new System.Drawing.Point(947, 14);
            this.buttonPrintReceipt.Name = "buttonPrintReceipt";
            this.buttonPrintReceipt.Size = new System.Drawing.Size(124, 27);
            this.buttonPrintReceipt.TabIndex = 33;
            this.buttonPrintReceipt.Text = "Print Receipt";
            this.buttonPrintReceipt.UseVisualStyleBackColor = true;
            this.buttonPrintReceipt.Visible = false;
            this.buttonPrintReceipt.Click += new System.EventHandler(this.buttonPrintReceipt_Click);
            // 
            // dgcPrint
            // 
            this.dgcPrint.HeaderText = "Print";
            this.dgcPrint.Name = "dgcPrint";
            this.dgcPrint.ReadOnly = true;
            this.dgcPrint.Text = "Print";
            this.dgcPrint.UseColumnTextForButtonValue = true;
            // 
            // dgcPaymentId
            // 
            this.dgcPaymentId.DataPropertyName = "PaymentId";
            this.dgcPaymentId.HeaderText = "Payment Id";
            this.dgcPaymentId.Name = "dgcPaymentId";
            this.dgcPaymentId.ReadOnly = true;
            this.dgcPaymentId.Visible = false;
            // 
            // dgcPaymentDate
            // 
            this.dgcPaymentDate.DataPropertyName = "PaymentDate";
            this.dgcPaymentDate.HeaderText = "Date";
            this.dgcPaymentDate.Name = "dgcPaymentDate";
            this.dgcPaymentDate.ReadOnly = true;
            // 
            // dgcEventBookingId
            // 
            this.dgcEventBookingId.DataPropertyName = "EventBookingId";
            this.dgcEventBookingId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dgcEventBookingId.HeaderText = "Event Booking Details";
            this.dgcEventBookingId.Name = "dgcEventBookingId";
            this.dgcEventBookingId.ReadOnly = true;
            this.dgcEventBookingId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcEventBookingId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcEventBookingId.Width = 400;
            // 
            // dgcDueAmount
            // 
            this.dgcDueAmount.DataPropertyName = "DueAmount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgcDueAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgcDueAmount.HeaderText = "Due Amt";
            this.dgcDueAmount.Name = "dgcDueAmount";
            this.dgcDueAmount.ReadOnly = true;
            // 
            // dgcPaymentAmount
            // 
            this.dgcPaymentAmount.DataPropertyName = "PaymentAmount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgcPaymentAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgcPaymentAmount.HeaderText = "Payment Amt";
            this.dgcPaymentAmount.Name = "dgcPaymentAmount";
            this.dgcPaymentAmount.ReadOnly = true;
            // 
            // dgcBalanceAmount
            // 
            this.dgcBalanceAmount.DataPropertyName = "BalanceAmount";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgcBalanceAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgcBalanceAmount.HeaderText = "Bal Amt";
            this.dgcBalanceAmount.Name = "dgcBalanceAmount";
            this.dgcBalanceAmount.ReadOnly = true;
            // 
            // dgcEdit
            // 
            this.dgcEdit.HeaderText = "Edit";
            this.dgcEdit.Name = "dgcEdit";
            this.dgcEdit.ReadOnly = true;
            this.dgcEdit.Text = "Edit";
            this.dgcEdit.UseColumnTextForButtonValue = true;
            this.dgcEdit.Visible = false;
            this.dgcEdit.Width = 80;
            // 
            // dgcDelete
            // 
            this.dgcDelete.HeaderText = "Delete";
            this.dgcDelete.Name = "dgcDelete";
            this.dgcDelete.ReadOnly = true;
            this.dgcDelete.Text = "Delete";
            this.dgcDelete.UseColumnTextForButtonValue = true;
            this.dgcDelete.Width = 80;
            // 
            // FormPaymentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 561);
            this.Controls.Add(this.buttonPrintReceipt);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewPayments);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPaymentSearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Search";
            this.Load += new System.EventHandler(this.FormPaymentSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewPayments;
        private System.Windows.Forms.Button buttonPrintReceipt;
        private System.Windows.Forms.DataGridViewButtonColumn dgcPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPaymentDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcEventBookingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDueAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalanceAmount;
        private System.Windows.Forms.DataGridViewButtonColumn dgcEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgcDelete;
    }
}