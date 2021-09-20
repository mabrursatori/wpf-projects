namespace LatihanKeyboard02
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.BtnE = new System.Windows.Forms.Button();
            this.BtnCaps = new System.Windows.Forms.Button();
            this.BtnBackSpace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(25, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 40);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(25, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(364, 40);
            this.textBox2.TabIndex = 1;
            // 
            // BtnA
            // 
            this.BtnA.Location = new System.Drawing.Point(25, 118);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(93, 77);
            this.BtnA.TabIndex = 2;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnB
            // 
            this.BtnB.Location = new System.Drawing.Point(158, 118);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(93, 77);
            this.BtnB.TabIndex = 3;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = true;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnC
            // 
            this.BtnC.Location = new System.Drawing.Point(296, 118);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(93, 77);
            this.BtnC.TabIndex = 4;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnD
            // 
            this.BtnD.Location = new System.Drawing.Point(25, 218);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(93, 77);
            this.BtnD.TabIndex = 5;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // BtnE
            // 
            this.BtnE.Location = new System.Drawing.Point(158, 218);
            this.BtnE.Name = "BtnE";
            this.BtnE.Size = new System.Drawing.Size(93, 77);
            this.BtnE.TabIndex = 6;
            this.BtnE.Text = "E";
            this.BtnE.UseVisualStyleBackColor = true;
            this.BtnE.Click += new System.EventHandler(this.BtnE_Click);
            // 
            // BtnCaps
            // 
            this.BtnCaps.Location = new System.Drawing.Point(475, 118);
            this.BtnCaps.Name = "BtnCaps";
            this.BtnCaps.Size = new System.Drawing.Size(93, 77);
            this.BtnCaps.TabIndex = 7;
            this.BtnCaps.Text = "Caps";
            this.BtnCaps.UseVisualStyleBackColor = true;
            this.BtnCaps.Click += new System.EventHandler(this.BtnCaps_Click);
            // 
            // BtnBackSpace
            // 
            this.BtnBackSpace.Location = new System.Drawing.Point(475, 12);
            this.BtnBackSpace.Name = "BtnBackSpace";
            this.BtnBackSpace.Size = new System.Drawing.Size(93, 87);
            this.BtnBackSpace.TabIndex = 8;
            this.BtnBackSpace.Text = "BackSpace";
            this.BtnBackSpace.UseVisualStyleBackColor = true;
            this.BtnBackSpace.Click += new System.EventHandler(this.BtnBackSpace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 309);
            this.Controls.Add(this.BtnBackSpace);
            this.Controls.Add(this.BtnCaps);
            this.Controls.Add(this.BtnE);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Button BtnE;
        private System.Windows.Forms.Button BtnCaps;
        private System.Windows.Forms.Button BtnBackSpace;
    }
}

