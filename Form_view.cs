using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25032023
{
    public partial class Form_view : Form
    {
        public Form_view()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            Form_admin fm = new Form_admin();
            fm.Show();
        }

        private void menager_button_Click(object sender, EventArgs e)
        {
            Form_menager fm = new Form_menager();
            fm.Show();
        }

        private void rent_button_Click(object sender, EventArgs e)
        {
            Form_rent fm = new Form_rent();
            fm.Show();
        }

        private void Form_view_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_25032023_safinDataSet1.transport". При необходимости она может быть перемещена или удалена.
            this.transportTableAdapter1.Fill(this._25032023_safinDataSet1.transport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_25032023_safinDataSet.transport". При необходимости она может быть перемещена или удалена.
            this.transportTableAdapter.Fill(this._25032023_safinDataSet.transport);

        }
    }
}
