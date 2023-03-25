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
    public partial class Form_menager : Form
    {
        public Form_menager()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_menager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_25032023_safinDataSet5.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter2.Fill(this._25032023_safinDataSet5.clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_25032023_safinDataSet4.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter1.Fill(this._25032023_safinDataSet4.clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_25032023_safinDataSet3.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this._25032023_safinDataSet3.clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_25032023_safinDataSet2.clients_transports". При необходимости она может быть перемещена или удалена.
            this.clients_transportsTableAdapter.Fill(this._25032023_safinDataSet2.clients_transports);

        }
    }
}
