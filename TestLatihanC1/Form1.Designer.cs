namespace TestLatihanC1
{
    partial class Form1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dB_DEMODataSet = new TestLatihanC1.DB_DEMODataSet();
            this.dBDEMODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sALESSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sALES_SOTableAdapter = new TestLatihanC1.DB_DEMODataSetTableAdapters.SALES_SOTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cOMCUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dB_DEMODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDEMODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESSOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMCUSTOMERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(572, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(572, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dB_DEMODataSet
            // 
            this.dB_DEMODataSet.DataSetName = "DB_DEMODataSet";
            this.dB_DEMODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBDEMODataSetBindingSource
            // 
            this.dBDEMODataSetBindingSource.DataSource = this.dB_DEMODataSet;
            this.dBDEMODataSetBindingSource.Position = 0;
            // 
            // sALESSOBindingSource
            // 
            this.sALESSOBindingSource.DataMember = "SALES_SO";
            this.sALESSOBindingSource.DataSource = this.dBDEMODataSetBindingSource;
            // 
            // sALES_SOTableAdapter
            // 
            this.sALES_SOTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.dBDEMODataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // cOMCUSTOMERBindingSource
            // 
            this.cOMCUSTOMERBindingSource.DataSource = typeof(TestLatihanC1.COM_CUSTOMER);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_DEMODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDEMODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESSOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMCUSTOMERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dBDEMODataSetBindingSource;
        private DB_DEMODataSet dB_DEMODataSet;
        private System.Windows.Forms.BindingSource sALESSOBindingSource;
        private DB_DEMODataSetTableAdapters.SALES_SOTableAdapter sALES_SOTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cOMCUSTOMERBindingSource;
    }
}

