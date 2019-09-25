using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DemoClient.View.LRN
{
    public partial class CHK100 : DemoClient.Controllers.BasePopupForm
    {
        private Thread _thread;
        private DataTable ReturnData { get; set; }
        public CHK100()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String key = textBox1.Text;
            String enc = "";
            enc = base.GetEncryptTripleDES(key);
            textBox2.Text = enc;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String key = textBox2.Text;
            String dec = "";
            dec = base.GetEncryptTripleDES(key);
            textBox3.Text = dec;

        }
    }
}
