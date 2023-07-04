using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class SystemCenter : Form
    {
        public SystemCenter()
        {
            InitializeComponent();
        }
        public int getcid { get; set; }

        private void btn客服_Click(object sender, EventArgs e)
        {
            if (getcid > 0)
            {
                message = $"\n客戶:{getcid}\n回報內容\n" + textBox1.Text;
                testmessage();
                MessageBox.Show("回報成功");
                textBox1.Text = "";
            }
            else
            {
                message = $"\n訪客\n回報內容:\n" + textBox1.Text;
                testmessage();
                MessageBox.Show("回報成功");
                textBox1.Text = "";
            }
        }
        string message = "";
        void testmessage()
        {
            string token = "KXbKBf92ALXq5uW6SxIg3RdmWPnWfrspLmMbjD9808J";
            //string message = "您以現金結帳 金額為 " + DateTime.Now.ToString("yyyyMMddHHmmss");

            string url = "https://notify-api.line.me/api/notify";
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.DefaultConnectionLimit = 9999;
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12; // Use TLS 1.2, TLS 1.1, and TLS 1.0

                var request = (HttpWebRequest)WebRequest.Create(url);
                var postData = string.Format("message={0}", message);
                var data = Encoding.UTF8.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                request.Headers.Add("Authorization", "Bearer " + token);

                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; // Use TLS 1.2
                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true; // Bypass certificate validation

                using (var stream = request.GetRequestStream()) stream.Write(data, 0, data.Length);
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
