using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Infiniti_COM
{
    public partial class AddPMS : Form
    {
        public AddPMS()
        {
            InitializeComponent();
        }
        private void DisableALL()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            richTextBox1.Enabled = false;
            btnModify.Enabled = false;
            btnRemove.Enabled = false;
        }
        private void EnableAll()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            richTextBox1.Enabled = true;
            btnModify.Enabled = true;
            btnRemove.Enabled = true;
        }
        private void AddPMS_Load(object sender, EventArgs e)
        {
            //btnCancel.Focus();
            //DisableALL();
            dataGridView1.TabStop = false;
            //communicationDataset.AcceptChanges();
            
            // TODO: This line of code loads data into the 'communicationDataset._PMS_PLC' table. You can move, or remove it, as needed.
            pMS_PLCTableAdapter.Fill(this.communicationDataset._PMS_PLC);
            pMSPLCBindingSource.DataSource = this.communicationDataset._PMS_PLC;
            //pMSPLCBindingSource.AddNew();
            //Console.WriteLine(pMSPLCBindingSource.AllowEdit);
            //Console.WriteLine(pMSPLCBindingSource.AllowNew);
            //Console.WriteLine(pMSPLCBindingSource.AllowRemove);
            //dataGridView1/*.SelectAll();*/
            //dataGridView1.ClearSelection();
            //// TODO: This line of code loads data into the 'communicationDataset._PMS_PLC' table. You can move, or remove it, as needed.
            //this.pMS_PLCTableAdapter.Fill(this.communicationDataset._PMS_PLC);
            //// TODO: This line of code loads data into the 'communicationDataset._PMS_PLC' table. You can move, or remove it, as needed.
            //this.pMS_PLCTableAdapter.Fill(this.communicationDataset._PMS_PLC);

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
               pMSPLCBindingSource.AddNew();
               MessageBox.Show("Berhasil Menambahkan Data!", "SUKSES!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pMSPLCBindingSource.ResetBindings(false);
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            try
            {
                pMSPLCBindingSource.EndEdit();
                MessageBox.Show("Berhasil Edit Data!", "SUKSES!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pMSPLCBindingSource.ResetBindings(false);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Yakin Menghapus data ini?", "Menghapus?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    pMSPLCBindingSource.RemoveCurrent();
                    MessageBox.Show("Berhasil Menghapus Data!", "SUKSES!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pMSPLCBindingSource.ResetBindings(false);
            }
        }
        public event EventHandler done;
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            EventHandler handler = done;
            if (null != handler) handler(this, EventArgs.Empty);
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine(this.Validate());
                this.pMSPLCBindingSource.EndEdit();
                Console.WriteLine(this.pMS_PLCTableAdapter.Update(this.communicationDataset._PMS_PLC));
                Console.WriteLine(pMS_PLCTableAdapter.Update(communicationDataset._PMS_PLC));
                pMS_PLCTableAdapter.Fill(this.communicationDataset._PMS_PLC);
                this.communicationDataset.AcceptChanges();
                communicationDataset.AcceptChanges();
                //pMSPLCBindingSource.AddNew();
                dataGridView1.ClearSelection();
                //Console.WriteLine(this.pMS_PLCTableAdapter.Update(this.communicationDataset._PMS_PLC));
                //CommunicationDatasetTableAdapters.TableAdapterManager um = new CommunicationDatasetTableAdapters.TableAdapterManager();
                //Console.WriteLine(um.UpdateAll(communicationDataset));
                //communicationDataset.AcceptChanges();

                //this.pMS_PLCTableAdapter.Update(this.communicationDataset._PMS_PLC);
                //this.communicationDataset.AcceptChanges();
                //this.Validate();
                //this.pMSPLCBindingSource.EndEdit();
                //pMS_PLCTableAdapter.Update(communicationDataset);
                //communicationDataset.AcceptChanges();
                MessageBox.Show("Berhasil Menyimpan Data!", "SUKSES!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //EventHandler handler = done;
                //if (null != handler) handler(this, EventArgs.Empty);
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pMSPLCBindingSource.ResetBindings(false);
            }
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            dataGridView1.ClearSelection();
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            pMSPLCBindingSource.AddNew();
        }
        private void Hex_Press(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f') || c == '\b' || c == ' '))
            {
                if (c >= 'a' && c <= 'f')
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
                e.Handled = true;
            }
            TextBox textBox = sender as TextBox;
            int tl = textBox.TextLength;
            if (tl == 2 || tl == 5 || tl == 8 || tl == 11 || tl == 14 || tl == 17 || tl == 20 || tl == 23 || tl == 26 || tl == 29 || tl == 32)
            {
                textBox.Text += " ";
            }
            //textBox.Text = Regex.Replace(textBox.Text, ".{2}", "$0 ");
            //textBox.Text = Regex.Replace(textBox.Text, @"\s+", " ");
            textBox.SelectionStart = textBox.Text.Length;
            textBox.SelectionLength = 0;

        }

        private void AddPMS_FormClosed(object sender, FormClosedEventArgs e)
        {
            EventHandler handler = done;
            if (null != handler) handler(this, EventArgs.Empty);
        }
    }    
}
