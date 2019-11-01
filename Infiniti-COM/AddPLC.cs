using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Infiniti_COM
{
    public partial class AddPLC : Form
    {
        public AddPLC()
        {
            InitializeComponent();
        }

        private void AddPLC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'communicationDataset._PLC_PMS' table. You can move, or remove it, as needed.
            this.pLC_PMSTableAdapter.Fill(this.communicationDataset._PLC_PMS);

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                pLCPMSBindingSource.AddNew();
                MessageBox.Show("Berhasil Menambahkan Data!", "SUKSES!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pLCPMSBindingSource.ResetBindings(false);
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            try
            {
                pLCPMSBindingSource.EndEdit();
                MessageBox.Show("Berhasil Mengedit Data!", "SUKSES!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pLCPMSBindingSource.ResetBindings(false);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Yakin Menghapus data ini?", "Menghapus?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    pLCPMSBindingSource.RemoveCurrent();
                    MessageBox.Show("Berhasil Menghapus Data!", "SUKSES!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pLCPMSBindingSource.ResetBindings(false);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            EventHandler handler = done;
            if (null != handler) handler(this, EventArgs.Empty);
            this.Close();
        }
        public event EventHandler done;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine(this.Validate());
                this.pLCPMSBindingSource.EndEdit();
                Console.WriteLine(this.pLC_PMSTableAdapter.Update(this.communicationDataset._PLC_PMS));
                Console.WriteLine(pLC_PMSTableAdapter.Update(communicationDataset._PLC_PMS));
                pLC_PMSTableAdapter.Fill(this.communicationDataset._PLC_PMS);
                this.communicationDataset.AcceptChanges();
                communicationDataset.AcceptChanges();
                dataGridView1.ClearSelection();
                MessageBox.Show("Berhasil Menyimpan Data!", "SUKSES!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pLCPMSBindingSource.ResetBindings(false);
            }
        }
        private void Hex_Press(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f') || c=='\b' || c==' '))
            {
                if (c >= 'a' && c <= 'f')
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
                    e.Handled = true;
            }
            TextBox textBox = sender as TextBox;
            int tl = textBox.TextLength;
            if(tl == 2 || tl == 5 || tl == 8 || tl == 11 || tl == 14 || tl == 17 || tl == 20 || tl == 23 || tl == 26 || tl == 29 || tl == 32)
            {
                textBox.Text += " ";
            }
            //textBox.Text = Regex.Replace(textBox.Text, ".{2}", "$0 ");
            //textBox.Text = Regex.Replace(textBox.Text, @"\s+", " ");
            textBox.SelectionStart = textBox.Text.Length;
            textBox.SelectionLength = 0;


        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            pLCPMSBindingSource.AddNew();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddPLC_FormClosed(object sender, FormClosedEventArgs e)
        {
            EventHandler handler = done;
            if (null != handler) handler(this, EventArgs.Empty);
        }

    }
}
