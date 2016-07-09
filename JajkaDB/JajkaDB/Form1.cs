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
            dateTimePicker1.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Id = int.Parse("1");
            zniesioneTableAdapter.DeleteQueryById(Id);
            this.zniesioneTableAdapter.Fill(this.databaseDataSet.Zniesione);
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
                var newRow = databaseDataSet.Zniesione.NewZniesioneRow();
                newRow.Jajka = ilosc;
                newRow.Notka = notka;
                newRow.Data = data;
                databaseDataSet.Zniesione.AddZniesioneRow(newRow);
                                zniesioneTableAdapter.InsertQueryZniesione(ilosc, notka, data.ToShortDateString());

                databaseDataSet.Zniesione.AcceptChanges();
                //zniesioneBindingSource.EndEdit();
                zniesioneTableAdapter.Adapter.Update(databaseDataSet.Zniesione);
            

            }
            catch (Exception exc)
            {
                MessageBox.Show("Coś poszło nie tak:" + exc.Message);
            }
            this.zniesioneTableAdapter.Fill(this.databaseDataSet.Zniesione);
            int i = 1;
        }
    }
}
