namespace RentCar.App
{
    partial class Layout
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
            this.rentCarDbContextView1 = new RentCar.App.Views.RentCarDbContextView.RentCarDbContextView();
            this.SuspendLayout();
            // 
            // rentCarDbContextView1
            // 
            this.rentCarDbContextView1.Appearance.BackColor = System.Drawing.Color.White;
            this.rentCarDbContextView1.Appearance.Options.UseBackColor = true;
            this.rentCarDbContextView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentCarDbContextView1.Location = new System.Drawing.Point(0, 0);
            this.rentCarDbContextView1.Name = "rentCarDbContextView1";
            this.rentCarDbContextView1.Size = new System.Drawing.Size(703, 495);
            this.rentCarDbContextView1.TabIndex = 0;
            // 
            // Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 495);
            this.Controls.Add(this.rentCarDbContextView1);
            this.Name = "Layout";
            this.Text = "Rent Car";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Views.RentCarDbContextView.RentCarDbContextView rentCarDbContextView1;
    }
}