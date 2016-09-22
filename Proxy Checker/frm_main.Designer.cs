namespace Proxy_Checker
{
    partial class frm_main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.lv_unchecked = new System.Windows.Forms.ListView();
            this.ch_uc_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_uc_ip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_uc_port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsi_load = new System.Windows.Forms.ToolStripMenuItem();
            this.tsi_saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsi_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_checked = new System.Windows.Forms.ListView();
            this.ch_c_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_c_ip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_c_port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_latency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_ping = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_unchecked = new System.Windows.Forms.Label();
            this.lbl_checked = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cms_checked = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_unchecked = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsi_c_removeSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsi_c_removeAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsi_c_reping = new System.Windows.Forms.ToolStripMenuItem();
            this.tsi_uc_removeSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsi_uc_removeAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.cms_checked.SuspendLayout();
            this.cms_unchecked.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_unchecked
            // 
            this.lv_unchecked.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_unchecked.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_uc_num,
            this.ch_uc_ip,
            this.ch_uc_port});
            this.lv_unchecked.FullRowSelect = true;
            this.lv_unchecked.GridLines = true;
            this.lv_unchecked.Location = new System.Drawing.Point(6, 19);
            this.lv_unchecked.Name = "lv_unchecked";
            this.lv_unchecked.Size = new System.Drawing.Size(342, 192);
            this.lv_unchecked.TabIndex = 0;
            this.lv_unchecked.UseCompatibleStateImageBehavior = false;
            this.lv_unchecked.View = System.Windows.Forms.View.Details;
            this.lv_unchecked.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lv_unchecked_MouseDown);
            // 
            // ch_uc_num
            // 
            this.ch_uc_num.Text = "#";
            this.ch_uc_num.Width = 77;
            // 
            // ch_uc_ip
            // 
            this.ch_uc_ip.Text = "IP";
            this.ch_uc_ip.Width = 152;
            // 
            // ch_uc_port
            // 
            this.ch_uc_port.Text = "Port";
            this.ch_uc_port.Width = 88;
            // 
            // ms_main
            // 
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tsi_settings});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(378, 24);
            this.ms_main.TabIndex = 1;
            this.ms_main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsi_load,
            this.tsi_saveAs,
            this.tsi_save});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsi_load
            // 
            this.tsi_load.Name = "tsi_load";
            this.tsi_load.Size = new System.Drawing.Size(152, 22);
            this.tsi_load.Text = "Load Proxies";
            this.tsi_load.Click += new System.EventHandler(this.tsi_load_Click);
            // 
            // tsi_saveAs
            // 
            this.tsi_saveAs.Name = "tsi_saveAs";
            this.tsi_saveAs.Size = new System.Drawing.Size(152, 22);
            this.tsi_saveAs.Text = "Save As";
            this.tsi_saveAs.Click += new System.EventHandler(this.tsi_saveAs_Click);
            // 
            // tsi_save
            // 
            this.tsi_save.Name = "tsi_save";
            this.tsi_save.Size = new System.Drawing.Size(152, 22);
            this.tsi_save.Text = "Save";
            this.tsi_save.Click += new System.EventHandler(this.tsi_save_Click);
            // 
            // tsi_settings
            // 
            this.tsi_settings.Name = "tsi_settings";
            this.tsi_settings.Size = new System.Drawing.Size(61, 20);
            this.tsi_settings.Text = "Settings";
            this.tsi_settings.Click += new System.EventHandler(this.tsi_settings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lv_unchecked);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 217);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unchecked";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lv_checked);
            this.groupBox2.Location = new System.Drawing.Point(12, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 217);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Checked";
            // 
            // lv_checked
            // 
            this.lv_checked.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_checked.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_c_num,
            this.ch_c_ip,
            this.ch_c_port,
            this.ch_latency,
            this.ch_ping});
            this.lv_checked.FullRowSelect = true;
            this.lv_checked.GridLines = true;
            this.lv_checked.Location = new System.Drawing.Point(6, 19);
            this.lv_checked.Name = "lv_checked";
            this.lv_checked.Size = new System.Drawing.Size(342, 192);
            this.lv_checked.TabIndex = 0;
            this.lv_checked.UseCompatibleStateImageBehavior = false;
            this.lv_checked.View = System.Windows.Forms.View.Details;
            this.lv_checked.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lv_checked_MouseDown);
            // 
            // ch_c_num
            // 
            this.ch_c_num.Text = "#";
            this.ch_c_num.Width = 39;
            // 
            // ch_c_ip
            // 
            this.ch_c_ip.Text = "IP";
            this.ch_c_ip.Width = 93;
            // 
            // ch_c_port
            // 
            this.ch_c_port.Text = "Port";
            this.ch_c_port.Width = 64;
            // 
            // ch_latency
            // 
            this.ch_latency.Text = "Latency";
            this.ch_latency.Width = 63;
            // 
            // ch_ping
            // 
            this.ch_ping.Text = "Ping";
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(64, 474);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(132, 42);
            this.btn_check.TabIndex = 4;
            this.btn_check.Text = "Check Proxies";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unchecked:";
            // 
            // lbl_unchecked
            // 
            this.lbl_unchecked.AutoSize = true;
            this.lbl_unchecked.Location = new System.Drawing.Point(266, 482);
            this.lbl_unchecked.Name = "lbl_unchecked";
            this.lbl_unchecked.Size = new System.Drawing.Size(13, 13);
            this.lbl_unchecked.TabIndex = 6;
            this.lbl_unchecked.Text = "0";
            // 
            // lbl_checked
            // 
            this.lbl_checked.AutoSize = true;
            this.lbl_checked.Location = new System.Drawing.Point(266, 498);
            this.lbl_checked.Name = "lbl_checked";
            this.lbl_checked.Size = new System.Drawing.Size(13, 13);
            this.lbl_checked.TabIndex = 8;
            this.lbl_checked.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Checked:";
            // 
            // cms_checked
            // 
            this.cms_checked.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsi_c_reping,
            this.tsi_c_removeSelected,
            this.tsi_c_removeAll});
            this.cms_checked.Name = "cms_checked";
            this.cms_checked.ShowImageMargin = false;
            this.cms_checked.Size = new System.Drawing.Size(140, 70);
            // 
            // cms_unchecked
            // 
            this.cms_unchecked.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsi_uc_removeSelected,
            this.tsi_uc_removeAll});
            this.cms_unchecked.Name = "cms_unchecked";
            this.cms_unchecked.ShowImageMargin = false;
            this.cms_unchecked.Size = new System.Drawing.Size(140, 70);
            // 
            // tsi_c_removeSelected
            // 
            this.tsi_c_removeSelected.Name = "tsi_c_removeSelected";
            this.tsi_c_removeSelected.Size = new System.Drawing.Size(139, 22);
            this.tsi_c_removeSelected.Text = "Remove Selected";
            this.tsi_c_removeSelected.Click += new System.EventHandler(this.tsi_c_removeSelected_Click);
            // 
            // tsi_c_removeAll
            // 
            this.tsi_c_removeAll.Name = "tsi_c_removeAll";
            this.tsi_c_removeAll.Size = new System.Drawing.Size(139, 22);
            this.tsi_c_removeAll.Text = "Remove All";
            this.tsi_c_removeAll.Click += new System.EventHandler(this.tsi_c_removeAll_Click);
            // 
            // tsi_c_reping
            // 
            this.tsi_c_reping.Name = "tsi_c_reping";
            this.tsi_c_reping.Size = new System.Drawing.Size(164, 22);
            this.tsi_c_reping.Text = "Ping Again";
            this.tsi_c_reping.Click += new System.EventHandler(this.tsi_c_reping_Click);
            // 
            // tsi_uc_removeSelected
            // 
            this.tsi_uc_removeSelected.Name = "tsi_uc_removeSelected";
            this.tsi_uc_removeSelected.Size = new System.Drawing.Size(139, 22);
            this.tsi_uc_removeSelected.Text = "Remove Selected";
            this.tsi_uc_removeSelected.Click += new System.EventHandler(this.tsi_uc_removeSelected_Click);
            // 
            // tsi_uc_removeAll
            // 
            this.tsi_uc_removeAll.Name = "tsi_uc_removeAll";
            this.tsi_uc_removeAll.Size = new System.Drawing.Size(139, 22);
            this.tsi_uc_removeAll.Text = "Remove All";
            this.tsi_uc_removeAll.Click += new System.EventHandler(this.tsi_uc_removeAll_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 526);
            this.Controls.Add(this.lbl_checked);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_unchecked);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ms_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_main;
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proxy Checker";
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.cms_checked.ResumeLayout(false);
            this.cms_unchecked.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_unchecked;
        private System.Windows.Forms.ColumnHeader ch_uc_num;
        private System.Windows.Forms.ColumnHeader ch_uc_ip;
        private System.Windows.Forms.ColumnHeader ch_uc_port;
        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsi_load;
        private System.Windows.Forms.ToolStripMenuItem tsi_saveAs;
        private System.Windows.Forms.ToolStripMenuItem tsi_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_checked;
        private System.Windows.Forms.ColumnHeader ch_c_num;
        private System.Windows.Forms.ColumnHeader ch_c_ip;
        private System.Windows.Forms.ColumnHeader ch_c_port;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_unchecked;
        private System.Windows.Forms.Label lbl_checked;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader ch_latency;
        private System.Windows.Forms.ToolStripMenuItem tsi_settings;
        private System.Windows.Forms.ColumnHeader ch_ping;
        private System.Windows.Forms.ContextMenuStrip cms_checked;
        private System.Windows.Forms.ToolStripMenuItem tsi_c_reping;
        private System.Windows.Forms.ToolStripMenuItem tsi_c_removeSelected;
        private System.Windows.Forms.ToolStripMenuItem tsi_c_removeAll;
        private System.Windows.Forms.ContextMenuStrip cms_unchecked;
        private System.Windows.Forms.ToolStripMenuItem tsi_uc_removeSelected;
        private System.Windows.Forms.ToolStripMenuItem tsi_uc_removeAll;
    }
}

