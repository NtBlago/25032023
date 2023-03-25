using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _25032023
{
    public partial class login_form : Form
    {
        public login_form()
        {
          
         
            InitializeComponent();


        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            Form_view fm = new Form_view();
                fm.Show(); 
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_form_Shown(object sender, EventArgs e)
        {
        }
    }
}
