
namespace HallBookingManagementSystem
{
    partial class FormEventBookingSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewEventBooking = new System.Windows.Forms.DataGridView();
            this.dgcEventBookingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcBookingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCustomerId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcEventTypeId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcFinalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPayment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcReceivedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 14);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 27);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add Booking";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewEventBooking
            // 
            this.dataGridViewEventBooking.AllowUserToAddRows = false;
            this.dataGridViewEventBooking.AllowUserToDeleteRows = false;
            this.dataGridViewEventBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEventBooking.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEventBooking.ColumnHeadersHeight = 30;
            this.dataGridViewEventBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEventBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcEventBookingId,
            this.dgcBookingDate,
            this.dgcEventDate,
            this.dgcCustomerId,
            this.dgcEventTypeId,
            this.dgcFinalAmount,
            this.dgcPayment,
            this.dgcReceivedAmount,
            this.dgcEdit,
            this.dgcDelete});
            this.dataGridViewEventBooking.Location = new System.Drawing.Point(16, 48);
            this.dataGridViewEventBooking.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEventBooking.Name = "dataGridViewEventBooking";
            this.dataGridViewEventBooking.ReadOnly = true;
            this.dataGridViewEventBooking.Size = new System.Drawing.Size(1153, 498);
            this.dataGridViewEventBooking.TabIndex = 13;
            this.dataGridViewEventBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEventBooking_CellContentClick);
            // 
            // dgcEventBookingId
            // 
            this.dgcEventBookingId.DataPropertyName = "EventBookingId";
            this.dgcEventBookingId.HeaderText = "Event Booking Id";
            this.dgcEventBookingId.Name = "dgcEventBookingId";
            this.dgcEventBookingId.ReadOnly = true;
            this.dgcEventBookingId.Visible = false;
            // 
            // dgcBookingDate
            // 
            this.dgcBookingDate.DataPropertyName = "BookingDate";
            this.dgcBookingDate.HeaderText = "BK Date";
            this.dgcBookingDate.Name = "dgcBookingDate";
            this.dgcBookingDate.ReadOnly = true;
            // 
            // dgcEventDate
            // 
            this.dgcEventDate.DataPropertyName = "EventDate";
            this.dgcEventDate.HeaderText = "EV Date";
            this.dgcEventDate.Name = "dgcEventDate";
            this.dgcEventDate.ReadOnly = true;
            // 
            // dgcCustomerId
            // 
            this.dgcCustomerId.DataPropertyName = "CustomerId";
            this.dgcCustomerId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dgcCustomerId.HeaderText = "Customer Name";
            this.dgcCustomerId.Name = "dgcCustomerId";
            this.dgcCustomerId.ReadOnly = true;
            this.dgcCustomerId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcCustomerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcCustomerId.Width = 250;
            // 
            // dgcEventTypeId
            // 
            this.dgcEventTypeId.DataPropertyName = "EventTypeId";
            this.dgcEventTypeId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dgcEventTypeId.HeaderText = "Event Type";
            this.dgcEventTypeId.Name = "dgcEventTypeId";
            this.dgcEventTypeId.ReadOnly = true;
            this.dgcEventTypeId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcEventTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgcFinalAmount
            // 
            this.dgcFinalAmount.DataPropertyName = "FinalAmount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgcFinalAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgcFinalAmount.HeaderText = "Amount";
            this.dgcFinalAmount.Name = "dgcFinalAmount";
            this.dgcFinalAmount.ReadOnly = true;
            this.dgcFinalAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgcPayment
            // 
            this.dgcPayment.HeaderText = "Payment";
            this.dgcPayment.Name = "dgcPayment";
            this.dgcPayment.ReadOnly = true;
            this.dgcPayment.Text = "Payment";
            this.dgcPayment.UseColumnTextForButtonValue = true;
            this.dgcPayment.Width = 80;
            // 
            // dgcReceivedAmount
            // 
            this.dgcReceivedAmount.DataPropertyName = "ReceivedAmount";
            this.dgcReceivedAmount.HeaderText = "RCV Amt";
            this.dgcReceivedAmount.Name = "dgcReceivedAmount";
            this.dgcReceivedAmount.ReadOnly = true;
            // 
            // dgcEdit
            // 
            this.dgcEdit.HeaderText = "Edit";
            this.dgcEdit.Name = "dgcEdit";
            this.dgcEdit.ReadOnly = true;
            this.dgcEdit.Text = "Edit";
            this.dgcEdit.UseColumnTextForButtonValue = true;
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
            // FormEventBookingSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewEventBooking);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEventBookingSearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Booking";
            this.Load += new System.EventHandler(this.FormBookingTypeSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventBooking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewEventBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcEventBookingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBookingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcEventDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcCustomerId;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcEventTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFinalAmount;
        private System.Windows.Forms.DataGridViewButtonColumn dgcPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcReceivedAmount;
        private System.Windows.Forms.DataGridViewButtonColumn dgcEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgcDelete;
    }
}