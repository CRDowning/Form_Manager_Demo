using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormManagerDemo
{
    public partial class Form2 : Form
    {   
        Form1 Form1_Session { get; set; }
        public Form2(Form1 form1)
        {
            InitializeComponent();
            Form1_Session = form1;
        }
        // When the close button is clicked by user the event is canceled and the form is hidden
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void form1BGCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1_Session.BackColor = Color.FromName(form1BGCbox.SelectedItem.ToString());
        }

        private void form2BGCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(form2BGCbox.SelectedItem.ToString());
        }

        private void form3BGCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = form3BGCbox.SelectedItem.ToString();
            Form1_Session.FormManager_Session.setForm3BG(color);
        }
    }
}
