//  -- Form Manager Demo by Chris Downing -- 03/01/2020 --
//
//  When the application launches and the first form loads it instantiates a new FormManager class
//  Form manager creates new instances of forms 2 and 3 which can be accessed and persist until
//  Form1 is closed and the program ends.  
//  
//  The other forms are shown using a showForm method in the FormManager.
//  
//  A very important piece of code on all secondary forms (Line 22 on Form2 or Form3) watches for the 
//  FormClosing event handler, trigged by clicking the close button (X), canceling the event
//  and calling the Hide() method instead.  Closing the form destroys the object and causes major problems.
//  This prevents that, ensuring the forms persist.
//
//  This also shows a method of accessing and manipulating one from the others using the FormManager
//  class.  Because the form manager is instantiated in Form1, from Form1 the other forms may be manipulated
//  by using the syntax <FormManager>.<FormName>.<somePropertyOrVariable>.  In this case changing the background
//  colors. (lines 77 and 82 this file)
//
//  In order for the secondary forms to access the form manager they are passed a reference to Form1
//  When they are created.  Secondary forms can access Form1 this way <Form1>.<somePropertyOrVar>
//  (see line 33 on Form2 or Form3)
//
//  In order for secondary forms to reach each other via the form manager they must call methods, using
//  syntax <Form1>.<FormManager>.<someMethodInFormManager> (line 44 in Form2 or 39 in Form3, calling the 
//  setForm#BG method).  Then FormManager accesses the forms in a method <Form#>.<someProperty> (line 28 
//  40 in FormManager).
//  
//  The benefit of this method is creating forms that are instantiated at launch and persist the entire
//  time the application runs.  Allowing them to be manipulated while closed and allowing them to retain
//  anything done on them while open.
//
//  This method may get convoluted for passing data between forms.  So while it does work, other 
//  techniques may be preferable.
//
//  Thanks for looking!
// 

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
    public partial class Form1 : Form
    {
        // Instantiate Form  Manager, creating all forms for the session
        public FormManager FormManager_Session { get; set; }
        public Form1()
        {
            InitializeComponent();
            FormManager_Session = new FormManager(this);
        }

        private void openForm2Btn_Click(object sender, EventArgs e)
        {
            FormManager_Session.showForm2();
        }

        private void openForm3btn_Click(object sender, EventArgs e)
        {
            FormManager_Session.showForm3();
        }

        private void form1BGCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(form1BGCbox.SelectedItem.ToString());
        }

        private void form2BGCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormManager.Form2_Session.BackColor = Color.FromName(form2BGCbox.SelectedItem.ToString());
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormManager.Form3_Session.BackColor = Color.FromName(form3BGCbox.SelectedItem.ToString());
        }
    }
}
