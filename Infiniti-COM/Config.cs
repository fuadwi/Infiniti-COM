using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Infiniti_COM
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    comboBox1.Text = Properties.Settings.Default["PMS_PORT"].ToString();
                    comboBox2.Text = Properties.Settings.Default["PLC_PORT"].ToString();
                    textBox1.Text = Properties.Settings.Default["PMS_SPEED"].ToString();
                    textBox2.Text = Properties.Settings.Default["PLC_SPEED"].ToString();
                }
                catch { }
                String[] serialPort = SerialPort.GetPortNames();
                foreach(string serial in serialPort)
                {
                    comboBox1.Items.Add(serial);
                    comboBox2.Items.Add(serial);
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public event EventHandler doneCfg;
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default["PLC_PORT"] = comboBox2.Text;
                Properties.Settings.Default["PMS_PORT"] = comboBox1.Text;
                Properties.Settings.Default["PLC_SPEED"] = Convert.ToInt32(textBox2.Text);
                Properties.Settings.Default["PMS_SPEED"] = Convert.ToInt32(textBox1.Text);
                Properties.Settings.Default.Save();
                EventHandler handler = doneCfg;
                if (null != handler) handler(this, EventArgs.Empty);
                this.Close();
            }
            catch(Exception Ex){
                //EventHandler handler = doneCfg;
                //if (null != handler) handler(this, EventArgs.Empty);
            }
        }
    }
}
