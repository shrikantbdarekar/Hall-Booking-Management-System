
namespace HallBookingManagementSystem
{
    partial class FormBookingTypeSearch
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewBookingType = new System.Windows.Forms.DataGridView();
            this.dgcBookingTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcBookingTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcBookingTypeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingType)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 14);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(163, 27);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add Booking Type";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewBookingType
            // 
            this.dataGridViewBookingType.AllowUserToAddRows = false;
            this.dataGridViewBookingType.AllowUserToDeleteRows = false;
            this.dataGridViewBookingType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookingType.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBookingType.ColumnHeadersHeight = 30;
            this.dataGridViewBookingType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBookingType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcBookingTypeId,
            this.dgcBookingTypeName,
            this.dgcBookingTypeDescription,
            this.dgcEdit,
            this.dgcDelete});
            this.dataGridViewBookingType.Location = new System.Drawing.Point(15, 48);
            this.dataGridViewBookingType.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBookingType.Name = "dataGridViewBookingType";
            this.dataGridViewBookingType.ReadOnly = true;
            this.dataGridViewBookingType.Size = new System.Drawing.Size(782, 406);
            this.dataGridViewBookingType.TabIndex = 13;
            this.dataGridViewBookingType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookingType_CellContentClick);
            // 
            // dgcBookingTypeId
            // 
            this.dgcBookingTypeId.DataPropertyName = "BookingTypeId";
            this.dgcBookingTypeId.HeaderText = "Booking Type Id";
            this.dgcBookingTypeId.Name = "dgcBookingTypeId";
            this.dgcBookingTypeId.ReadOnly = true;
            this.dgcBookingTypeId.Visible = false;
            // 
            // dgcBookingTypeName
            // 
            this.dgcBookingTypeName.DataPropertyName = "BookingTypeName";
            this.dgcBookingTypeName.HeaderText = "Booking Type Name";
            this.dgcBookingTypeName.Name = "dgcBookingTypeName";
            this.dgcBookingTypeName.ReadOnly = true;
            this.dgcBookingTypeName.Width = 200;
            // 
            // dgcBookingTypeDescription
            // 
            this.dgcBookingTypeDescription.DataPropertyName = "BookingTypeDescription";
            this.dgcBookingTypeDescription.HeaderText = "Booking Type Description";
            this.dgcBookingTypeDescription.Name = "dgcBookingTypeDescription";
            this.dgcBookingTypeDescription.ReadOnly = true;
            this.dgcBookingTypeDescription.Width = 300;
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
            // FormBookingTypeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 469);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewBookingType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBookingTypeSearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Type Search";
            this.Load += new System.EventHandler(this.FormBookingTypeSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewBookingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBookingTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBookingTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBookingTypeDescription;
        private System.Windows.Forms.DataGridViewButtonColumn dgcEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgcDelete;
    }
}