
namespace HallBookingManagementSystem
{
    partial class FormBookingType
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxBookingTypeDescription = new System.Windows.Forms.TextBox();
            this.labelBookingTypeDescription = new System.Windows.Forms.Label();
            this.textBoxBookingTypeName = new System.Windows.Forms.TextBox();
            this.labelBookingTypeName = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.buttonCancel);
            this.panelMain.Controls.Add(this.buttonSave);
            this.panelMain.Controls.Add(this.textBoxBookingTypeDescription);
            this.panelMain.Controls.Add(this.labelBookingTypeDescription);
            this.panelMain.Controls.Add(this.textBoxBookingTypeName);
            this.panelMain.Controls.Add(this.labelBookingTypeName);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(667, 138);
            this.panelMain.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(336, 91);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(255, 91);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 27);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxBookingTypeDescription
            // 
            this.textBoxBookingTypeDescription.Location = new System.Drawing.Point(224, 50);
            this.textBoxBookingTypeDescription.Name = "textBoxBookingTypeDescription";
            this.textBoxBookingTypeDescription.Size = new System.Drawing.Size(409, 24);
            this.textBoxBookingTypeDescription.TabIndex = 3;
            // 
            // labelBookingTypeDescription
            // 
            this.labelBookingTypeDescription.AutoSize = true;
            this.labelBookingTypeDescription.Location = new System.Drawing.Point(33, 53);
            this.labelBookingTypeDescription.Name = "labelBookingTypeDescription";
            this.labelBookingTypeDescription.Size = new System.Drawing.Size(178, 18);
            this.labelBookingTypeDescription.TabIndex = 2;
            this.labelBookingTypeDescription.Text = "Booking Type Description";
            // 
            // textBoxBookingTypeName
            // 
            this.textBoxBookingTypeName.Location = new System.Drawing.Point(224, 20);
            this.textBoxBookingTypeName.Name = "textBoxBookingTypeName";
            this.textBoxBookingTypeName.Size = new System.Drawing.Size(409, 24);
            this.textBoxBookingTypeName.TabIndex = 1;
            // 
            // labelBookingTypeName
            // 
            this.labelBookingTypeName.AutoSize = true;
            this.labelBookingTypeName.Location = new System.Drawing.Point(33, 23);
            this.labelBookingTypeName.Name = "labelBookingTypeName";
            this.labelBookingTypeName.Size = new System.Drawing.Size(143, 18);
            this.labelBookingTypeName.TabIndex = 0;
            this.labelBookingTypeName.Text = "Booking Type Name";
            // 
            // FormBookingType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 162);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBookingType";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Type";
            this.Load += new System.EventHandler(this.FormBookingType_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxBookingTypeDescription;
        private System.Windows.Forms.Label labelBookingTypeDescription;
        private System.Windows.Forms.TextBox textBoxBookingTypeName;
        private System.Windows.Forms.Label labelBookingTypeName;
    }
}