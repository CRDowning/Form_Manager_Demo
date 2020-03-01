namespace FormManagerDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.openForm2Btn = new System.Windows.Forms.Button();
            this.openForm3btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.form1BGCbox = new System.Windows.Forms.ComboBox();
            this.form2BGCbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.form3BGCbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form1";
            // 
            // openForm2Btn
            // 
            this.openForm2Btn.Location = new System.Drawing.Point(12, 291);
            this.openForm2Btn.Name = "openForm2Btn";
            this.openForm2Btn.Size = new System.Drawing.Size(75, 34);
            this.openForm2Btn.TabIndex = 1;
            this.openForm2Btn.Text = "Open Form2";
            this.openForm2Btn.UseVisualStyleBackColor = true;
            this.openForm2Btn.Click += new System.EventHandler(this.openForm2Btn_Click);
            // 
            // openForm3btn
            // 
            this.openForm3btn.Location = new System.Drawing.Point(93, 291);
            this.openForm3btn.Name = "openForm3btn";
            this.openForm3btn.Size = new System.Drawing.Size(75, 34);
            this.openForm3btn.TabIndex = 2;
            this.openForm3btn.Text = "Open Form3";
            this.openForm3btn.UseVisualStyleBackColor = true;
            this.openForm3btn.Click += new System.EventHandler(this.openForm3btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Form1 Background Color";
            // 
            // form1BGCbox
            // 
            this.form1BGCbox.FormattingEnabled = true;
            this.form1BGCbox.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple"});
            this.form1BGCbox.Location = new System.Drawing.Point(12, 115);
            this.form1BGCbox.Name = "form1BGCbox";
            this.form1BGCbox.Size = new System.Drawing.Size(94, 21);
            this.form1BGCbox.TabIndex = 4;
            this.form1BGCbox.SelectedIndexChanged += new System.EventHandler(this.form1BGCbox_SelectedIndexChanged);
            // 
            // form2BGCbox
            // 
            this.form2BGCbox.FormattingEnabled = true;
            this.form2BGCbox.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple"});
            this.form2BGCbox.Location = new System.Drawing.Point(12, 179);
            this.form2BGCbox.Name = "form2BGCbox";
            this.form2BGCbox.Size = new System.Drawing.Size(94, 21);
            this.form2BGCbox.TabIndex = 6;
            this.form2BGCbox.SelectedIndexChanged += new System.EventHandler(this.form2BGCbox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Form2 Background Color";
            // 
            // form3BGCbox
            // 
            this.form3BGCbox.FormattingEnabled = true;
            this.form3BGCbox.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple"});
            this.form3BGCbox.Location = new System.Drawing.Point(12, 243);
            this.form3BGCbox.Name = "form3BGCbox";
            this.form3BGCbox.Size = new System.Drawing.Size(94, 21);
            this.form3BGCbox.TabIndex = 8;
            this.form3BGCbox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Form3 Background Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 347);
            this.Controls.Add(this.form3BGCbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.form2BGCbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.form1BGCbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openForm3btn);
            this.Controls.Add(this.openForm2Btn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openForm2Btn;
        private System.Windows.Forms.Button openForm3btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox form1BGCbox;
        private System.Windows.Forms.ComboBox form2BGCbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox form3BGCbox;
        private System.Windows.Forms.Label label4;
    }
}

