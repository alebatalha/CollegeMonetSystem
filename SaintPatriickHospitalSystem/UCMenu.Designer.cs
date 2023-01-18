namespace CollegeMonetSystem
{
    partial class UCMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMenu));
            this.pnltop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPat = new System.Windows.Forms.Button();
            this.btnEmp = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pnltop.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(149)))), ((int)(((byte)(207)))));
            this.pnltop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnltop.BackgroundImage")));
            this.pnltop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnltop.Controls.Add(this.lblTitle);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Margin = new System.Windows.Forms.Padding(4);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(813, 229);
            this.pnltop.TabIndex = 31;
            this.pnltop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnltop_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(214, 179);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "College Monet System";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnPat
            // 
            this.btnPat.BackColor = System.Drawing.Color.White;
            this.btnPat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPat.BackgroundImage")));
            this.btnPat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPat.FlatAppearance.BorderSize = 0;
            this.btnPat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnPat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPat.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnPat.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnPat.Location = new System.Drawing.Point(570, 460);
            this.btnPat.Margin = new System.Windows.Forms.Padding(4);
            this.btnPat.Name = "btnPat";
            this.btnPat.Size = new System.Drawing.Size(219, 159);
            this.btnPat.TabIndex = 14;
            this.btnPat.Text = "Manage Student";
            this.btnPat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPat.UseVisualStyleBackColor = false;
            this.btnPat.Click += new System.EventHandler(this.btnPat_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.BackColor = System.Drawing.Color.White;
            this.btnEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmp.BackgroundImage")));
            this.btnEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmp.FlatAppearance.BorderSize = 0;
            this.btnEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmp.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnEmp.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnEmp.Location = new System.Drawing.Point(575, 258);
            this.btnEmp.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(214, 165);
            this.btnEmp.TabIndex = 13;
            this.btnEmp.Text = "Manage Employee";
            this.btnEmp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmp.UseVisualStyleBackColor = false;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContainer.BackgroundImage")));
            this.panelContainer.Controls.Add(this.btnPat);
            this.panelContainer.Controls.Add(this.btnEmp);
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(813, 737);
            this.panelContainer.TabIndex = 32;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // UCMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCMenu";
            this.Size = new System.Drawing.Size(813, 741);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPat;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.Panel panelContainer;
    }
}
