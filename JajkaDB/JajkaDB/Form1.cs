using System;
using System.Windows.Forms;
using JajkaDB.DatabaseDataSetViewsTableAdapters;

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
            // TODO: This line of code loads data into the 'databaseDataSetViews.KlienciZakupy' table. You can move, or remove it, as needed.
            this.klienciZakupyTableAdapter1.Fill(this.databaseDataSetViews.KlienciZakupy);
            // TODO: This line of code loads data into the 'databaseDataSetViews.KlienciPelne' table. You can move, or remove it, as needed.
            this.klienciPelneTableAdapter.Fill(this.databaseDataSetViews.KlienciPelne);
            kuryTableAdapter.Fill(databaseDataSet.Kury);
            wydatkiTypyTableAdapter.Fill(databaseDataSet.WydatkiTypy);
            wydatkiTableAdapter.Fill(databaseDataSet.Wydatki);
            dateTimePickerViewOd.Value = DateTime.Today - TimeSpan.FromDays(30);
            dateTimePickerViewDo.Value = DateTime.Today;
            transakcjeTableAdapter.Fill(databaseDataSet1.Transakcje);
            klienciTableAdapter.Fill(databaseDataSet.Klienci);
            dokupioneTableAdapter.Fill(databaseDataSet.Dokupione);
            zniesioneTableAdapter.Fill(databaseDataSet.Zniesione);
            dateTimePicker1.Value = DateTime.Today;
            RefreshViews();
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
                MessageBox.Show(@"Coś poszło nie tak:" + exc.Message);
                throw;
            }
            zniesioneTableAdapter.Fill(databaseDataSet.Zniesione);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
                MessageBox.Show(@"Coś poszło nie tak:" + exc.Message);
            }
            zniesioneTableAdapter.Fill(databaseDataSet.Zniesione);
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
                MessageBox.Show(@"Coś poszło nie tak:" + exc.Message);
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
                MessageBox.Show(@"Coś poszło nie tak:" + exc.Message);
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
                MessageBox.Show(@"Coś poszło nie tak:" + exc.Message);
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
                MessageBox.Show(@"Coś poszło nie tak:" + exc.Message);
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
                MessageBox.Show(@"Coś poszło nie tak:" + exc.Message);
            }
            transakcjeTableAdapter.Fill(databaseDataSet1.Transakcje);
        }

        private int getGrosze(string zloty, string groszy)
        {
            var groszyResult = 0;
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
                MessageBox.Show(@"Coś poszło nie tak:" + exc.Message);
            }
            transakcjeTableAdapter.Fill(databaseDataSet1.Transakcje);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshViews();
        }

        private void RefreshViews()
        {
            var dataOd = dateTimePickerViewOd.Value;
            var dataDo = dateTimePickerViewDo.Value;
            klienciZakupyTableAdapter1.FillByDate(databaseDataSetViews.KlienciZakupy, dataOd, dataDo);
            statViewTableAdapter.Fill(databaseDataSetViews.StatView, dataOd, dataDo);
            statViewJajkaTableAdapter.Fill(databaseDataSetViews.StatViewJajka, dataOd, dataDo);
            textBoxKuryStat.Text = kuryTableAdapter.KurySumaQuery().ToString();
            wydatkiTypyStatTableAdapter.Fill(databaseDataSetViews.WydatkiTypyStat,dataOd,dataDo);
            kuryStatViewTableAdapter.Fill(databaseDataSetViews.KuryStatView, dataOd, dataDo);
            textBoxLiczbaKlientow.Text = databaseDataSetViews.KlienciZakupy.Rows.Count.ToString();

        }

        private void dateTimePickerViewOd_ValueChanged(object sender, EventArgs e)
        {
            RefreshViews();

        }

        private void dateTimePickerViewDo_ValueChanged(object sender, EventArgs e)
        {
            RefreshViews();
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
                MessageBox.Show(@"Coś poszło nie tak:" + exc.Message);
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
                MessageBox.Show(@"Coś poszło nie tak:" + exc.Message);
            }
            wydatkiTableAdapter.Fill(databaseDataSet.Wydatki);
        }

        private void buttonDateStartMin_Click(object sender, EventArgs e)
        {
            dateTimePickerViewOd.Value = dateTimePickerViewOd.MinDate;
            RefreshViews();
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
                MessageBox.Show(@"Coś poszło nie tak:" + exc.Message);
            }
            wydatkiTypyTableAdapter.Fill(databaseDataSet.WydatkiTypy);
        }

        private void buttonDodajKury_Click(object sender, EventArgs e)
        {
            try
            {
                int ilosc = Convert.ToInt32(textBoxKuryIlosc.Text);
                string notka = textBoxNoteKury.Text;
                DateTime data = dateTimePickerKury.Value;
                kuryTableAdapter.Insert(ilosc, data, notka);
            }
            catch (Exception exc)
            {
                MessageBox.Show(@"Coś poszło nie tak:" + exc.Message);
            }
            kuryTableAdapter.Fill(databaseDataSet.Kury);
            RefreshViews();
        }

        private void buttonUsunKury_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridViewKury.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                kuryTableAdapter.DeleteByIdQuery(id);
            }
            catch (Exception exc)
            {
                MessageBox.Show(@"Coś poszło nie tak:" + exc.Message);
            }
            kuryTableAdapter.Fill(databaseDataSet.Kury);
            RefreshViews();
        }
    }
}
