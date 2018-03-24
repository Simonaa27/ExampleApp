using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleApp
{
    public partial class pacient : Form
    {
        public pacient()
        {
            InitializeComponent();
        }

        private void prikaziPacient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.matBroj.Text))
            {
                MessageBox.Show("Внесете ЕМБГ");
            }
            else
            {
                dataGridView1.Visible = true;
                string upit = "SELECT id_recept AS РеденБрој, id_pacient AS ЕМБГ, ime_p AS Име, prezime_p AS Презиме, zdr_legitimacija AS ЗдравственаЛегитимација, lek AS Лек, doza AS Доза, datum_od AS ДатумОд, datum_do AS ДатумДо, vremetraenje AS Времетраење FROM pacienti, recept WHERE pacienti.id_pacienti = recept.id_pacient AND pacienti.id_pacienti = '" + matBroj.Text + "'";
                DBConnect connection = new DBConnect();
                object dt = connection.select(upit);
                if (dt != null)
                {
                    dataGridView1.DataSource = dt;
                    connection.closeConnection();
                }
                else
                {
                    MessageBox.Show("Грешка");
                }
            }
        }

        private void pacient_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sitepacienti_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            DBConnect connection = new DBConnect();
            string upit = "SELECT id_pacienti AS ЕМБГ, ime_p AS Име, prezime_p AS Презиме, broj_karton as БројКартон, zdr_legitimacija AS ЗдравственаЛегитимација FROM pacienti WHERE id_maticen_doktor = '" + LoginInfo.doktor_id + "'";
            connection.openConnection();
            object dt = connection.select(upit);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
                connection.closeConnection();
            }
            else
            {
                MessageBox.Show("Грешка");
            }
        }

        private void izdajRecept_Click(object sender, EventArgs e)
        {
            try
            {
                string datum_od = datumOd.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
                string datum_do = datumDo.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
                string vremetraenje = vrmt.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
                DBConnect connection = new DBConnect();
                connection.openConnection();
                string upit = "INSERT INTO recept(id_pacient, id_doktor, lek, doza, datum_od, datum_do,  vremetraenje) VALUES ('" + matBroj.Text + "','" + LoginInfo.doktor_id + "','" + lek.Text + "','" + kolicinaLek.Text + "','" + datum_od + "','" + datum_do + "','" + vremetraenje + "')";
                connection.Insert(upit);

                matBroj.Text = upit;
                connection.closeConnection();
                MessageBox.Show("Издаден рецепт!");

            }

            catch
            {
                MessageBox.Show("Грешка при внесување!");
            }
        }

        private void vnesiNovPacient_Click(object sender, EventArgs e)
        {
            var form = new vnesiPacient();
            form.Show(this);
        }
    }
}
