
namespace HallBookingManagementSystem
{
    partial class FormBookingPackage
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
            this.comboBoxHallName = new System.Windows.Forms.ComboBox();
            this.labelHallName = new System.Windows.Forms.Label();
            this.textBoxPackageDescription = new System.Windows.Forms.TextBox();
            this.labelPackageDescription = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxPackageAmount = new System.Windows.Forms.TextBox();
            this.labelPackageAmount = new System.Windows.Forms.Label();
            this.textBoxPackageName = new System.Windows.Forms.TextBox();
            this.labelPackageName = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.comboBoxHallName);
            this.panelMain.Controls.Add(this.labelHallName);
            this.panelMain.Controls.Add(this.textBoxPackageDescription);
            this.panelMain.Controls.Add(this.labelPackageDescription);
            this.panelMain.Controls.Add(this.buttonCancel);
            this.panelMain.Controls.Add(this.buttonSave);
            this.panelMain.Controls.Add(this.textBoxPackageAmount);
            this.panelMain.Controls.Add(this.labelPackageAmount);
            this.panelMain.Controls.Add(this.textBoxPackageName);
            this.panelMain.Controls.Add(this.labelPackageName);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(667, 310);
            this.panelMain.TabIndex = 0;
            // 
            // comboBoxHallName
            // 
            this.comboBoxHallName.FormattingEnabled = true;
            this.comboBoxHallName.Location = new System.Drawing.Point(467, 50);
            this.comboBoxHallName.Name = "comboBoxHallName";
            this.comboBoxHallName.Size = new System.Drawing.Size(166, 26);
            this.comboBoxHallName.TabIndex = 5;
            // 
            // labelHallName
            // 
            this.labelHallName.AutoSize = true;
            this.labelHallName.Location = new System.Drawing.Point(380, 54);
            this.labelHallName.Name = "labelHallName";
            this.labelHallName.Size = new System.Drawing.Size(77, 18);
            this.labelHallName.TabIndex = 4;
            this.labelHallName.Text = "Hall Name";
            // 
            // textBoxPackageDescription
            // 
            this.textBoxPackageDescription.Location = new System.Drawing.Point(196, 82);
            this.textBoxPackageDescription.Multiline = true;
            this.textBoxPackageDescription.Name = "textBoxPackageDescription";
            this.textBoxPackageDescription.Size = new System.Drawing.Size(437, 181);
            this.textBoxPackageDescription.TabIndex = 7;
            // 
            // labelPackageDescription
            // 
            this.labelPackageDescription.AutoSize = true;
            this.labelPackageDescription.Location = new System.Drawing.Point(33, 83);
            this.labelPackageDescription.Name = "labelPackageDescription";
            this.labelPackageDescription.Size = new System.Drawing.Size(145, 18);
            this.labelPackageDescription.TabIndex = 6;
            this.labelPackageDescription.Text = "Package Description";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(277, 270);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(196, 270);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 27);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxPackageAmount
            // 
            this.textBoxPackageAmount.Location = new System.Drawing.Point(196, 51);
            this.textBoxPackageAmount.Name = "textBoxPackageAmount";
            this.textBoxPackageAmount.Size = new System.Drawing.Size(134, 24);
            this.textBoxPackageAmount.TabIndex = 3;
            // 
            // labelPackageAmount
            // 
            this.labelPackageAmount.AutoSize = true;
            this.labelPackageAmount.Location = new System.Drawing.Point(33, 54);
            this.labelPackageAmount.Name = "labelPackageAmount";
            this.labelPackageAmount.Size = new System.Drawing.Size(121, 18);
            this.labelPackageAmount.TabIndex = 2;
            this.labelPackageAmount.Text = "Package Amount";
            // 
            // textBoxPackageName
            // 
            this.textBoxPackageName.Location = new System.Drawing.Point(196, 20);
            this.textBoxPackageName.Name = "textBoxPackageName";
            this.textBoxPackageName.Size = new System.Drawing.Size(437, 24);
            this.textBoxPackageName.TabIndex = 1;
            // 
            // labelPackageName
            // 
            this.labelPackageName.AutoSize = true;
            this.labelPackageName.Location = new System.Drawing.Point(33, 23);
            this.labelPackageName.Name = "labelPackageName";
            this.labelPackageName.Size = new System.Drawing.Size(110, 18);
            this.labelPackageName.TabIndex = 0;
            this.labelPackageName.Text = "Package Name";
            // 
            // FormBookingPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 334);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBookingPackage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Package";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxPackageAmount;
        private System.Windows.Forms.Label labelPackageAmount;
        private System.Windows.Forms.TextBox textBoxPackageName;
        private System.Windows.Forms.Label labelPackageName;
        private System.Windows.Forms.TextBox textBoxPackageDescription;
        private System.Windows.Forms.Label labelPackageDescription;
        private System.Windows.Forms.ComboBox comboBoxHallName;
        private System.Windows.Forms.Label labelHallName;
    }
}