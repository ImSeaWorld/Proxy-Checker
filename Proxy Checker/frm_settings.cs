using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proxy_Checker
{
    public partial class frm_settings : Form
    {
        public frm_settings()
        {
            InitializeComponent();
        }

        private void frm_settings_Load(object sender, EventArgs e)
        {
            nud_maxLate.Value = Properties.Settings.Default.int_maxLate;
            rb_webReq.Checked = Properties.Settings.Default.b_checkType;
            rb_sockets.Checked = !Properties.Settings.Default.b_checkType;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.b_checkType = rb_webReq.Checked ? true : false;
            Properties.Settings.Default.int_maxLate = Convert.ToInt32(nud_maxLate.Value);
            Properties.Settings.Default.Save();
            MessageBox.Show("Settings saved!");
            this.Close();
        }
    }
}
