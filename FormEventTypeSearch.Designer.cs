
namespace HallBookingManagementSystem
{
    partial class FormEventTypeSearch
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
            this.dataGridViewEventType = new System.Windows.Forms.DataGridView();
            this.dgcEventTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEventTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEventTypeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventType)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 14);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(163, 27);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add Event Type";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewEventType
            // 
            this.dataGridViewEventType.AllowUserToAddRows = false;
            this.dataGridViewEventType.AllowUserToDeleteRows = false;
            this.dataGridViewEventType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEventType.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEventType.ColumnHeadersHeight = 30;
            this.dataGridViewEventType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEventType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcEventTypeId,
            this.dgcEventTypeName,
            this.dgcEventTypeDescription,
            this.dgcEdit,
            this.dgcDelete});
            this.dataGridViewEventType.Location = new System.Drawing.Point(15, 48);
            this.dataGridViewEventType.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEventType.Name = "dataGridViewEventType";
            this.dataGridViewEventType.ReadOnly = true;
            this.dataGridViewEventType.Size = new System.Drawing.Size(782, 406);
            this.dataGridViewEventType.TabIndex = 13;
            this.dataGridViewEventType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEventType_CellContentClick);
            // 
            // dgcEventTypeId
            // 
            this.dgcEventTypeId.DataPropertyName = "EventTypeId";
            this.dgcEventTypeId.HeaderText = "Event Type Id";
            this.dgcEventTypeId.Name = "dgcEventTypeId";
            this.dgcEventTypeId.ReadOnly = true;
            this.dgcEventTypeId.Visible = false;
            // 
            // dgcEventTypeName
            // 
            this.dgcEventTypeName.DataPropertyName = "EventTypeName";
            this.dgcEventTypeName.HeaderText = "Event Type Name";
            this.dgcEventTypeName.Name = "dgcEventTypeName";
            this.dgcEventTypeName.ReadOnly = true;
            this.dgcEventTypeName.Width = 200;
            // 
            // dgcEventTypeDescription
            // 
            this.dgcEventTypeDescription.DataPropertyName = "EventTypeDescription";
            this.dgcEventTypeDescription.HeaderText = "Event Type Description";
            this.dgcEventTypeDescription.Name = "dgcEventTypeDescription";
            this.dgcEventTypeDescription.ReadOnly = true;
            this.dgcEventTypeDescription.Width = 300;
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
            // FormEventTypeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 469);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewEventType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEventTypeSearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Type Search";
            this.Load += new System.EventHandler(this.FormEventTypeSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewEventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcEventTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcEventTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcEventTypeDescription;
        private System.Windows.Forms.DataGridViewButtonColumn dgcEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgcDelete;
    }
}