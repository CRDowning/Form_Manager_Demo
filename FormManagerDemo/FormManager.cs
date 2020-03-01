using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // needed for Color

namespace FormManagerDemo
{
    public class FormManager
    {
        public static Form2 Form2_Session{ get; set; }
        public static Form3 Form3_Session{ get; set; }

        public FormManager(Form1 form1)
        {
            Form2_Session = new Form2(form1);
            Form3_Session = new Form3(form1);
        }
        //
        // Form2 Methods
        //
        public void showForm2()
        {
            Form2_Session.Show();
        }

        public void setForm2BG(String color)
        {
            Form2_Session.BackColor = Color.FromName(color);
        }
        //
        // Form3 Methods
        //
        public void showForm3()
        {
            Form3_Session.Show();
        }

        public void setForm3BG(String color)
        {
            Form3_Session.BackColor = Color.FromName(color);
        }
    }                                         
}
