namespace Infiniti_COM
{
    partial class AddPMS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rECVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEEDBACKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wAITFORPLCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEMARKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMSPLCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.communicationDataset = new Infiniti_COM.CommunicationDataset();
            this.pMS_PLCTableAdapter = new Infiniti_COM.CommunicationDatasetTableAdapters.PMS_PLCTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSPLCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rECVDataGridViewTextBoxColumn,
            this.sENDDataGridViewTextBoxColumn,
            this.fEEDBACKDataGridViewTextBoxColumn,
            this.wAITFORPLCDataGridViewTextBoxColumn,
            this.rEMARKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pMSPLCBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1294, 187);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridView1_DataBindingComplete);
            // 
            // rECVDataGridViewTextBoxColumn
            // 
            this.rECVDataGridViewTextBoxColumn.DataPropertyName = "RECV";
            this.rECVDataGridViewTextBoxColumn.HeaderText = "DATA FROM PMS";
            this.rECVDataGridViewTextBoxColumn.Name = "rECVDataGridViewTextBoxColumn";
            this.rECVDataGridViewTextBoxColumn.Width = 250;
            // 
            // sENDDataGridViewTextBoxColumn
            // 
            this.sENDDataGridViewTextBoxColumn.DataPropertyName = "SEND";
            this.sENDDataGridViewTextBoxColumn.HeaderText = "DATA TO PLC";
            this.sENDDataGridViewTextBoxColumn.Name = "sENDDataGridViewTextBoxColumn";
            this.sENDDataGridViewTextBoxColumn.Width = 250;
            // 
            // fEEDBACKDataGridViewTextBoxColumn
            // 
            this.fEEDBACKDataGridViewTextBoxColumn.DataPropertyName = "FEEDBACK";
            this.fEEDBACKDataGridViewTextBoxColumn.HeaderText = "FEEDBACK TO PMS";
            this.fEEDBACKDataGridViewTextBoxColumn.Name = "fEEDBACKDataGridViewTextBoxColumn";
            this.fEEDBACKDataGridViewTextBoxColumn.Width = 250;
            // 
            // wAITFORPLCDataGridViewTextBoxColumn
            // 
            this.wAITFORPLCDataGridViewTextBoxColumn.DataPropertyName = "WAITFORPLC";
            this.wAITFORPLCDataGridViewTextBoxColumn.HeaderText = "WAIT FOR PLC";
            this.wAITFORPLCDataGridViewTextBoxColumn.Name = "wAITFORPLCDataGridViewTextBoxColumn";
            this.wAITFORPLCDataGridViewTextBoxColumn.Width = 250;
            // 
            // rEMARKDataGridViewTextBoxColumn
            // 
            this.rEMARKDataGridViewTextBoxColumn.DataPropertyName = "REMARK";
            this.rEMARKDataGridViewTextBoxColumn.HeaderText = "REMARK";
            this.rEMARKDataGridViewTextBoxColumn.Name = "rEMARKDataGridViewTextBoxColumn";
            this.rEMARKDataGridViewTextBoxColumn.Width = 250;
            // 
            // pMSPLCBindingSource
            // 
            this.pMSPLCBindingSource.DataMember = "PMS-PLC";
            this.pMSPLCBindingSource.DataSource = this.communicationDataset;
            // 
            // communicationDataset
            // 
            this.communicationDataset.DataSetName = "CommunicationDataset";
            this.communicationDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pMS_PLCTableAdapter
            // 
            this.pMS_PLCTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RECEIVED DATA";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pMSPLCBindingSource, "RECV", true));
            this.textBox1.Location = new System.Drawing.Point(130, 10);
            this.textBox1.MaxLength = 35;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Click += new System.EventHandler(this.TextBox1_Click);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hex_Press);
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pMSPLCBindingSource, "REMARK", true));
            this.richTextBox1.Location = new System.Drawing.Point(590, 9);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(499, 99);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pMSPLCBindingSource, "SEND", true));
            this.textBox2.Location = new System.Drawing.Point(130, 36);
            this.textBox2.MaxLength = 35;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(385, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hex_Press);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SEND DATA";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pMSPLCBindingSource, "WAITFORPLC", true));
            this.textBox3.Location = new System.Drawing.Point(130, 88);
            this.textBox3.MaxLength = 35;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(385, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hex_Press);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "WAIT FOR PLC DATA";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pMSPLCBindingSource, "FEEDBACK", true));
            this.textBox4.Location = new System.Drawing.Point(130, 62);
            this.textBox4.MaxLength = 35;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(385, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hex_Press);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "FEEDBACK DATA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "REMARK";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1095, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(214, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(1095, 39);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(214, 23);
            this.btnModify.TabIndex = 12;
            this.btnModify.Text = "MODIFY";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1095, 68);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(214, 23);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1095, 97);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1205, 97);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // AddPMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 328);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddPMS";
            this.Text = "AddPMS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddPMS_FormClosed);
            this.Load += new System.EventHandler(this.AddPMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSPLCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CommunicationDataset communicationDataset;
        private System.Windows.Forms.BindingSource pMSPLCBindingSource;
        private CommunicationDatasetTableAdapters.PMS_PLCTableAdapter pMS_PLCTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEEDBACKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wAITFORPLCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEMARKDataGridViewTextBoxColumn;
    }
}