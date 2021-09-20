namespace LatihanSearchDateText
{
    partial class NilaiValue
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
            this.U_ID = new System.Windows.Forms.TextBox();
            this.U_Name = new System.Windows.Forms.TextBox();
            this.U_Date = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // U_ID
            // 
            this.U_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_ID.Location = new System.Drawing.Point(190, 61);
            this.U_ID.Name = "U_ID";
            this.U_ID.Size = new System.Drawing.Size(288, 29);
            this.U_ID.TabIndex = 0;
            // 
            // U_Name
            // 
            this.U_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_Name.Location = new System.Drawing.Point(190, 127);
            this.U_Name.Name = "U_Name";
            this.U_Name.Size = new System.Drawing.Size(288, 29);
            this.U_Name.TabIndex = 1;
            // 
            // U_Date
            // 
            this.U_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_Date.Location = new System.Drawing.Point(190, 199);
            this.U_Date.Name = "U_Date";
            this.U_Date.Size = new System.Drawing.Size(288, 29);
            this.U_Date.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(190, 274);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // NilaiValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.U_Date);
            this.Controls.Add(this.U_Name);
            this.Controls.Add(this.U_ID);
            this.Name = "NilaiValue";
            this.Text = "NilaiValue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox U_ID;
        public System.Windows.Forms.TextBox U_Name;
        public System.Windows.Forms.TextBox U_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}