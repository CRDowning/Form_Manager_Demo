namespace FormManagerDemo
{
    partial class Form2
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
            this.form3BGCbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.form2BGCbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.form1BGCbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Form2";
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
            this.form3BGCbox.Location = new System.Drawing.Point(22, 237);
            this.form3BGCbox.Name = "form3BGCbox";
            this.form3BGCbox.Size = new System.Drawing.Size(94, 21);
            this.form3BGCbox.TabIndex = 14;
            this.form3BGCbox.SelectedIndexChanged += new System.EventHandler(this.form3BGCbox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Form3 Background Color";
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
            this.form2BGCbox.Location = new System.Drawing.Point(22, 173);
            this.form2BGCbox.Name = "form2BGCbox";
            this.form2BGCbox.Size = new System.Drawing.Size(94, 21);
            this.form2BGCbox.TabIndex = 12;
            this.form2BGCbox.SelectedIndexChanged += new System.EventHandler(this.form2BGCbox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Form2 Background Color";
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
            this.form1BGCbox.Location = new System.Drawing.Point(22, 109);
            this.form1BGCbox.Name = "form1BGCbox";
            this.form1BGCbox.Size = new System.Drawing.Size(94, 21);
            this.form1BGCbox.TabIndex = 10;
            this.form1BGCbox.SelectedIndexChanged += new System.EventHandler(this.form1BGCbox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Form1 Background Color";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 303);
            this.Controls.Add(this.form3BGCbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.form2BGCbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.form1BGCbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox form3BGCbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox form2BGCbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox form1BGCbox;
        private System.Windows.Forms.Label label2;
    }
}