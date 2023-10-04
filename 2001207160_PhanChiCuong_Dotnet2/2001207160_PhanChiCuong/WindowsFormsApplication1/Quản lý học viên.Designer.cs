namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHọcViênMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnSangLớpBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnSangLớpAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaHọcViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtThúcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grp_A = new System.Windows.Forms.GroupBox();
            this.lst_A = new System.Windows.Forms.ListBox();
            this.grp_B = new System.Windows.Forms.GroupBox();
            this.lst_B = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.grp_A.SuspendLayout();
            this.grp_B.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtToolStripMenuItem,
            this.kếtThúcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpHọcViênMớiToolStripMenuItem,
            this.chuyểnSangLớpBToolStripMenuItem,
            this.chuyểnSangLớpAToolStripMenuItem,
            this.xóaHọcViênToolStripMenuItem});
            this.cậpNhậtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            // 
            // nhậpHọcViênMớiToolStripMenuItem
            // 
            this.nhậpHọcViênMớiToolStripMenuItem.Name = "nhậpHọcViênMớiToolStripMenuItem";
            this.nhậpHọcViênMớiToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.nhậpHọcViênMớiToolStripMenuItem.Text = "Nhập học viên mới";
            this.nhậpHọcViênMớiToolStripMenuItem.Click += new System.EventHandler(this.nhậpHọcViênMớiToolStripMenuItem_Click);
            // 
            // chuyểnSangLớpBToolStripMenuItem
            // 
            this.chuyểnSangLớpBToolStripMenuItem.Name = "chuyểnSangLớpBToolStripMenuItem";
            this.chuyểnSangLớpBToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.chuyểnSangLớpBToolStripMenuItem.Text = "Chuyển sang lớp B";
            this.chuyểnSangLớpBToolStripMenuItem.Click += new System.EventHandler(this.chuyểnSangLớpBToolStripMenuItem_Click);
            // 
            // chuyểnSangLớpAToolStripMenuItem
            // 
            this.chuyểnSangLớpAToolStripMenuItem.Name = "chuyểnSangLớpAToolStripMenuItem";
            this.chuyểnSangLớpAToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.chuyểnSangLớpAToolStripMenuItem.Text = "Chuyển sang lớp A";
            this.chuyểnSangLớpAToolStripMenuItem.Click += new System.EventHandler(this.chuyểnSangLớpAToolStripMenuItem_Click);
            // 
            // xóaHọcViênToolStripMenuItem
            // 
            this.xóaHọcViênToolStripMenuItem.Name = "xóaHọcViênToolStripMenuItem";
            this.xóaHọcViênToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.xóaHọcViênToolStripMenuItem.Text = "Xóa học viên";
            // 
            // kếtThúcToolStripMenuItem
            // 
            this.kếtThúcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            this.kếtThúcToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.kếtThúcToolStripMenuItem.Text = "&Kết Thúc";
            // 
            // grp_A
            // 
            this.grp_A.Controls.Add(this.lst_A);
            this.grp_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_A.Location = new System.Drawing.Point(12, 45);
            this.grp_A.Name = "grp_A";
            this.grp_A.Size = new System.Drawing.Size(155, 172);
            this.grp_A.TabIndex = 1;
            this.grp_A.TabStop = false;
            this.grp_A.Text = "Lớp A";
            // 
            // lst_A
            // 
            this.lst_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_A.FormattingEnabled = true;
            this.lst_A.ItemHeight = 18;
            this.lst_A.Items.AddRange(new object[] {
            "Trần Hùng",
            "Nguyễn Hưng",
            "Lâm Tứ"});
            this.lst_A.Location = new System.Drawing.Point(0, 19);
            this.lst_A.Name = "lst_A";
            this.lst_A.Size = new System.Drawing.Size(149, 130);
            this.lst_A.TabIndex = 0;
            // 
            // grp_B
            // 
            this.grp_B.Controls.Add(this.lst_B);
            this.grp_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_B.Location = new System.Drawing.Point(208, 45);
            this.grp_B.Name = "grp_B";
            this.grp_B.Size = new System.Drawing.Size(147, 172);
            this.grp_B.TabIndex = 2;
            this.grp_B.TabStop = false;
            this.grp_B.Text = "Lớp B";
            // 
            // lst_B
            // 
            this.lst_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_B.FormattingEnabled = true;
            this.lst_B.ItemHeight = 18;
            this.lst_B.Items.AddRange(new object[] {
            "Tuấn Hưng",
            "Hồng Ngọc",
            "Anh Minh",
            "Bảo Lâm"});
            this.lst_B.Location = new System.Drawing.Point(6, 19);
            this.lst_B.Name = "lst_B";
            this.lst_B.Size = new System.Drawing.Size(135, 130);
            this.lst_B.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 235);
            this.Controls.Add(this.grp_B);
            this.Controls.Add(this.grp_A);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Quản lý học viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grp_A.ResumeLayout(false);
            this.grp_B.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHọcViênMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnSangLớpBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnSangLớpAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaHọcViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtThúcToolStripMenuItem;
        private System.Windows.Forms.GroupBox grp_A;
        private System.Windows.Forms.ListBox lst_A;
        private System.Windows.Forms.GroupBox grp_B;
        private System.Windows.Forms.ListBox lst_B;
    }
}