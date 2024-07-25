
namespace HallBookingManagementSystem
{
    partial class FormHallSearch
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
            this.dataGridViewHalls = new System.Windows.Forms.DataGridView();
            this.dgcHallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHallName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHallCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHallDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHalls)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 14);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 27);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add Hall Detail";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewHalls
            // 
            this.dataGridViewHalls.AllowUserToAddRows = false;
            this.dataGridViewHalls.AllowUserToDeleteRows = false;
            this.dataGridViewHalls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHalls.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHalls.ColumnHeadersHeight = 30;
            this.dataGridViewHalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewHalls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcHallId,
            this.dgcHallName,
            this.dgcHallCapacity,
            this.dgcHallDescription,
            this.dgcEdit,
            this.dgcDelete});
            this.dataGridViewHalls.Location = new System.Drawing.Point(15, 48);
            this.dataGridViewHalls.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewHalls.Name = "dataGridViewHalls";
            this.dataGridViewHalls.ReadOnly = true;
            this.dataGridViewHalls.Size = new System.Drawing.Size(833, 406);
            this.dataGridViewHalls.TabIndex = 13;
            this.dataGridViewHalls.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHalls_CellContentClick);
            // 
            // dgcHallId
            // 
            this.dgcHallId.DataPropertyName = "HallId";
            this.dgcHallId.HeaderText = "Hall Id";
            this.dgcHallId.Name = "dgcHallId";
            this.dgcHallId.ReadOnly = true;
            this.dgcHallId.Visible = false;
            // 
            // dgcHallName
            // 
            this.dgcHallName.DataPropertyName = "HallName";
            this.dgcHallName.HeaderText = "Hall Name";
            this.dgcHallName.Name = "dgcHallName";
            this.dgcHallName.ReadOnly = true;
            this.dgcHallName.Width = 200;
            // 
            // dgcHallCapacity
            // 
            this.dgcHallCapacity.DataPropertyName = "HallCapacity";
            this.dgcHallCapacity.HeaderText = "Capacity";
            this.dgcHallCapacity.Name = "dgcHallCapacity";
            this.dgcHallCapacity.ReadOnly = true;
            // 
            // dgcHallDescription
            // 
            this.dgcHallDescription.DataPropertyName = "HallDescription";
            this.dgcHallDescription.HeaderText = "Description";
            this.dgcHallDescription.Name = "dgcHallDescription";
            this.dgcHallDescription.ReadOnly = true;
            this.dgcHallDescription.Width = 250;
            // 
            // dgcEdit
            // 
            this.dgcEdit.HeaderText = "Edit";
            this.dgcEdit.Name = "dgcEdit";
            this.dgcEdit.ReadOnly = true;
            this.dgcEdit.Text = "Edit";
            this.dgcEdit.UseColumnTextForButtonValue = true;
            // 
            // dgcDelete
            // 
            this.dgcDelete.HeaderText = "Delete";
            this.dgcDelete.Name = "dgcDelete";
            this.dgcDelete.ReadOnly = true;
            this.dgcDelete.Text = "Delete";
            this.dgcDelete.UseColumnTextForButtonValue = true;
            // 
            // FormHallSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 469);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewHalls);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHallSearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hall Detail";
            this.Load += new System.EventHandler(this.FormHallSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHalls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewHalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHallName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHallCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHallDescription;
        private System.Windows.Forms.DataGridViewButtonColumn dgcEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgcDelete;
    }
}