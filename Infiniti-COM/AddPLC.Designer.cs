namespace Infiniti_COM
{
    partial class AddPLC
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pLCPMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.communicationDataset = new Infiniti_COM.CommunicationDataset();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rECVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEEDBACKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEMARKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLC_PMSTableAdapter = new Infiniti_COM.CommunicationDatasetTableAdapters.PLC_PMSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pLCPMSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(953, 91);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(843, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(843, 62);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(214, 23);
            this.btnRemove.TabIndex = 29;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(843, 33);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(214, 23);
            this.btnModify.TabIndex = 28;
            this.btnModify.Text = "MODIFY";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(843, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(214, 23);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "REMARK";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pLCPMSBindingSource, "FEEDBACK", true));
            this.textBox4.Location = new System.Drawing.Point(127, 88);
            this.textBox4.MaxLength = 35;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(316, 20);
            this.textBox4.TabIndex = 23;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hex_Press);
            // 
            // pLCPMSBindingSource
            // 
            this.pLCPMSBindingSource.DataMember = "PLC-PMS";
            this.pLCPMSBindingSource.DataSource = this.communicationDataset;
            // 
            // communicationDataset
            // 
            this.communicationDataset.DataSetName = "CommunicationDataset";
            this.communicationDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "FEEDBACK DATA";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pLCPMSBindingSource, "SEND", true));
            this.textBox2.Location = new System.Drawing.Point(127, 50);
            this.textBox2.MaxLength = 35;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(316, 20);
            this.textBox2.TabIndex = 21;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hex_Press);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "SEND DATA";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pLCPMSBindingSource, "RECV", true));
            this.textBox1.Location = new System.Drawing.Point(127, 10);
            this.textBox1.MaxLength = 35;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Click += new System.EventHandler(this.TextBox1_Click);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hex_Press);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "RECEIVED DATA";
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pLCPMSBindingSource, "REMARK", true));
            this.richTextBox1.Location = new System.Drawing.Point(505, 9);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(332, 99);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
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
            this.rEMARKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pLCPMSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1045, 187);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // rECVDataGridViewTextBoxColumn
            // 
            this.rECVDataGridViewTextBoxColumn.DataPropertyName = "RECV";
            this.rECVDataGridViewTextBoxColumn.HeaderText = "DATA FROM PLC";
            this.rECVDataGridViewTextBoxColumn.Name = "rECVDataGridViewTextBoxColumn";
            this.rECVDataGridViewTextBoxColumn.Width = 250;
            // 
            // sENDDataGridViewTextBoxColumn
            // 
            this.sENDDataGridViewTextBoxColumn.DataPropertyName = "SEND";
            this.sENDDataGridViewTextBoxColumn.HeaderText = "DATA TO PMS";
            this.sENDDataGridViewTextBoxColumn.Name = "sENDDataGridViewTextBoxColumn";
            this.sENDDataGridViewTextBoxColumn.Width = 250;
            // 
            // fEEDBACKDataGridViewTextBoxColumn
            // 
            this.fEEDBACKDataGridViewTextBoxColumn.DataPropertyName = "FEEDBACK";
            this.fEEDBACKDataGridViewTextBoxColumn.HeaderText = "FEEDBACK TO PLC";
            this.fEEDBACKDataGridViewTextBoxColumn.Name = "fEEDBACKDataGridViewTextBoxColumn";
            this.fEEDBACKDataGridViewTextBoxColumn.Width = 250;
            // 
            // rEMARKDataGridViewTextBoxColumn
            // 
            this.rEMARKDataGridViewTextBoxColumn.DataPropertyName = "REMARK";
            this.rEMARKDataGridViewTextBoxColumn.HeaderText = "REMARK";
            this.rEMARKDataGridViewTextBoxColumn.Name = "rEMARKDataGridViewTextBoxColumn";
            this.rEMARKDataGridViewTextBoxColumn.Width = 250;
            // 
            // pLC_PMSTableAdapter
            // 
            this.pLC_PMSTableAdapter.ClearBeforeFill = true;
            // 
            // AddPLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 324);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddPLC";
            this.Text = "AddPLC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddPLC_FormClosed);
            this.Load += new System.EventHandler(this.AddPLC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pLCPMSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CommunicationDataset communicationDataset;
        private System.Windows.Forms.BindingSource pLCPMSBindingSource;
        private CommunicationDatasetTableAdapters.PLC_PMSTableAdapter pLC_PMSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEEDBACKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEMARKDataGridViewTextBoxColumn;
    }
}