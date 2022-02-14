namespace Cst150Project
{
    partial class AdminPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPortal));
            this.AdminStatement_lbl = new System.Windows.Forms.Label();
            this.AdminPortalExit_lbl = new System.Windows.Forms.Label();
            this.ModifyMembers_btn = new System.Windows.Forms.Button();
            this.ModifyItems_btn = new System.Windows.Forms.Button();
            this.ModifyStaff_btn = new System.Windows.Forms.Button();
            this.ModifyClasses_btn = new System.Windows.Forms.Button();
            this.AdminPortalLogout_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminStatement_lbl
            // 
            this.AdminStatement_lbl.AutoSize = true;
            this.AdminStatement_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminStatement_lbl.Location = new System.Drawing.Point(486, 139);
            this.AdminStatement_lbl.Name = "AdminStatement_lbl";
            this.AdminStatement_lbl.Size = new System.Drawing.Size(460, 82);
            this.AdminStatement_lbl.TabIndex = 0;
            this.AdminStatement_lbl.Text = "Admin Portal";
            // 
            // AdminPortalExit_lbl
            // 
            this.AdminPortalExit_lbl.AutoSize = true;
            this.AdminPortalExit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPortalExit_lbl.Location = new System.Drawing.Point(1281, 9);
            this.AdminPortalExit_lbl.Name = "AdminPortalExit_lbl";
            this.AdminPortalExit_lbl.Size = new System.Drawing.Size(39, 37);
            this.AdminPortalExit_lbl.TabIndex = 1;
            this.AdminPortalExit_lbl.Text = "X";
            this.AdminPortalExit_lbl.Click += new System.EventHandler(this.AdminPortalExit_lbl_Click);
            // 
            // ModifyMembers_btn
            // 
            this.ModifyMembers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyMembers_btn.Location = new System.Drawing.Point(120, 328);
            this.ModifyMembers_btn.Name = "ModifyMembers_btn";
            this.ModifyMembers_btn.Size = new System.Drawing.Size(213, 60);
            this.ModifyMembers_btn.TabIndex = 2;
            this.ModifyMembers_btn.Text = "Members";
            this.ModifyMembers_btn.UseVisualStyleBackColor = true;
            this.ModifyMembers_btn.Click += new System.EventHandler(this.ModifyMembers_btn_Click);
            // 
            // ModifyItems_btn
            // 
            this.ModifyItems_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyItems_btn.Location = new System.Drawing.Point(368, 328);
            this.ModifyItems_btn.Name = "ModifyItems_btn";
            this.ModifyItems_btn.Size = new System.Drawing.Size(218, 60);
            this.ModifyItems_btn.TabIndex = 2;
            this.ModifyItems_btn.Text = "Items";
            this.ModifyItems_btn.UseVisualStyleBackColor = true;
            this.ModifyItems_btn.Click += new System.EventHandler(this.ModifyItems_btn_Click);
            // 
            // ModifyStaff_btn
            // 
            this.ModifyStaff_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyStaff_btn.Location = new System.Drawing.Point(691, 328);
            this.ModifyStaff_btn.Name = "ModifyStaff_btn";
            this.ModifyStaff_btn.Size = new System.Drawing.Size(188, 60);
            this.ModifyStaff_btn.TabIndex = 2;
            this.ModifyStaff_btn.Text = "Staff";
            this.ModifyStaff_btn.UseVisualStyleBackColor = true;
            // 
            // ModifyClasses_btn
            // 
            this.ModifyClasses_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyClasses_btn.Location = new System.Drawing.Point(948, 328);
            this.ModifyClasses_btn.Name = "ModifyClasses_btn";
            this.ModifyClasses_btn.Size = new System.Drawing.Size(198, 60);
            this.ModifyClasses_btn.TabIndex = 2;
            this.ModifyClasses_btn.Text = "Classes";
            this.ModifyClasses_btn.UseVisualStyleBackColor = true;
            // 
            // AdminPortalLogout_btn
            // 
            this.AdminPortalLogout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPortalLogout_btn.Location = new System.Drawing.Point(570, 425);
            this.AdminPortalLogout_btn.Name = "AdminPortalLogout_btn";
            this.AdminPortalLogout_btn.Size = new System.Drawing.Size(157, 62);
            this.AdminPortalLogout_btn.TabIndex = 2;
            this.AdminPortalLogout_btn.Text = "Logout";
            this.AdminPortalLogout_btn.UseVisualStyleBackColor = true;
            this.AdminPortalLogout_btn.Click += new System.EventHandler(this.AdminPortalLogout_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(533, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AdminPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1320, 721);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AdminPortalLogout_btn);
            this.Controls.Add(this.ModifyClasses_btn);
            this.Controls.Add(this.ModifyStaff_btn);
            this.Controls.Add(this.ModifyItems_btn);
            this.Controls.Add(this.ModifyMembers_btn);
            this.Controls.Add(this.AdminPortalExit_lbl);
            this.Controls.Add(this.AdminStatement_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Portal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminStatement_lbl;
        private System.Windows.Forms.Label AdminPortalExit_lbl;
        private System.Windows.Forms.Button ModifyMembers_btn;
        private System.Windows.Forms.Button ModifyItems_btn;
        private System.Windows.Forms.Button ModifyStaff_btn;
        private System.Windows.Forms.Button ModifyClasses_btn;
        private System.Windows.Forms.Button AdminPortalLogout_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}