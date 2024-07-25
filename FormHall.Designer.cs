
namespace HallBookingManagementSystem
{
    partial class FormHall
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
            this.textBoxHallDescription = new System.Windows.Forms.TextBox();
            this.labelHallDescription = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxHallCapacity = new System.Windows.Forms.TextBox();
            this.labelHallCapacity = new System.Windows.Forms.Label();
            this.textBoxHallName = new System.Windows.Forms.TextBox();
            this.labelHallName = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.textBoxHallDescription);
            this.panelMain.Controls.Add(this.labelHallDescription);
            this.panelMain.Controls.Add(this.buttonCancel);
            this.panelMain.Controls.Add(this.buttonSave);
            this.panelMain.Controls.Add(this.textBoxHallCapacity);
            this.panelMain.Controls.Add(this.labelHallCapacity);
            this.panelMain.Controls.Add(this.textBoxHallName);
            this.panelMain.Controls.Add(this.labelHallName);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(524, 155);
            this.panelMain.TabIndex = 0;
            // 
            // textBoxHallDescription
            // 
            this.textBoxHallDescription.Location = new System.Drawing.Point(164, 80);
            this.textBoxHallDescription.Name = "textBoxHallDescription";
            this.textBoxHallDescription.Size = new System.Drawing.Size(327, 24);
            this.textBoxHallDescription.TabIndex = 5;
            // 
            // labelHallDescription
            // 
            this.labelHallDescription.AutoSize = true;
            this.labelHallDescription.Location = new System.Drawing.Point(33, 83);
            this.labelHallDescription.Name = "labelHallDescription";
            this.labelHallDescription.Size = new System.Drawing.Size(83, 18);
            this.labelHallDescription.TabIndex = 4;
            this.labelHallDescription.Text = "Description";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(245, 112);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(164, 112);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 27);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxHallCapacity
            // 
            this.textBoxHallCapacity.Location = new System.Drawing.Point(164, 50);
            this.textBoxHallCapacity.Name = "textBoxHallCapacity";
            this.textBoxHallCapacity.Size = new System.Drawing.Size(75, 24);
            this.textBoxHallCapacity.TabIndex = 3;
            this.textBoxHallCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelHallCapacity
            // 
            this.labelHallCapacity.AutoSize = true;
            this.labelHallCapacity.Location = new System.Drawing.Point(33, 53);
            this.labelHallCapacity.Name = "labelHallCapacity";
            this.labelHallCapacity.Size = new System.Drawing.Size(65, 18);
            this.labelHallCapacity.TabIndex = 2;
            this.labelHallCapacity.Text = "Capacity";
            // 
            // textBoxHallName
            // 
            this.textBoxHallName.Location = new System.Drawing.Point(164, 20);
            this.textBoxHallName.Name = "textBoxHallName";
            this.textBoxHallName.Size = new System.Drawing.Size(327, 24);
            this.textBoxHallName.TabIndex = 1;
            // 
            // labelHallName
            // 
            this.labelHallName.AutoSize = true;
            this.labelHallName.Location = new System.Drawing.Point(33, 23);
            this.labelHallName.Name = "labelHallName";
            this.labelHallName.Size = new System.Drawing.Size(77, 18);
            this.labelHallName.TabIndex = 0;
            this.labelHallName.Text = "Hall Name";
            // 
            // FormHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 179);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHall";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hall Detail";
            this.Load += new System.EventHandler(this.FormHall_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelHallDescription;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxHallCapacity;
        private System.Windows.Forms.Label labelHallCapacity;
        private System.Windows.Forms.TextBox textBoxHallName;
        private System.Windows.Forms.Label labelHallName;
        private System.Windows.Forms.TextBox textBoxHallDescription;
    }
}