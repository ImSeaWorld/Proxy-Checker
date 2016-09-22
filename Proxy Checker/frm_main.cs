using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProxSocks;
using System.IO;
using FormEssentials;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Web;
using System.Threading;
using System.Security.Cryptography;
using System.Reflection;
using System.Diagnostics;

namespace Proxy_Checker
{
    public partial class frm_main : Form
    {
        private frm_settings settings = new frm_settings();
        private ProxSocks.ProxSocks proxSocks = new ProxSocks.ProxSocks();
        private Thread checkProx, loopThread;
        private int uncheckedProx = 0, checkedProx = 0, verifiedProx = 0;

        public frm_main()
        {
            InitializeComponent();
        }

        private void tsi_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Get The List Faggot.";
            ofd.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK) {
                if (ofd.FileName != "") {
                    foreach (string file in ofd.FileNames) {
                        foreach (string prox in File.ReadAllLines(file)) {
                            if (!Forms.ListViews.doesItemExistLV(lv_unchecked, prox.Split(':')[0], true))
                                Forms.ListViews.addToListView(lv_unchecked, (++uncheckedProx).ToString(), prox.Split(':')[0], prox.Split(':')[1]);
                        }
                    } lbl_unchecked.Text = uncheckedProx.ToString();
                }
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            verifiedProx = 0;
            lv_checked.Items.Clear();
            
            loopThread = new Thread(new ThreadStart(delegate {
                Invoke(new MethodInvoker(delegate {
                    foreach (ListViewItem items in lv_unchecked.Items) {
                        checkProx = new Thread(new ThreadStart(delegate {
                            var SW = new Stopwatch();
                            var Ping = PingLatency(items.SubItems[1].Text);
                            SW.Start();
                            if (Properties.Settings.Default.b_checkType ? WebReq(items.SubItems[1].Text, Convert.ToInt32(items.SubItems[2].Text)) : Sockets("www.google.com", "GET / HTTP/1.1", "Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:48.0) Gecko/20100101 Firefox/48.0.2 Waterfox/48.0.2", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "gzip, deflate", "", "en-US,en;q=0.5", "", "", "", "", items.SubItems[1].Text, Convert.ToInt32(items.SubItems[2].Text), true)) {
                                SW.Stop();
                                if (SW.ElapsedMilliseconds <= Properties.Settings.Default.int_maxLate || Properties.Settings.Default.int_maxLate == 0) {
                                    Invoke(new MethodInvoker(delegate {
                                        Forms.ListViews.addToListView(lv_checked, (++verifiedProx).ToString(), items.SubItems[1].Text, items.SubItems[2].Text, SW.ElapsedMilliseconds + " ms", Ping);
                                        updateLabels();
                                    }));
                                }
                            }
                        }));
                        checkProx.Name = "Check Proxy Thread"; 
                        checkProx.Start();
                    }
                }));
            })); loopThread.Start();
        }

        private void tsi_settings_Click(object sender, EventArgs e)
        {
            if (Forms.isFormOpen(settings))
                settings.BringToFront();
            else { settings = new frm_settings(); settings.Show(); }
        }

        private void tsi_saveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save The List Faggot.";
            sfd.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";
            sfd.FileName = "Checked Proxy List - " + DateTimes.DateTimeToUnix_s(DateTime.Now) + ".txt";

