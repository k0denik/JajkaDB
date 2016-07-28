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
            // TODO: This line of code loads data into the 'databaseDataSet.WydatkiTypy' table. You can move, or remove it, as needed.
            this.wydatkiTypyTableAdapter.Fill(this.databaseDataSet.WydatkiTypy);
            // TODO: This line of code loads data into the 'databaseDataSet.Wydatki' table. You can move, or remove it, as needed.
            this.wydatkiTableAdapter.Fill(this.databaseDataSet.Wydatki);
            // TODO: This line of code loads data into the 'databaseDataSetViews.StatView' table. You can move, or remove it, as needed.
            this.statViewTableAdapter.Fill(this.databaseDataSetViews.StatView);
            // TODO: This line of code loads data into the 'databaseDataSet11.KlienciZakupy' table. You can move, or remove it, as needed.
            dateTimePickerViewOd.Value = DateTime.Today - TimeSpan.FromDays(30);
            dateTimePickerViewDo.Value = DateTime.Today;
            // TODO: This line of code loads data into the 'databaseDataSet1.Transakcje' table. You can move, or remove it, as needed.
            this.transakcjeTableAdapter.Fill(this.databaseDataSet1.Transakcje);
            // TODO: This line of code loads data into the 'databaseDataSet.Klienci' table. You can move, or remove it, as needed.
            this.klienciTableAdapter.Fill(this.databaseDataSet.Klienci);
            // TODO: This line of code loads data into the 'databaseDataSet.Dokupione' table. You can move, or remove it, as needed.
            this.dokupioneTableAdapter.Fill(this.databaseDataSet.Dokupione);
            // TODO: This line of code loads data into the 'databaseDataSet.Zniesione' table. You can move, or remove it, as needed.
            this.zniesioneTableAdapter.Fill(this.databaseDataSet.Zniesione);
            dateTimePicker1.Value = DateTime.Today;
            refreshViews();
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
            try
            {
                int id = int.Parse(dataGridView2.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                dokupioneTableAdapter.DeleteByIdQuery(id);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Coś poszło nie tak:" + exc.Message);
            }
            dokupioneTableAdapter.Fill(databaseDataSet.Dokupione);
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string imie = textBoxImieKlienci.Text;
                string nazwisko = textBoxNazwiskoKlienci.Text;
                klienciTableAdapter.Insert(imie, nazwisko);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Coś poszło nie tak:" + exc.Message);
            }
            klienciTableAdapter.Fill(databaseDataSet.Klienci);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int ilosc = int.Parse(textBoxDokupioneIlosc.Text);
                int groszy = getGrosze(textBoxDokupionezloty.Text, textBoxDokupioneGroszy.Text);
                string notka = textBoxDokupioneNotka.Text;
                var data = dateTimePickerDokupione.Value;
                dokupioneTableAdapter.InsertQuery(ilosc, groszy, notka, data.ToShortDateString());
            }
            catch (Exception exc)
            {
                MessageBox.Show("Coś poszło nie tak:" + exc.Message);
            }
            dokupioneTableAdapter.Fill(databaseDataSet.Dokupione);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridViewKlienci.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                klienciTableAdapter.DeleteByIdQuery(id);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Coś poszło nie tak:" + exc.Message);
            }
            klienciTableAdapter.Fill(databaseDataSet.Klienci);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int ilosc = int.Parse(textBoxIloscTrans.Text);
                int groszy = getGrosze(textBoxZlotyTrans.Text, textBoxGroszyTrans.Text);
                string notka = textBoxNotkaTrans.Text;
                int klientId = int.Parse(comboBoxKlientTrans.SelectedValue.ToString());
                var data = dateTimePickerTrans.Value;
                transakcjeTableAdapter.InsertQuery(ilosc, groszy, klientId, notka, data.ToShortDateString());
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Coś poszło nie tak:" + exc.Message);
            }
            transakcjeTableAdapter.Fill(databaseDataSet1.Transakcje);
        }

        private int getGrosze(string zloty, string groszy)
        {
            int groszyResult = 0;
            int temp = 0;
            int.TryParse(zloty, out temp);
            groszyResult += temp * 100;
            temp = 0;
            int.TryParse(groszy, out temp);
            groszyResult += temp;
            return groszyResult;
        }

        private void buttonUsunTrans_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridViewTrans.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                transakcjeTableAdapter.DeleteByIdQuery(id);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Coś poszło nie tak:" + exc.Message);
            }
            transakcjeTableAdapter.Fill(databaseDataSet1.Transakcje);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshViews();
        }

        private void refreshViews()
        {
            var dataOd = dateTimePickerViewOd.Value;
            var dataDo = dateTimePickerViewDo.Value;
            klienciZakupyTableAdapter.FillByDate(this.databaseDataSet11.KlienciZakupy, dataOd.ToShortDateString(), dataDo.ToShortDateString());
            statViewTableAdapter.FillByDate(this.databaseDataSetViews.StatView, dataOd, dataDo);
            statViewJajkaTableAdapter.Fill(this.databaseDataSetViews.StatViewJajka, dataOd, dataDo);
        }

        private void dateTimePickerViewOd_ValueChanged(object sender, EventArgs e)
        {
            refreshViews();
        }

        private void dateTimePickerViewDo_ValueChanged(object sender, EventArgs e)
        {
            refreshViews();
        }

        private void buttonDodajWydatki_Click(object sender, EventArgs e)
        {
            try
            {
                int groszy = getGrosze(textBoxWydatkiZloty.Text,textBoxWydatkiGroszy.Text);
                string notka = textBoxWydatkiNotka.Text;
                var data = dateTimePickerWydatki.Value;
                int typId = Convert.ToInt32(comboBoxWydatkiTypy.SelectedValue);
                wydatkiTableAdapter.InsertQuery(groszy, data, notka, typId);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Coś poszło nie tak:" + exc.Message);
            }
            wydatkiTableAdapter.Fill(databaseDataSet.Wydatki);
        }

        private void buttonUsunWydatki_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridViewWydatki.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                wydatkiTableAdapter.DeleteByIdQuery(id);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Coś poszło nie tak:" + exc.Message);
            }
            wydatkiTableAdapter.Fill(databaseDataSet.Wydatki);
        }

        private void buttonDateStartMin_Click(object sender, EventArgs e)
        {
            dateTimePickerViewOd.Value = dateTimePickerViewOd.MinDate;
            refreshViews();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxNewTypeName.Text;
                wydatkiTypyTableAdapter.Insert(name);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Coś poszło nie tak:" + exc.Message);
            }
            wydatkiTypyTableAdapter.Fill(databaseDataSet.WydatkiTypy);
        }
    }
}
