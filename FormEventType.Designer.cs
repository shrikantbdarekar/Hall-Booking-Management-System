
namespace HallBookingManagementSystem
{
    partial class FormEventType
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
            this.textBoxEventTypeDescription = new System.Windows.Forms.TextBox();
            this.labelEventTypeDescription = new System.Windows.Forms.Label();
            this.textBoxEventTypeName = new System.Windows.Forms.TextBox();
            this.labelEventTypeName = new System.Windows.Forms.Label();
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
            this.panelMain.Controls.Add(this.textBoxEventTypeDescription);
            this.panelMain.Controls.Add(this.labelEventTypeDescription);
            this.panelMain.Controls.Add(this.textBoxEventTypeName);
            this.panelMain.Controls.Add(this.labelEventTypeName);
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
            // textBoxEventTypeDescription
            // 
            this.textBoxEventTypeDescription.Location = new System.Drawing.Point(224, 50);
            this.textBoxEventTypeDescription.Name = "textBoxEventTypeDescription";
            this.textBoxEventTypeDescription.Size = new System.Drawing.Size(409, 24);
            this.textBoxEventTypeDescription.TabIndex = 3;
            // 
            // labelEventTypeDescription
            // 
            this.labelEventTypeDescription.AutoSize = true;
            this.labelEventTypeDescription.Location = new System.Drawing.Point(33, 53);
            this.labelEventTypeDescription.Name = "labelEventTypeDescription";
            this.labelEventTypeDescription.Size = new System.Drawing.Size(160, 18);
            this.labelEventTypeDescription.TabIndex = 2;
            this.labelEventTypeDescription.Text = "Event Type Description";
            // 
            // textBoxEventTypeName
            // 
            this.textBoxEventTypeName.Location = new System.Drawing.Point(224, 20);
            this.textBoxEventTypeName.Name = "textBoxEventTypeName";
            this.textBoxEventTypeName.Size = new System.Drawing.Size(409, 24);
            this.textBoxEventTypeName.TabIndex = 1;
            // 
            // labelEventTypeName
            // 
            this.labelEventTypeName.AutoSize = true;
            this.labelEventTypeName.Location = new System.Drawing.Point(33, 23);
            this.labelEventTypeName.Name = "labelEventTypeName";
            this.labelEventTypeName.Size = new System.Drawing.Size(125, 18);
            this.labelEventTypeName.TabIndex = 0;
            this.labelEventTypeName.Text = "Event Type Name";
            // 
            // FormEventType
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
            this.Name = "FormEventType";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Type";
            this.Load += new System.EventHandler(this.FormEventType_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxEventTypeDescription;
        private System.Windows.Forms.Label labelEventTypeDescription;
        private System.Windows.Forms.TextBox textBoxEventTypeName;
        private System.Windows.Forms.Label labelEventTypeName;
    }
}