            if (sfd.ShowDialog() == DialogResult.OK) {
                if (sfd.FileName != "") {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName)) {
                        foreach (ListViewItem item in lv_checked.Items) {
                            sw.WriteLine("{0}:{1}", item.SubItems[1].Text, item.SubItems[2].Text);
                        }
                    }
                }
            }
        }

        private void tsi_save_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("Saved Proxies"))
                Directory.CreateDirectory("Saved Proxies");

            using (StreamWriter sw = new StreamWriter("Saved Proxies\\" + DateTimes.DateTimeToUnix_s(DateTime.Now) + ".txt"))
                foreach (ListViewItem item in lv_checked.Items)
                    sw.WriteLine("{0}:{1}", item.SubItems[1].Text, item.SubItems[2].Text);

            MessageBox.Show("Saved proxy list locally. Check the directory the application was ran in.");
        }

        private void tsi_c_reping_Click(object sender, EventArgs e)
        {
            if (lv_checked.SelectedItems.Count > 0)
                lv_checked.SelectedItems[0].SubItems[4].Text = PingLatency(lv_checked.SelectedItems[0].SubItems[1].Text);
        }

        private void lv_unchecked_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                lv_unchecked.ContextMenuStrip = cms_unchecked;
                lv_unchecked.ContextMenuStrip.Show(lv_unchecked, e.Location);
            }
        }

        private void lv_checked_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                lv_checked.ContextMenuStrip = cms_checked;
                lv_checked.ContextMenuStrip.Show(lv_checked, e.Location);
            }
        }

        private void tsi_c_removeSelected_Click(object sender, EventArgs e)
        {
            if (lv_checked.SelectedItems.Count > 0)
                foreach (ListViewItem item in lv_checked.SelectedItems) {
                    verifiedProx--;
                    item.Remove();
                    updateLabels();
                }
        }

        private void tsi_c_removeAll_Click(object sender, EventArgs e)
        {
            lv_checked.Items.Clear();
            verifiedProx = 0;
            updateLabels();
        }

        private void tsi_uc_removeSelected_Click(object sender, EventArgs e)
        {
            if (lv_unchecked.SelectedItems.Count > 0)
                foreach (ListViewItem item in lv_unchecked.SelectedItems) {
                    uncheckedProx--;
                    item.Remove();
                    updateLabels();
                }
        }

        private void tsi_uc_removeAll_Click(object sender, EventArgs e)
        {
            lv_unchecked.Items.Clear();
            uncheckedProx = 0;
            updateLabels();
        }

        private void updateLabels()
        {
            lbl_checked.Text = verifiedProx.ToString();
            lbl_unchecked.Text = uncheckedProx.ToString();
        }

        private string PingLatency(string host)
        {
            Ping pL = new Ping();
            PingReply pReply = pL.Send(IPAddress.Parse(host));
            return pReply.Status == IPStatus.Success ? pReply.RoundtripTime.ToString() + " ms" : "ERR";
        }

        private bool WebReq(string proxy, int port)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://google.com/");

                WebProxy proxObj = new WebProxy(proxy, port);
                proxObj.BypassProxyOnLocal = true;
                GlobalProxySelection.Select = proxObj;

                req.Proxy = null;
                req.Timeout = 3000;
                req.KeepAlive = true;
                req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                req.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/40.0.2214.115 Safari/537.36";
                req.ContentType = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                req.Method = "GET";

                using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
                {
                    using (Stream stream = resp.GetResponseStream())
                    {
                        using (StreamReader sr = new StreamReader(stream))
                        {
                            if (sr.ReadToEnd().Length > 0)
                                return true;
                            else return false;
                        }
                    }
                }
            }
            catch { return false; }
        }

        private bool Sockets(string HOST, string HTTP_COMMAND, string USER_AGENT, string ACCEPT, string ACCEPT_ENCODING, string ACCEPT_CHARSET, string ACCEPT_LANGUAGE, string REFERER, string CONTENT, string CONTENT_TYPE, string COOKIES, string PROXY, int PROXY_PORT, bool DNT = false, params object[] EXTRA_HEADERS)
        {
            try
            {
                var client = proxSocks.SockHTTPProxy(HOST, 80, PROXY, PROXY_PORT);
                NetworkStream stream = client.GetStream();
                client.SendTimeout = 1000;
                List<string> HEADER = new List<string>();
                HEADER.Add(HTTP_COMMAND);

                HEADER.Add("Host: " + HOST);

                if (USER_AGENT.Length > 0)
                    HEADER.Add("User-Agent: " + USER_AGENT);

                if (ACCEPT.Length > 0)
                    HEADER.Add("Accept: " + ACCEPT);

                if (ACCEPT_LANGUAGE.Length > 0)
                    HEADER.Add("Accept-Language: " + ACCEPT_LANGUAGE);

                if (ACCEPT_ENCODING.Length > 0)
                    HEADER.Add("Accept-Encoding: " + ACCEPT_ENCODING);

                if (DNT)
                    HEADER.Add("DNT: 1");

                if (ACCEPT_CHARSET.Length > 0)
                    HEADER.Add("Accept-Charset: " + ACCEPT_CHARSET);

                if (REFERER.Length > 0)
                    HEADER.Add("Referer: " + REFERER);

                if (COOKIES.Length > 0)
                    HEADER.Add("Cookies: " + COOKIES);


                HEADER.Add("Connection: Keep-Alive");

                if (HTTP_COMMAND.Contains("POST") == true)
                {
                    CONTENT = "\r\n" + CONTENT;
                    HEADER.Add("Content-Type: " + CONTENT_TYPE);
                    HEADER.Add("Content-Length: " + CONTENT.Length);
                    HEADER.Add(CONTENT);
                }

                foreach (string header in EXTRA_HEADERS)
                    HEADER.Add(header);

                string dataToSend = "";
                for (int h = 0; h < HEADER.Count; h++)
                    dataToSend = dataToSend + HEADER[h] + "\r\n";
                dataToSend = dataToSend + "\r\n";

                byte[] send = Encoding.ASCII.GetBytes(dataToSend);
                stream.Write(send, 0, send.Length);
                stream.Flush();
                byte[] bytes = new byte[client.ReceiveBufferSize];
                int count = stream.Read(bytes, 0, (int)client.ReceiveBufferSize);
                String data = Encoding.ASCII.GetString(bytes);
                char[] unused = { (char)data[count] };
                stream.Close();
                client.Close();
                return true;
            }
            catch (WebException wex) { Console.WriteLine("Error[{0}]: {1}", wex.HResult, wex.Status); return false; }
            catch { return false; }
        }
    }
}
