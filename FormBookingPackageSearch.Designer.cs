
namespace HallBookingManagementSystem
{
    partial class FormBookingPackageSearch
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
            this.dataGridViewBookingPackage = new System.Windows.Forms.DataGridView();
            this.dgcPackageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHallId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcPackageAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPackageDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingPackage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 14);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(163, 27);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add Package";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewBookingPackage
            // 
            this.dataGridViewBookingPackage.AllowUserToAddRows = false;
            this.dataGridViewBookingPackage.AllowUserToDeleteRows = false;
            this.dataGridViewBookingPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookingPackage.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBookingPackage.ColumnHeadersHeight = 30;
            this.dataGridViewBookingPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBookingPackage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcPackageId,
            this.dgcPackageName,
            this.dgcHallId,
            this.dgcPackageAmount,
            this.dgcPackageDescription,
            this.dgcEdit,
            this.dgcDelete});
            this.dataGridViewBookingPackage.Location = new System.Drawing.Point(15, 48);
            this.dataGridViewBookingPackage.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBookingPackage.Name = "dataGridViewBookingPackage";
            this.dataGridViewBookingPackage.ReadOnly = true;
            this.dataGridViewBookingPackage.Size = new System.Drawing.Size(1053, 406);
            this.dataGridViewBookingPackage.TabIndex = 13;
            this.dataGridViewBookingPackage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookingPackage_CellContentClick);
            // 
            // dgcPackageId
            // 
            this.dgcPackageId.DataPropertyName = "PackageId";
            this.dgcPackageId.HeaderText = "Package Id";
            this.dgcPackageId.Name = "dgcPackageId";
            this.dgcPackageId.ReadOnly = true;
            this.dgcPackageId.Visible = false;
            // 
            // dgcPackageName
            // 
            this.dgcPackageName.DataPropertyName = "PackageName";
            this.dgcPackageName.HeaderText = "Package Name";
            this.dgcPackageName.Name = "dgcPackageName";
            this.dgcPackageName.ReadOnly = true;
            this.dgcPackageName.Width = 200;
            // 
            // dgcHallId
            // 
            this.dgcHallId.DataPropertyName = "HallId";
            this.dgcHallId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dgcHallId.HeaderText = "Hall Name";
            this.dgcHallId.Name = "dgcHallId";
            this.dgcHallId.ReadOnly = true;
            this.dgcHallId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcHallId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcHallId.Width = 200;
            // 
            // dgcPackageAmount
            // 
            this.dgcPackageAmount.DataPropertyName = "PackageAmount";
            this.dgcPackageAmount.HeaderText = "Amount";
            this.dgcPackageAmount.Name = "dgcPackageAmount";
            this.dgcPackageAmount.ReadOnly = true;
            // 
            // dgcPackageDescription
            // 
            this.dgcPackageDescription.DataPropertyName = "PackageDescription";
            this.dgcPackageDescription.HeaderText = "Package Description";
            this.dgcPackageDescription.Name = "dgcPackageDescription";
            this.dgcPackageDescription.ReadOnly = true;
            this.dgcPackageDescription.Width = 300;
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
            // FormBookingPackageSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 469);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewBookingPackage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBookingPackageSearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Package Search";
            this.Load += new System.EventHandler(this.FormBookingTypeSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingPackage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewBookingPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPackageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPackageName;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcHallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPackageAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPackageDescription;
        private System.Windows.Forms.DataGridViewButtonColumn dgcEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgcDelete;
    }
}