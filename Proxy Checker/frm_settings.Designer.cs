namespace Proxy_Checker
{
    partial class frm_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_settings));
            this.nud_maxLate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_sockets = new System.Windows.Forms.RadioButton();
            this.rb_webReq = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxLate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nud_maxLate
            // 
            this.nud_maxLate.Location = new System.Drawing.Point(46, 34);
            this.nud_maxLate.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nud_maxLate.Name = "nud_maxLate";
            this.nud_maxLate.Size = new System.Drawing.Size(104, 20);
            this.nud_maxLate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exclude proxies that exceed this latency:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(8, 121);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(211, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ms";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_maxLate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Latency";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_webReq);
            this.groupBox2.Controls.Add(this.rb_sockets);
            this.groupBox2.Location = new System.Drawing.Point(8, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 46);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check Type";
            // 
            // rb_sockets
            // 
            this.rb_sockets.AutoSize = true;
            this.rb_sockets.Location = new System.Drawing.Point(136, 19);
            this.rb_sockets.Name = "rb_sockets";
            this.rb_sockets.Size = new System.Drawing.Size(64, 17);
            this.rb_sockets.TabIndex = 0;
            this.rb_sockets.Text = "Sockets";
            this.rb_sockets.UseVisualStyleBackColor = true;
            // 
            // rb_webReq
            // 
            this.rb_webReq.AutoSize = true;
            this.rb_webReq.Checked = true;
            this.rb_webReq.Location = new System.Drawing.Point(6, 19);
            this.rb_webReq.Name = "rb_webReq";
            this.rb_webReq.Size = new System.Drawing.Size(117, 17);
            this.rb_webReq.TabIndex = 1;
            this.rb_webReq.TabStop = true;
            this.rb_webReq.Text = "HTTPWebRequest";
            this.rb_webReq.UseVisualStyleBackColor = true;
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 151);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.frm_settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxLate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_maxLate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_webReq;
        private System.Windows.Forms.RadioButton rb_sockets;
    }
}