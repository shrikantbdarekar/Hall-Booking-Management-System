
namespace HallBookingManagementSystem
{
    partial class FormMDI
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
            this.menuStripMDI = new System.Windows.Forms.MenuStrip();
            this.mnuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVenueDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookingType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEventType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHall = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookingPackage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEventBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaymentCollection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookingReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaymentCollectionReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDuePaymentReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMDI
            // 
            this.menuStripMDI.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetting,
            this.mnuBookingPackage,
            this.mnuCustomer,
            this.mnuEventBooking,
            this.mnuPaymentCollection,
            this.mnuReports,
            this.mnuExit});
            this.menuStripMDI.Location = new System.Drawing.Point(0, 0);
            this.menuStripMDI.Name = "menuStripMDI";
            this.menuStripMDI.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStripMDI.Size = new System.Drawing.Size(822, 30);
            this.menuStripMDI.TabIndex = 0;
            this.menuStripMDI.Text = "menuStrip1";
            // 
            // mnuSetting
            // 
            this.mnuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVenueDetails,
            this.mnuBookingType,
            this.mnuEventType,
            this.mnuHall,
            this.mnuUsers});
            this.mnuSetting.Name = "mnuSetting";
            this.mnuSetting.Size = new System.Drawing.Size(76, 24);
            this.mnuSetting.Text = "Setting |";
            // 
            // mnuVenueDetails
            // 
            this.mnuVenueDetails.Name = "mnuVenueDetails";
            this.mnuVenueDetails.Size = new System.Drawing.Size(168, 24);
            this.mnuVenueDetails.Text = "Venue Details";
            this.mnuVenueDetails.Click += new System.EventHandler(this.mnuVenueDetails_Click);
            // 
            // mnuBookingType
            // 
            this.mnuBookingType.Name = "mnuBookingType";
            this.mnuBookingType.Size = new System.Drawing.Size(168, 24);
            this.mnuBookingType.Text = "Booking Type";
            this.mnuBookingType.Click += new System.EventHandler(this.mnuBookingType_Click);
            // 
            // mnuEventType
            // 
            this.mnuEventType.Name = "mnuEventType";
            this.mnuEventType.Size = new System.Drawing.Size(168, 24);
            this.mnuEventType.Text = "Event Type";
            this.mnuEventType.Click += new System.EventHandler(this.mnuEventType_Click);
            // 
            // mnuHall
            // 
            this.mnuHall.Name = "mnuHall";
            this.mnuHall.Size = new System.Drawing.Size(168, 24);
            this.mnuHall.Text = "Hall Master";
            this.mnuHall.Click += new System.EventHandler(this.mnuHall_Click);
            // 
            // mnuUsers
            // 
            this.mnuUsers.Name = "mnuUsers";
            this.mnuUsers.Size = new System.Drawing.Size(168, 24);
            this.mnuUsers.Text = "Users";
            this.mnuUsers.Click += new System.EventHandler(this.mnuUsers_Click);
            // 
            // mnuBookingPackage
            // 
            this.mnuBookingPackage.Name = "mnuBookingPackage";
            this.mnuBookingPackage.Size = new System.Drawing.Size(142, 24);
            this.mnuBookingPackage.Text = "Booking Package |";
            this.mnuBookingPackage.Click += new System.EventHandler(this.mnuBookingPackage_Click);
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Size = new System.Drawing.Size(92, 24);
            this.mnuCustomer.Text = "Customer |";
            this.mnuCustomer.Click += new System.EventHandler(this.mnuCustomer_Click);
            // 
            // mnuEventBooking
            // 
            this.mnuEventBooking.Name = "mnuEventBooking";
            this.mnuEventBooking.Size = new System.Drawing.Size(124, 24);
            this.mnuEventBooking.Text = "Event Booking |";
            this.mnuEventBooking.Click += new System.EventHandler(this.mnuEventBooking_Click);
            // 
            // mnuPaymentCollection
            // 
            this.mnuPaymentCollection.Name = "mnuPaymentCollection";
            this.mnuPaymentCollection.Size = new System.Drawing.Size(156, 24);
            this.mnuPaymentCollection.Text = "Payment Collection |";
            this.mnuPaymentCollection.Click += new System.EventHandler(this.mnuPaymentCollection_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCustomerReport,
            this.mnuBookingReport,
            this.mnuPaymentCollectionReport,
            this.mnuDuePaymentReport});
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(80, 24);
            this.mnuReports.Text = "Reports |";
            // 
            // mnuCustomerReport
            // 
            this.mnuCustomerReport.Name = "mnuCustomerReport";
            this.mnuCustomerReport.Size = new System.Drawing.Size(254, 24);
            this.mnuCustomerReport.Text = "Customer Report";
            this.mnuCustomerReport.Click += new System.EventHandler(this.mnuCustomerReport_Click);
            // 
            // mnuBookingReport
            // 
            this.mnuBookingReport.Name = "mnuBookingReport";
            this.mnuBookingReport.Size = new System.Drawing.Size(254, 24);
            this.mnuBookingReport.Text = "Booking Report";
            this.mnuBookingReport.Click += new System.EventHandler(this.mnuBookingReport_Click);
            // 
            // mnuPaymentCollectionReport
            // 
            this.mnuPaymentCollectionReport.Name = "mnuPaymentCollectionReport";
            this.mnuPaymentCollectionReport.Size = new System.Drawing.Size(254, 24);
            this.mnuPaymentCollectionReport.Text = "Payment Collection Report";
            this.mnuPaymentCollectionReport.Click += new System.EventHandler(this.mnuPaymentCollectionReport_Click);
            // 
            // mnuDuePaymentReport
            // 
            this.mnuDuePaymentReport.Name = "mnuDuePaymentReport";
            this.mnuDuePaymentReport.Size = new System.Drawing.Size(254, 24);
            this.mnuDuePaymentReport.Text = "Due Payment Report";
            this.mnuDuePaymentReport.Click += new System.EventHandler(this.mnuDuePaymentReport_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(45, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 391);
            this.Controls.Add(this.menuStripMDI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripMDI;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMDI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Name";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMDI_Load);
            this.menuStripMDI.ResumeLayout(false);
            this.menuStripMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMDI;
        private System.Windows.Forms.ToolStripMenuItem mnuSetting;
        private System.Windows.Forms.ToolStripMenuItem mnuVenueDetails;
        private System.Windows.Forms.ToolStripMenuItem mnuBookingType;
        private System.Windows.Forms.ToolStripMenuItem mnuEventType;
        private System.Windows.Forms.ToolStripMenuItem mnuUsers;
        private System.Windows.Forms.ToolStripMenuItem mnuBookingPackage;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuEventBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuPaymentCollection;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHall;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerReport;
        private System.Windows.Forms.ToolStripMenuItem mnuBookingReport;
        private System.Windows.Forms.ToolStripMenuItem mnuPaymentCollectionReport;
        private System.Windows.Forms.ToolStripMenuItem mnuDuePaymentReport;
    }
}

