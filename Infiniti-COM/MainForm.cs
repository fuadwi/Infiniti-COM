using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
//Program Designed for Hitachi 
namespace Infiniti_COM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Boolean started = false;
        private static byte[] GetByteArrayFromHexString(string input)
        {
            return input
                .Split(new[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(i => i.Trim().Replace("0x", ""))
                .Select(i => Convert.ToByte(i, 16))
                .ToArray();
        }
        void Stop()
        {
            button1.Text = "START";
            label1.BackColor = SystemColors.Control;
            toolStripStatusLabel1.Text = "System not Running!";
            started = !true;
            plcByte = 0;
            pmsByte = 0;
            toolStripStatusLabel4.Text = "PLC Receive : " + SizeSuffix(plcByte);
            toolStripStatusLabel5.Text = "PMS Receive : " + SizeSuffix(pmsByte);
            toolStripStatusLabel2.Text = "PLC PORT : " + Properties.Settings.Default.PLC_PORT;
            toolStripStatusLabel3.Text = "PMS PORT : " + Properties.Settings.Default.PMS_PORT;
            toolStripStatusLabel1.BackColor = Color.Red;
            serialPortPMS.Close();
            serialPortPLC.Close();
            toolStripStatusLabel11.Text = "-";
        }
        void Start()
        {
            button1.Text = "STOP";
            label1.BackColor = Color.Green;
            toolStripStatusLabel1.Text = "System is Running!";
            started = !false;
            this.plC_PMSTableAdapter1.Fill(this.communicationDataset1._PLC_PMS);
            this.pmS_PLCTableAdapter1.Fill(this.communicationDataset1._PMS_PLC);
            toolStripStatusLabel1.BackColor = SystemColors.Control;
            serialPortPLC.PortName = Properties.Settings.Default.PLC_PORT;
            serialPortPMS.PortName = Properties.Settings.Default.PMS_PORT;
            serialPortPLC.BaudRate = Convert.ToInt32(Properties.Settings.Default.PLC_SPEED);
            serialPortPMS.BaudRate = Convert.ToInt32(Properties.Settings.Default.PMS_SPEED);
            serialPortPLC.DataReceived += PLC_RECV;
            serialPortPMS.DataReceived += PMS_RECV;
            toolStripStatusLabel2.Text = "PLC PORT : " + Properties.Settings.Default.PLC_PORT;
            toolStripStatusLabel3.Text = "PMS PORT : " + Properties.Settings.Default.PMS_PORT;
            serialPortPLC.Open();
            serialPortPMS.Open();
            toolStripStatusLabel11.Text = "Waiting Data";
        }
        String ReceivedPMS;
        String ReceivedPLC;
        byte[] recvPMS;
        byte[] recvPLC;
        Int16 pmsCount = 0,plcCount = 0;
        Int64 pmsByte = 0, plcByte = 0;
        Boolean waitforplcFlag = false;
        private void PLC_RECV(object sender, SerialDataReceivedEventArgs e)
        {
            //SerialPort spL = (SerialPort)sender;
            //const int bufSize = 12;
            //Byte[] buf = new Byte[serialPortPLC.BytesToRead];
            Byte[] buf = new Byte[12];
            plcByte += buf.Length;
            serialPortPLC.Read(buf, 0, buf.Length);
            recvPLC = buf;
            //Console.WriteLine("PLC RECEIVING DATA!");
            ReceivedPLC = ByteArrayToString(buf);
            Console.WriteLine(ReceivedPLC);
            this.Invoke(new EventHandler(updatePLC));
        }
        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", " ").ToUpper();
        }
        private void updatePLC(object sender, EventArgs e)
        {
            if (!waitforplcFlag)
            {

                toolStripStatusLabel11.Text = "Received Data From PLC";
                richTextBox1.Text += ReceivedPLC;
                toolStripStatusLabel4.Text = "PLC Receive : " + SizeSuffix(plcByte);
                //var query = plC_PMSTableAdapter1.GetDataBy(ReceivedPLC);
                //Console.WriteLine(query.SENDColumn.ToString());
                var query = plC_PMSTableAdapter1.GetDataBy(ReceivedPLC);
                Console.WriteLine(query.Count);
                if (query.Count > 0)
                {
                    byte[] resp = GetByteArrayFromHexString(query[0].SEND);
                    if (!query[0].IsREMARKNull())
                    {
                        richTextBox4.Text = query[0].REMARK;
                    }
                    if (!query[0].IsFEEDBACKNull())
                    {
                        byte[] feedback = GetByteArrayFromHexString(query[0].FEEDBACK);
                        serialPortPLC.Write(feedback, 0, feedback.Length);
                    }
                    serialPortPMS.Write(resp, 0, resp.Length);

                }
                else
                {
                    Console.WriteLine("No Data FOUND!");
                }
                //Console.WriteLine(query.Count);
                richTextBox1.Text += "\n";
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
                plcCount++;
                if (plcCount > 100)
                {
                    richTextBox1.Text = null;
                    plcCount = 0;
                }
                //Console.WriteLine(recvPLC.Length.ToString());
            }
            if (waitforplcFlag) waitforplcFlag = false;
        }
        static private bool ByteArrayCompare(byte[] b1, byte[] b2)
        {
            int i;
            if (b2.Length == b1.Length)
            {
                i = 0;
                while (i < b2.Length && (b2[i] == b1[i])) //Earlier it was a1[i]!=b1[i]
                {
                    i++;
                }
                if (i == b2.Length)
                {
                    return true;
                }
            }

            return false;
        }

        Stopwatch stopwatch = new Stopwatch();
        byte[] dataWaitForPLC, feedbackPMS;
        
        private void waitForPLC()
        {
            toolStripStatusLabel11.Text = "Waiting data for PLC - 0";
            while (stopwatch.ElapsedMilliseconds < 5000)
            {
                try
                {
                    //Console.WriteLine(stopwatch.ElapsedMilliseconds); 
                    toolStripStatusLabel11.Text = "Waiting data for PLC - " + (stopwatch.ElapsedMilliseconds).ToString();
                    //Thread.Sleep(1);
                    //Console.WriteLine("Data 1 : " + ByteArrayToString(dataWaitForPLC));
                    //Console.WriteLine("Data 2 : " + ByteArrayToString(recvPLC));
                    //if (ByteArrayCompare(dataWaitForPLC, recvPLC)) serialPortPMS.Write(feedbackPMS, 0, feedbackPMS.Length); break;
                    //if (counterTime > 5000) Console.WriteLine("Break By Time =" + counterTime.ToString()); break;
                    //Console.WriteLine(dataWaitForPLC.SequenceEqual(recvPLC));
                    if (dataWaitForPLC.SequenceEqual(recvPLC))
                    {
                        serialPortPMS.Write(feedbackPMS, 0, feedbackPMS.Length);
                        Console.WriteLine("Break By Data Match");
                        break;
                    }

                    //else if (stopwatch.ElapsedMilliseconds > 500000) stopwatch.Stop(); break;
                }
                catch(Exception EX)
                {
                    Console.WriteLine(EX.Message);
                }
            }

            toolStripStatusLabel11.Text = "DONE WAITING";
            stopwatch.Stop();
            waitforplcFlag = false;
        }
        private void updatePMS(object sender, EventArgs e)
        {
            //Console.WriteLine
            var query = pmS_PLCTableAdapter1.GetDataByy(ReceivedPMS);
            Console.WriteLine(query.Count);
            toolStripStatusLabel11.Text = "Received Data From PMS";
            if (query.Count > 0)
            {
                byte[] resp = GetByteArrayFromHexString(query[0].SEND);
                serialPortPLC.Write(resp, 0, resp.Length);
                if (!query[0].IsREMARKNull())
                {
                    richTextBox4.Text = query[0].REMARK;
                }
                if(!query[0].IsWAITFORPLCNull())
                {
                   dataWaitForPLC = GetByteArrayFromHexString(query[0].WAITFORPLC);
                    //waiting data from plc
                    waitforplcFlag = true;
                    
                    ThreadStart waitingPLC = new ThreadStart(waitForPLC);
                    Thread waitPLC = new Thread(waitingPLC);
                    Console.WriteLine("Waiting for PLC");                    
                    stopwatch.Start();
                    waitPLC.Start();

                }
                if (!query[0].IsFEEDBACKNull())
                {
                    feedbackPMS = GetByteArrayFromHexString(query[0].FEEDBACK);
                   
                }
            }
            else
            {
                Console.WriteLine("No Data FOUND!");
            }
            toolStripStatusLabel5.Text = "PMS Receive : " + SizeSuffix(pmsByte);
            richTextBox2.Text += ReceivedPMS;
            richTextBox2.Text += "\n";
            richTextBox2.SelectionStart = richTextBox1.Text.Length;
            richTextBox2.ScrollToCaret();
            pmsCount++;
            if (pmsCount > 100)
            {
                richTextBox2.Text = null;
                pmsCount = 0;
            }
        }
        private void PMS_RECV(object sender, SerialDataReceivedEventArgs e)
        {
            //Byte[] buf = new Byte[serialPortPMS.BytesToRead];

            Byte[] buf = new Byte[12];
            pmsByte += buf.Length;
            serialPortPMS.Read(buf, 0, buf.Length);
            recvPMS= buf;
            //Console.WriteLine("PLC RECEIVING DATA!");
            ReceivedPMS = ByteArrayToString(buf);
            Console.WriteLine(ReceivedPMS);
            this.Invoke(new EventHandler(updatePMS));
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Stop();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void PORTCONFIGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config cfg = new Config();
            Stop();
            cfg.doneCfg += RefreshConfig;
            cfg.Show();

        }
        private void RefreshConfig(object s, EventArgs e)
        {
            //MessageBox.Show("Done");
            this.Show();
        }

        private void PMSDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPMS pms = new AddPMS();
            Stop();
            pms.done += RefreshConfig;
            pms.Show();
            this.Hide();
            
        }

        private void PLCDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPLC pLC = new AddPLC();
            Stop();
            pLC.done += RefreshConfig;
            pLC.Show();
            this.Hide();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            if (!started)
            {
                Start();
            }
            else
            {
                while (serialPortPLC.BytesToRead > 0 || serialPortPMS.BytesToRead > 0)
                {
                    Thread.Sleep(1);
                    toolStripStatusLabel1.Text = "WAITING TO RECEIVE COMPLETED!";
                }
                Stop();
            }
        }
        static readonly string[] SizeSuffixes =
                   { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        static string SizeSuffix(Int64 value, int decimalPlaces = 1)
        {
            if (decimalPlaces < 0) { throw new ArgumentOutOfRangeException("decimalPlaces"); }
            if (value < 0) { return "-" + SizeSuffix(-value); }
            if (value == 0) { return string.Format("{0:n" + decimalPlaces + "} bytes", 0); }

            // mag is 0 for bytes, 1 for KB, 2, for MB, etc.
            int mag = (int)Math.Log(value, 1024);

            // 1L << (mag * 10) == 2 ^ (10 * mag) 
            // [i.e. the number of bytes in the unit corresponding to mag]
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            // make adjustment when the value is large enough that
            // it would round up to 1000 or more
            if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
            {
                mag += 1;
                adjustedSize /= 1024;
            }

            return string.Format("{0:n" + decimalPlaces + "} {1}",
                adjustedSize,
                SizeSuffixes[mag]);
        }
    }
}
