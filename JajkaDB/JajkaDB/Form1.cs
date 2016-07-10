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
            // TODO: This line of code loads data into the 'databaseDataSet.Dokupione' table. You can move, or remove it, as needed.
            this.dokupioneTableAdapter.Fill(this.databaseDataSet.Dokupione);
            // TODO: This line of code loads data into the 'databaseDataSet.Zniesione' table. You can move, or remove it, as needed.
            this.zniesioneTableAdapter.Fill(this.databaseDataSet.Zniesione);
            dateTimePicker1.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                zniesioneTableAdapter.DeleteByIdQuery(id);
                zniesioneTableAdapter.Update(databaseDataSet.Zniesione);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Coś poszło nie tak:" + exc.Message);
                throw;
            }
            zniesioneTableAdapter.Fill(databaseDataSet.Zniesione);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                int ilosc = int.Parse(textBoxIlosc.Text);
                var notka = textBoxNotka.Text;
                var data = dateTimePicker1.Value;
                zniesioneTableAdapter.Insert(ilosc, notka, data);
                zniesioneTableAdapter.Update(databaseDataSet.Zniesione);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Coś poszło nie tak:" + exc.Message);
            }
            this.zniesioneTableAdapter.Fill(this.databaseDataSet.Zniesione);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
