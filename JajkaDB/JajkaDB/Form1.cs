using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JajkaDB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Zniesione' table. You can move, or remove it, as needed.
            this.zniesioneTableAdapter.Fill(this.databaseDataSet.Zniesione);
            // TODO: This line of code loads data into the 'databaseDataSet.Klienci' table. You can move, or remove it, as needed.
            this.klienciTableAdapter.Fill(this.databaseDataSet.Klienci);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
