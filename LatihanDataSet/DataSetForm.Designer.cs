namespace LatihanDataSet
{
    partial class DataSetForm
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
            this.dataTable1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAsal1 = new LatihanDataSet.DataSetAsal();
            this.table01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAsal = new LatihanDataSet.DataSetAsal();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SVE_Button = new System.Windows.Forms.Button();
            this.coreDBTestDataSet = new LatihanDataSet.CoreDBTestDataSet();
            this.tblCUSAPPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CUSAPPTableAdapter = new LatihanDataSet.CoreDBTestDataSetTableAdapters.Tbl_CUSAPPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAsal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAsal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreDBTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSAPPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataTable1BindingSource2
            // 
            this.dataTable1BindingSource2.DataMember = "DataTable1";
            this.dataTable1BindingSource2.DataSource = this.dataSetAsal1;
            // 
            // dataSetAsal1
            // 
            this.dataSetAsal1.DataSetName = "DataSetAsal";
            this.dataSetAsal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table01BindingSource
            // 
            this.table01BindingSource.DataMember = "Table01";
            this.table01BindingSource.DataSource = this.dataSetAsal;
            // 
            // dataSetAsal
            // 
            this.dataSetAsal.DataSetName = "DataSetAsal";
            this.dataSetAsal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSetAsal;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dataSetAsal;
            // 
            // SVE_Button
            // 
            this.SVE_Button.Location = new System.Drawing.Point(522, 12);
            this.SVE_Button.Name = "SVE_Button";
            this.SVE_Button.Size = new System.Drawing.Size(169, 68);
            this.SVE_Button.TabIndex = 1;
            this.SVE_Button.Text = "Save Button";
            this.SVE_Button.UseVisualStyleBackColor = true;
            this.SVE_Button.Click += new System.EventHandler(this.SVE_Button_Click);
            // 
            // coreDBTestDataSet
            // 
            this.coreDBTestDataSet.DataSetName = "CoreDBTestDataSet";
            this.coreDBTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCUSAPPBindingSource
            // 
            this.tblCUSAPPBindingSource.DataMember = "Tbl_CUSAPP";
            this.tblCUSAPPBindingSource.DataSource = this.coreDBTestDataSet;
            // 
            // tbl_CUSAPPTableAdapter
            // 
            this.tbl_CUSAPPTableAdapter.ClearBeforeFill = true;
            // 
            // DataSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SVE_Button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataSetForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DataSetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAsal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAsal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreDBTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSAPPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSetAsal dataSetAsal;
        private System.Windows.Forms.BindingSource table01BindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource2;
        private DataSetAsal dataSetAsal1;
        private System.Windows.Forms.Button SVE_Button;
        private CoreDBTestDataSet coreDBTestDataSet;
        private System.Windows.Forms.BindingSource tblCUSAPPBindingSource;
        private CoreDBTestDataSetTableAdapters.Tbl_CUSAPPTableAdapter tbl_CUSAPPTableAdapter;
    }
}

