namespace WindowsFormsApplication1
{
    partial class Nhập_học_viên_mới
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_lop = new System.Windows.Forms.ComboBox();
            this.txt_hovaten = new System.Windows.Forms.TextBox();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_trove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp";
            // 
            // cbo_lop
            // 
            this.cbo_lop.FormattingEnabled = true;
            this.cbo_lop.Location = new System.Drawing.Point(108, 58);
            this.cbo_lop.Name = "cbo_lop";
            this.cbo_lop.Size = new System.Drawing.Size(188, 21);
            this.cbo_lop.TabIndex = 2;
            this.cbo_lop.SelectedIndexChanged += new System.EventHandler(this.cbo_lop_SelectedIndexChanged);
            // 
            // txt_hovaten
            // 
            this.txt_hovaten.Location = new System.Drawing.Point(108, 25);
            this.txt_hovaten.Name = "txt_hovaten";
            this.txt_hovaten.Size = new System.Drawing.Size(188, 20);
            this.txt_hovaten.TabIndex = 3;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.Location = new System.Drawing.Point(108, 99);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(75, 30);
            this.btn_capnhat.TabIndex = 4;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            // 
            // btn_trove
            // 
            this.btn_trove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trove.Location = new System.Drawing.Point(221, 99);
            this.btn_trove.Name = "btn_trove";
            this.btn_trove.Size = new System.Drawing.Size(75, 30);
            this.btn_trove.TabIndex = 5;
            this.btn_trove.Text = "Trở về";
            this.btn_trove.UseVisualStyleBackColor = true;
            // 
            // Nhập_học_viên_mới
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 165);
            this.Controls.Add(this.btn_trove);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.txt_hovaten);
            this.Controls.Add(this.cbo_lop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Nhập_học_viên_mới";
            this.Text = "Nhập học viên mới";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_lop;
        private System.Windows.Forms.TextBox txt_hovaten;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_trove;
    }
}